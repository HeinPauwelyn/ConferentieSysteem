using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferentieSysteemData;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class PersoonBedrijfUserControl : UserControl, IContacteerbaar
    {
        public new event EventHandler TextChanged;
        public event Action Ingevuld;

        private bool _allesIngevuld = false;

        #region propeties

        public string Functie { private get; set; }

        public bool ZoekFunctiePersonen
        {
            set
            {
                persoonZoekenButton.Visible = value;
            }
        }

        public bool ZoekFunctieBedrijf
        {
            set
            {
                bedrijfZoekenButton.Visible = value;
            }
        }

        public string Voornaam
        {
            get
            {
                return voornaamLimietTextBox1.Text;
            }
            set
            {
                voornaamLimietTextBox1.Text = value;
            }
        }

        public string  Achternaam 
        {
            get 
            {
                return achternaamLimietTextBox.Text;
            }
            set
            {
                achternaamLimietTextBox.Text = value;
            }
        }

        public string Straat
        {
            get
            {
                return DeelnemerContactGegevens1.Straat;
            }
            set
            {
                DeelnemerContactGegevens1.Straat = value;
            }
        }

        public string Huisnummer
        {
            get
            {
                return DeelnemerContactGegevens1.Huisnummer;
            }
            set
            {
                DeelnemerContactGegevens1.Huisnummer = value;
            }
        }

        public Gemeente Gemeente
        {
            get
            {
                return DeelnemerContactGegevens1.Gemeente;
            }
            set
            {
                DeelnemerContactGegevens1.Gemeente = value;
            }
        }

        public string TelefoonNr
        {
            get
            {
                return DeelnemerContactGegevens1.TelefoonNr;
            }
            set
            {
                DeelnemerContactGegevens1.TelefoonNr = value;
            }
        }

        public string GsmNr
        {
            get
            {
                return DeelnemerContactGegevens1.GsmNr;
            }
            set
            {
                DeelnemerContactGegevens1.GsmNr = value;
            }
        }

        public string Email
        {
            get
            {
                return DeelnemerContactGegevens1.Email;
            }
            set
            {
                DeelnemerContactGegevens1.Email = value;
            }
        }

        public string Gebruikersnaam
        {
            get
            {
                return gebruikersnaamLimietTextBox.Text;
            }
            set
            {
                gebruikersnaamLimietTextBox.Text = value;
            }
        }

        public string Wachtwoord
        {
            get
            {
                if (wachtwoordPasswoordTextBox.Text != string.Empty)
                {
                    return wachtwoordPasswoordTextBox.Hash;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                wachtwoordPasswoordTextBox.Text = value;
            }
        }

        public bool AangeslotenBijBedrijf
        {
            get
            {
                return bedrijfCheckBox.Checked;
            }
            set
            {
                bedrijfCheckBox.Enabled = false;
                bedrijfCheckBox.Checked = value;
            }
        }

        public string Bedrijfsnaam
        {
            get
            {
                return bedrijfsnaamLimietTextBox.Text;
            }
            set
            {
                bedrijfsnaamLimietTextBox.Text = value;
            }
        }

        public string BedrijfStraat
        {
            get
            {
                return bedrijfContactGegevens2.Straat;
            }
            set
            {
                bedrijfContactGegevens2.Straat = value;
            }
        }

        public string BedrijfHuisnummer
        {
            get
            {
                return bedrijfContactGegevens2.Huisnummer;
            }
            set
            {
                bedrijfContactGegevens2.Huisnummer = value;
            }
        }

        public Gemeente BedrijfGemeente
        {
            get
            {
                return bedrijfContactGegevens2.Gemeente;
            }
            set
            {
                bedrijfContactGegevens2.Gemeente = value;
            }
        }

        public string BedrijfTelefoonNr
        {
            get
            {
                return bedrijfContactGegevens2.TelefoonNr;
            }
            set
            {
                bedrijfContactGegevens2.TelefoonNr = value;
            }
        }

        public string BedrijfGsmNr
        {
            get
            {
                return bedrijfContactGegevens2.GsmNr;
            }
            set
            {
                bedrijfContactGegevens2.GsmNr = value;
            }
        }

        public string BedrijfEmail
        {
            get
            {
                return bedrijfContactGegevens2.Email;
            }
            set
            {
                bedrijfContactGegevens2.Email = value;
            }
        }

        public string BTWNummer
        {
            get
            {
                return btwNummerMaskedTextBox1.Text;
            }
            set
            {
                btwNummerMaskedTextBox1.Text = value;
            }
        }

        public bool AllesIngevuld
        {
            get
            {
                return _allesIngevuld;
            }

            private set
            {
                if (Ingevuld != null)
                {
                    Ingevuld();
                }
            }
        }
        
        #endregion

        public PersoonBedrijfUserControl()
        {
            InitializeComponent();
            bedrijfContactGegevens2.TextChanged += gebruikersnaamLimietTextBox_TextChanged;
            DeelnemerContactGegevens1.TextChanged += gebruikersnaamLimietTextBox_TextChanged;
        }

        private void voornaamLimietTextBox1_TextChanged(object sender, EventArgs e)
        {
            gebruikersnaamLimietTextBox.Text = string.Format("{0} {1}", voornaamLimietTextBox1.Text, achternaamLimietTextBox.Text);
            gebruikersnaamLimietTextBox_TextChanged(null, null);
        }

        private void gebruikersnaamLimietTextBox_TextChanged(object sender, EventArgs e)
        {
            bool deelDeelnemerIngevuld = voornaamLimietTextBox1.Text != string.Empty &&
                                     achternaamLimietTextBox.Text != string.Empty &&
                                     DeelnemerContactGegevens1.AllesIngevuld() &&
                                     gebruikersnaamLimietTextBox.Text != string.Empty;

            if (bedrijfCheckBox.Checked)
            {
                AllesIngevuld = deelDeelnemerIngevuld &&
                                bedrijfsnaamLimietTextBox.Text != string.Empty &&
                                bedrijfContactGegevens2.AllesIngevuld() == true &&
                                btwNummerMaskedTextBox1.Text != string.Empty;
            }
            else
            {
                AllesIngevuld = deelDeelnemerIngevuld;
            }

            if (TextChanged != null)
            {
                TextChanged(sender, e);
            }
        }

        private void bedrijfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bedrijfGroupBox.Visible = bedrijfCheckBox.Checked;
            gebruikersnaamLimietTextBox_TextChanged(null, null);
        }

        private void persoonZoekenButton_Click(object sender, EventArgs e)
        {        
            BasisForm ouder =  (BasisForm)this.ParentForm;
            PersoonZoekenForm form = new PersoonZoekenForm(Functie);
            form.PersoonGevonden += form_PersoonGevonden;

            ouder.Visible = false;
            form.ShowDialog();
            ouder.Visible = true;
        }

        void form_PersoonGevonden(Persoon persoon)
        {
            Voornaam = persoon.Voornaam;
            Achternaam = persoon.Achternaam;
            Straat = persoon.Straat;
            Huisnummer = persoon.Huisnummer;
            Gemeente = persoon.Gemeente;
            TelefoonNr = persoon.TelefoonNummer;
            GsmNr = persoon.GsmNummer;
            Email = persoon.EmailAdres;
            Gebruikersnaam = persoon.Gebruikernaam;
            Wachtwoord = string.Empty;

            if (persoon.Bedrijf != null)
            {
                AangeslotenBijBedrijf = true;

                Bedrijf bed = persoon.Bedrijf;

                Bedrijfsnaam = bed.Bedrijfsnaam;
                BedrijfStraat = bed.Straat;
                BedrijfHuisnummer = bed.Huisnummer;
                BedrijfGemeente = bed.Gemeente;
                BedrijfTelefoonNr = bed.TelefoonNummer;
                BedrijfGsmNr = bed.GsmNummer;
                BedrijfEmail = bed.EmailAdres;
                BTWNummer = bed.BtwNummer;
            }
        }
    }
}
