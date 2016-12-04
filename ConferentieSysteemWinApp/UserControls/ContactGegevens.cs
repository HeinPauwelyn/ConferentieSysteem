using ConferentieSysteemData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class ContactGegevens : UserControl, IContacteerbaar
    {
        public new event Action<object, EventArgs> TextChanged;

        private string _straat;
        private string _huisnummer;
        private Gemeente _gemeente = null;
        private string _telefoonNr;
        private string _email;
        private string _gsmNr;
        private string _vorigetext;
        private bool _postcode;

        #region properties

        public string Straat
        {
            get
            {
                _straat = straatLimietTextBox.Text;
                return _straat;
            }

            set
            {
                _straat = value;
                straatLimietTextBox.Text = value;
            }
        }

        public string Huisnummer
        {
            get
            {
                _huisnummer = huisnummerLimietTextBox.Text;
                return _huisnummer;
            }

            set
            {
                _huisnummer = value;
                huisnummerLimietTextBox.Text = value;
            }
        }

        public Gemeente Gemeente
        {
            get
            {
                return _gemeente;
            }

            set
            {
                if (value != null)
                {
                    _gemeente = value;
                    postcodeLimietTextBox.Text = _gemeente.Postcode.ToString();
                    gemeenteLimietTextBox.Text = _gemeente.GemeenteNaam;
                    provincieLabel.Text = _gemeente.Provincie.ProvincieNaam;
                }
                else
                {
                    _gemeente = value;
                    postcodeLimietTextBox.Text =string.Empty;
                    gemeenteLimietTextBox.Text = string.Empty;
                    provincieLabel.Text = string.Empty;
                }
            }
        }

        public string TelefoonNr
        {
            get
            {
                _telefoonNr = telefoonMaskedTextBox.Text;
                return _telefoonNr;
            }

            set
            {
                _telefoonNr = value;
                telefoonMaskedTextBox.Text = value;
            }
        }

        public string GsmNr
        {
            get
            {
                _gsmNr = gsmMaskedTextBox.Text;
                return _gsmNr;
            }

            set
            {
                _gsmNr = value;
                gsmMaskedTextBox.Text = value;
            }
        }

        public string Email
        {
            get
            {
                _email = emailLimietTextBox.Text;
                return _email;
            }

            set
            {
                _email = value;
                emailLimietTextBox.Text = value;
            }
        }
        #endregion

        #region constructor

        public ContactGegevens()
        {
            InitializeComponent();

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.SetToolTip(pictureBox1, "Correct voorbeeld: \"correct@voorbeeld.com\"");
        }
        #endregion

        #region toon listBox

        private void ToonListbox(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            switch (textbox.Name)
            {
                case "gemeenteLimietTextBox":
                    _vorigetext = textbox.Text;
                    _postcode = false;
                    break;

                case "postcodeLimietTextBox":
                    _vorigetext = textbox.Text;
                    _postcode = true;
                    break;
            }
            sugestieListBox.Visible = true;
        }
        #endregion

        #region aanvullen sugesties

        private void postcodeLimietTextBox_TextChanged(object sender, EventArgs e)
        {
            int postcode;

            if (int.TryParse(postcodeLimietTextBox.Text, out postcode))
            {
                sugestieListBox.Items.Clear();
                sugestieListBox.Items.AddRange(DataGemeente.GeefGemeenten(postcode).ToArray());
            }

            GeefEvent(sender, e);
        }

        private void gemeenteLimietTextBox_TextChanged(object sender, EventArgs e)
        {
            sugestieListBox.Items.Clear();
            sugestieListBox.Items.AddRange(DataGemeente.GeefGemeenten(gemeenteLimietTextBox.Text).ToArray());

            GeefEvent(sender, e);
        }
        #endregion

        #region sugestie gekozen

        private void sugestieListBox_DoubleClick(object sender, EventArgs e)
        {
            if (sugestieListBox.SelectedItems.Count == 1)
            {
                Gemeente gem = (Gemeente)sugestieListBox.SelectedItem;

                if (gem != null)
                {
                    postcodeLimietTextBox.Text = gem.Postcode.ToString();
                    gemeenteLimietTextBox.Text = gem.GemeenteNaam;
                    provincieLabel.Text = gem.Provincie.ProvincieNaam;

                    this.Gemeente = gem;

                    sugestieListBox.Visible = false;
                }

                else
                {
                    if (_postcode)
                    {
                        postcodeLimietTextBox.Text = _vorigetext;
                    }
                    else
                    {
                        gemeenteLimietTextBox.Text = _vorigetext;
                    }
                }
            }
        }
        #endregion

        #region raise event

        private void GeefEvent(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(sender, e);
            } 
        }
        #endregion

        #region Controleer email

        private void emailLimietTextBox_Leave(object sender, EventArgs e)
        {
            if (ConferentieSysteemWinApp.Email.ControleerEmail(emailLimietTextBox.Text) == false)
            {
                emailLimietTextBox.BackColor = Color.LightCoral;
            }

            else
            {
                emailLimietTextBox.BackColor = Color.White;
            }
        }
        #endregion

        #region controleren als alles klopt
        private void postcodeLimietTextBox_Leave(object sender, EventArgs e)
        {
            if (!sugestieListBox.Focused)
            {
                TextBox textbox = (TextBox)sender;
                int postcode;
                bool ok = int.TryParse(textbox.Text, out postcode);

                switch (textbox.Name)
                {
                    case "gemeenteLimietTextBox":
                        if (!DataGemeente.BestaatGemeente(textbox.Text))
                        {
                            gemeenteLimietTextBox.Text = _vorigetext;
                        }
                        break;

                    case "postcodeLimietTextBox":
                        if (ok)
                        {
                            if (!DataGemeente.BestaatGemeente(postcode))
                            {
                                postcodeLimietTextBox.Text = _vorigetext;
                            }
                        }
                        else
                        {
                            postcodeLimietTextBox.Text = _vorigetext;
                        }
                        break;
                }

                if (!DataGemeente.KloptGemeente(gemeenteLimietTextBox.Text, postcode))
                {
                    switch (textbox.Name)
                    {
                        case "gemeenteLimietTextBox":
                            gemeenteLimietTextBox.Text = _vorigetext;
                            break;

                        case "postcodeLimietTextBox":
                            postcodeLimietTextBox.Text = _vorigetext;
                            break;
                    }
                }
            }
        }
        #endregion

        #region alles ingevuld

        public bool AllesIngevuld()
        {
            return straatLimietTextBox.Text != string.Empty &&
                   huisnummerLimietTextBox.Text != string.Empty &&
                   Gemeente != null &&
                   telefoonMaskedTextBox.Text != string.Empty &&
                   gsmMaskedTextBox.Text != string.Empty &&
                   emailLimietTextBox.Text != string.Empty &&
                   ConferentieSysteemWinApp.Email.ControleerEmail(emailLimietTextBox.Text);
        }
        #endregion
    }
}
