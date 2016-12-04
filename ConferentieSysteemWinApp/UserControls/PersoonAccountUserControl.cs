using ConferentieSysteemData;
using System;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class PersoonAccountUserControl : UserControl, IContacteerbaar
    {
        public new event Action TextChanged;

        private bool _bedrijfGecheckt = false;
        private Gemeente _gemeente;
        private string _straat;
        private string _huisnummer;
        private string _email;
        private string _telefoon;
        private string _gsm;
        private string _voornaam;
        private string _achternaam;
        private Bedrijf _bedrijf = null;
        private Functie _functie = null;
        private string _gebruikersnaam;
        private string _wachtwoord;
        private string _herhaalingWachtwoord;

        #region Properties

        public bool BedrijfGecheckt
        {
            get
            {
                _bedrijfGecheckt = bedrijfCheckBox.Checked;
                return _bedrijfGecheckt;
            }
            set
            {
                bedrijfCheckBox.Checked = value;
                _bedrijfGecheckt = value;
            }
        }

        public Gemeente Gemeente
        {
            get
            {
                _gemeente = contactContactGegevens.Gemeente;
                return _gemeente;
            }
            set
            {
                contactContactGegevens.Gemeente = value;
                _gemeente = value;
            }
        }

        public string Straat
        {
            get
            {
                _straat = contactContactGegevens.Straat;
                return _straat;
            }
            set
            {
                contactContactGegevens.Straat = value;
                _straat = value;
            }
        }

        public string Huisnummer
        {
            get
            {
                _huisnummer = contactContactGegevens.Huisnummer;
                return _huisnummer;
            }
            set
            {
                contactContactGegevens.Huisnummer = value;
                _huisnummer = value;
            }
        }

        public string TelefoonNr
        {
            get
            {
                _telefoon = contactContactGegevens.TelefoonNr;
                return _telefoon;
            }
            set
            {
                contactContactGegevens.TelefoonNr = value;
                _telefoon = value;
            }
        }

        public string GsmNr
        {
            get
            {
                _gsm = contactContactGegevens.GsmNr;
                return _gsm;
            }
            set
            {
                contactContactGegevens.GsmNr = value;
                _gsm = value;
            }
        }

        public string Email
        {
            get
            {
                _email = contactContactGegevens.Email;
                return _email;
            }
            set
            {
                contactContactGegevens.Email = value;
                _email = value;
            }
        }

        public string Voornaam 
        {
            get 
            {
                _voornaam = voornaamTextBox.Text.Trim();
                return _voornaam;
            }
            set
            {
                voornaamTextBox.Text = value;
                _voornaam = value;
            } 
        }

        public string Achternaam
        {
            get
            {
                _achternaam = acternaamTextBox.Text.Trim();
                return _achternaam;
            }

            set
            {
                _achternaam = value;
                acternaamTextBox.Text = value;
            }
        }

        public Bedrijf Bedrijf
        {
            get
            {
                if (bedrijfComboBox.SelectedItem != null)
                {
                    _bedrijf = (Bedrijf)bedrijfComboBox.SelectedItem;
                }
                else
                {
                    _bedrijf = null;
                }

                return _bedrijf;
            }

            set
            {
                if (value != null)
                {
                    bedrijfComboBox.Text = value.ToString();
                    bedrijfCheckBox.Checked = true;
                    bedrijfCheckBox.Enabled = false;
                    bedrijfComboBox.Enabled = false;
                    nieuwBedrijfButton.Enabled = false;
                }
            }
        }

        public Functie Functie 
        {
            get 
            {
                if (functieComboBox.SelectedItem != null)
                {
                    _functie = (Functie)functieComboBox.SelectedItem;
                }
                else
                {
                    _functie = null;
                }

                return _functie;
            }
            set
            {
                if (value != null)
                {
                    functieComboBox.Text = value.ToString();
                    functieComboBox.Enabled = false;
                }
            }
        }

        public string Gebruikersnaam
        {
            get
            {
                _gebruikersnaam = gebruikersnaamTextBox.Text.Trim();
                return _gebruikersnaam;
            }
            set
            {
                _gebruikersnaam = value;
                gebruikersnaamTextBox.Text = value;
            }
        }

        public string Wachtwoord
        {
            get
            {
                _wachtwoord = WachtwoordPasswoordTextBox.Hash;
                return _wachtwoord;
            }

            private set
            {
                _wachtwoord = value;
                WachtwoordPasswoordTextBox.Text = value;
            }
        }

        public string HerhaalingWachtwooord
        {
            get 
            {
                _herhaalingWachtwoord = herhaalWachtwoorsPasswoordTextBox1.Hash;
                return _herhaalingWachtwoord; 
            }

            private set 
            { 
                _herhaalingWachtwoord = value;
                herhaalWachtwoorsPasswoordTextBox1.Text = value;
            }
        }


        public  bool WachtwoordControle
        {
            set
            {
                if (value == true)
                {
                    herhaalWachtwooordLabel.Visible = true;
                    herhaalWachtwoorsPasswoordTextBox1.Visible = true;
                    WachtwoordPasswoordTextBox.ReadOnly = false;
                }
                else
                {
                    herhaalWachtwooordLabel.Visible = false;
                    herhaalWachtwoorsPasswoordTextBox1.Visible = false;
                    WachtwoordPasswoordTextBox.ReadOnly = true;
                }
            }
        }

        public bool InvullenGebruikersnaam { private get; set; }

        #endregion

        public PersoonAccountUserControl()
        {
            InitializeComponent();
            contactContactGegevens.TextChanged += GeefEvent;
        }

        private void voornaamTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InvullenGebruikersnaam)
            {
                gebruikersnaamTextBox.Text = string.Format("{0}{1}", voornaamTextBox.Text.Trim(), acternaamTextBox.Text.Trim());
            }

            GeefEvent(sender, e);
        }

        public void AanvullenBedrijven()
        {
            bedrijfComboBox.Items.AddRange(DataBedrijf.GeefBedrijven().ToArray());
        }

        public void AanvullenFuncties(bool alleFuncties, string functieNaam = "")
        {
            if (alleFuncties)
            {
                functieComboBox.Items.AddRange(DataFunctie.GeefAlleFuncties().ToArray());
            }
            else
            {
                functieComboBox.Items.Add(DataFunctie.GeefFunctie(functieNaam).ToString());
            }
        }

        public void InvullenWachtwoord(string wachtwoord)
        {
            Wachtwoord = wachtwoord;
        }

        private void GeefEvent(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged();
            }
        }

        private void nieuwBedrijfButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
