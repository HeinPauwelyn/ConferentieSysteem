using ConferentieSysteemData;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class NieuweInschrijngUC : UserControl
    {
        private decimal _prijs = 0;

        public NieuweInschrijngUC()
        {
            InitializeComponent();
            factuurUserControl2.PlaatsFactuurnummer();
        }

        public void AanvullenConferenties()
        {
            conferentieListBox.Items.AddRange(DataConferentie.GeefInschrijvingConferenties().ToArray());
            deelnemerPersoonBedrijfUserControl.Ingevuld += EnabelOpslaanKnop;
            deelnemerPersoonBedrijfUserControl.Functie = "Deelnemer";
        }

        #region conferentie gekozen

        private void conferentieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conferentieListBox.SelectedItems.Count == 1)
            {
                conferentieDagPanel.Visible = true;

                Conferentie conf = (Conferentie)conferentieListBox.SelectedItem;

                volledigeConferentieCheckBox.CheckState = CheckState.Unchecked;
                conferentieDagenCheckedListBox.Items.Clear();
                sessieListBox.Items.Clear();

                List<ConferentieDag> dagen = DataConferentieDag.GeefConferentieDagen(conf.ID);

                if (dagen.Count == 0)
                {
                    volledigeConferentieCheckBox.Enabled = false;
                }
                else
                {
                    volledigeConferentieCheckBox.Enabled = true;
                    conferentieDagenCheckedListBox.Items.AddRange(dagen.ToArray());
                }
            }
        }
        #endregion

        #region Check checkboxsen

        private void conferentieDagenCheckedListBox_ItemCheck(object sender, MouseEventArgs e)
        {
            if (conferentieDagenCheckedListBox.CheckedItems.Count == 0)
            {
                volledigeConferentieCheckBox.CheckState = CheckState.Unchecked;
            }
            else if (conferentieDagenCheckedListBox.CheckedItems.Count == conferentieDagenCheckedListBox.Items.Count)
            {
                volledigeConferentieCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                volledigeConferentieCheckBox.CheckState = CheckState.Indeterminate;
            }

            AanvullenSessies();
        }

        private void volledigeConferentieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (volledigeConferentieCheckBox.CheckState == CheckState.Unchecked)
            {
                foreach (int i in conferentieDagenCheckedListBox.CheckedIndices)
                {
                    conferentieDagenCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else if (volledigeConferentieCheckBox.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < conferentieDagenCheckedListBox.Items.Count; i++)
                {
                    conferentieDagenCheckedListBox.SetItemChecked(i, true);
                }
            }

            AanvullenSessies();
        }
        #endregion

        #region Aanvulles sessies

        private void AanvullenSessies()
        {
            List<Sessie> sessies = new List<Sessie>();
            _prijs = 0;

            foreach (ConferentieDag dag in conferentieDagenCheckedListBox.CheckedItems)
            {
                sessies.AddRange(DataSessie.GeefSessies(dag.ID));
                _prijs += dag.InschrijvingsGeld;
            }

            if (volledigeConferentieCheckBox.CheckState == CheckState.Checked)
            {
                decimal korting = _prijs * 10 / 100;
                _prijs -= korting;
            }

            prijsLabel.Text = string.Format("€{0:0.00}", _prijs);
            factuurUserControl2.VeranderTotaalBedrag(_prijs);

            sessieListBox.Items.Clear();
            sessieListBox.Items.AddRange(sessies.ToArray());

            EnabelOpslaanKnop();
        }
        #endregion

        #region opslaan

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Persoon persoon = PersoonOpslaan();

            List<Inschrijving> inschrijvingen = DataInschrijving.GeefInschrijving(persoon);
            Nullable<int> inschrijvingId = null;

            foreach (Inschrijving ins in inschrijvingen)
            {
                if (!DataInschrijvingConferentieDagLink.BestaatLink(ins, InvokeCOnferentieListBox()))
                {
                    inschrijvingId = DataInschrijving.InschrijvingToevoegen(persoon.ID);
                    break;
                }
            }

            if (inschrijvingId != null)
            {
                InschrijvingToevoegen((int)inschrijvingId);
                DataFactuur.FactuurToevoegen(_prijs, (int)inschrijvingId, factuurUserControl2.Factuurnummer, DateTime.Now, null);

                MessageBox.Show("Inschrijving en factuur toegevoegd. Er wordt nu een bericht verzonden met een bevesteging.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //InschrijvingToegevoegd();

                //ZendProgressBar.Visible = true;
                Thread thread = new Thread(ZendEMail);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                MessageBox.Show("Deze inschrijving is al toegevoegd.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Persoon PersoonOpslaan()
        {
            string voornaam = deelnemerPersoonBedrijfUserControl.Voornaam;
            string achternaam = deelnemerPersoonBedrijfUserControl.Achternaam;

            if (!DataPersoon.BestaatPersoon(voornaam, achternaam))
            {
                if (deelnemerPersoonBedrijfUserControl.AangeslotenBijBedrijf)
                {
                    int bedrijdId = BedrijfToevoegen();
                    DataPersoon.PersoonToevoegen(voornaam, achternaam, deelnemerPersoonBedrijfUserControl.Straat, deelnemerPersoonBedrijfUserControl.Huisnummer, deelnemerPersoonBedrijfUserControl.Gemeente, deelnemerPersoonBedrijfUserControl.TelefoonNr, deelnemerPersoonBedrijfUserControl.GsmNr, deelnemerPersoonBedrijfUserControl.Email, 1, bedrijdId, deelnemerPersoonBedrijfUserControl.Gebruikersnaam, deelnemerPersoonBedrijfUserControl.Wachtwoord);
                }

                else
                {
                    DataPersoon.PersoonToevoegen(voornaam, achternaam, deelnemerPersoonBedrijfUserControl.Straat, deelnemerPersoonBedrijfUserControl.Huisnummer, deelnemerPersoonBedrijfUserControl.Gemeente, deelnemerPersoonBedrijfUserControl.TelefoonNr, deelnemerPersoonBedrijfUserControl.GsmNr, deelnemerPersoonBedrijfUserControl.Email, 1, null, deelnemerPersoonBedrijfUserControl.Gebruikersnaam, deelnemerPersoonBedrijfUserControl.Wachtwoord);
                }
            }

            return DataPersoon.GeefPersoonBijNaam(voornaam, achternaam);
        }

        private int BedrijfToevoegen()
        {
            int bedrijfsId;

            if (!DataBedrijf.BestaatBedrijf(deelnemerPersoonBedrijfUserControl.Bedrijfsnaam))
            {
                bedrijfsId = DataBedrijf.BedrijfToevoegenEnGeefId(deelnemerPersoonBedrijfUserControl.Bedrijfsnaam, deelnemerPersoonBedrijfUserControl.Bedrijfsnaam, deelnemerPersoonBedrijfUserControl.BedrijfHuisnummer, deelnemerPersoonBedrijfUserControl.BedrijfGemeente, deelnemerPersoonBedrijfUserControl.BedrijfTelefoonNr, deelnemerPersoonBedrijfUserControl.BedrijfGsmNr, deelnemerPersoonBedrijfUserControl.BedrijfEmail, deelnemerPersoonBedrijfUserControl.BTWNummer);
            }
            else
            {
                bedrijfsId = DataBedrijf.GeefBedrijf(deelnemerPersoonBedrijfUserControl.Bedrijfsnaam);
            }

            return bedrijfsId;
        }

        private void InschrijvingToevoegen(int inschrijvingsId)
        {
            foreach (ConferentieDag dag in conferentieDagenCheckedListBox.CheckedItems)
            {
                if (!DataInschrijvingConferentieDagLink.BestaatLink(dag.ID, inschrijvingsId))
                {
                    DataInschrijvingConferentieDagLink.LinkToevoegen(dag.ID, inschrijvingsId);
                }
            }
        }
        #endregion

        #region enabel knoppen

        private void EnabelOpslaanKnop()
        {
            opslaanButton.Enabled = deelnemerPersoonBedrijfUserControl.AllesIngevuld && conferentieDagenCheckedListBox.CheckedItems.Count >= 1;
        }
        #endregion

        #region zend email

        private void ZendEMail()
        {
            MailMessage bericht = new MailMessage();
            bericht.From = new MailAddress("noreplay@hp.com");
            bericht.To.Add(deelnemerPersoonBedrijfUserControl.Email);

            if (deelnemerPersoonBedrijfUserControl.BedrijfEmail != string.Empty)
            {
                bericht.CC.Add(deelnemerPersoonBedrijfUserControl.BedrijfEmail);
            }

            bericht.Subject = "Inschrijving hp";
            
            StringBuilder twee = new StringBuilder();

            foreach (ConferentieDag dag in conferentieDagenCheckedListBox.CheckedItems)
            {
                twee.Append(dag.Datum);
                twee.Append(Environment.NewLine);
            }

            Conferentie conf = InvokeCOnferentieListBox();
            string een = string.Format("Bij deze willen wij u melden dat {1} {2} ingeschreven is voor de conferentie over {3} op volgende conferentiedagen: {0}", Environment.NewLine, deelnemerPersoonBedrijfUserControl.Voornaam, deelnemerPersoonBedrijfUserControl.Achternaam, conf.NaamConferentie);
            string drie = string.Format("U kunt zich aanmelden in het systeem met volgende gebruikersnaam en wachtwoord:{0}Gebruikersnaam: {1}{0}Wachtwoord: {2}{0}Je kan deze mog altijd aanpassen.", Environment.NewLine, deelnemerPersoonBedrijfUserControl.Gebruikersnaam, deelnemerPersoonBedrijfUserControl.Wachtwoord);

            bericht.Body = string.Format("Beste, {0}{0}{1}{2}{3}{0}{0}Met vriendelijke groeten,{0}Conferenties HP", Environment.NewLine, een, twee, drie);

            Email.EmailVerzonden += Email_EmailVerzonden;
            Email.Zenden(bericht, deelnemerPersoonBedrijfUserControl.Email, "conferentieshp@outlook.com", "Conferenties");
            Email.EmailVerzonden -= Email_EmailVerzonden;
        }

        private void Email_EmailVerzonden(bool verzonden, string info)
        {
            if (verzonden)
            {
                MessageBox.Show(info, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(info, "Waarshuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            InvokeProgresBar();
        }
        #endregion

        #region Invoken

        private void InvokeProgresBar()
        {
            /*if (ZendProgressBar.InvokeRequired)
            {
                ZendProgressBar.Invoke(new Action(InvokeProgresBar));
            }
            else
            {
                ZendProgressBar.Visible = false;
            }*/
        }

        private Conferentie InvokeCOnferentieListBox()
        {
            if (conferentieListBox.InvokeRequired)
            {
                return (Conferentie)conferentieListBox.Invoke(new Func<Conferentie>(InvokeCOnferentieListBox));
            }
            else
            {
                return (Conferentie)conferentieListBox.SelectedItem;
            }
        }
        #endregion
    }
}
