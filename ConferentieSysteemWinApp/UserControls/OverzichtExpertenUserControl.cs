using ConferentieSysteemData;
using ConferentieSysteemWinApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class OverzichtExpertenUserControl : UserControl
    {
        public OverzichtExpertenUserControl()
        {
            InitializeComponent();
            this.Size = new Size(1000, 382);
            detailsPersoonBedrijfUserControl.TextChanged += detailsPersoonBedrijfUserControl_TextChanged;
        }

        void detailsPersoonBedrijfUserControl_TextChanged(object sender, EventArgs e)
        {
            if (toevoegenButton.Text == "Opslaan")
            {
                toevoegenButton.Enabled = detailsPersoonBedrijfUserControl.AllesIngevuld;
            }
        }

        public void AanvullenExperten()
        {
            List<Persoon> experten = DataPersoon.GeefPersonen("Expert");

            foreach (Persoon expert in experten)
            {
                ListViewItem lvi = new ListViewItem(expert.Voornaam);
                lvi.SubItems.AddRange(new string[]{
                    expert.Achternaam,
                    expert.Bedrijf.Bedrijfsnaam
                });

                expertenItemListView.Add(expert, lvi);
            }
        }

        private void itemListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            detailsButton.Enabled = expertenItemListView.SelectedItems.Count == 1;
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (detailsButton.Text == "Details")
            {
                detailsButton.Enabled = true;
                expertenItemListView.Visible = false;
                groupBox1.Location = new Point(7, 3);
                detailsButton.Text = "Overzicht";
                detailsButton.Image = Resources.vorig;
                toevoegenButton.Enabled = false;

                Persoon persoon = (Persoon)expertenItemListView.GetSelectedItem();
                ToonContactGegevens(persoon);
            }

            else if (detailsButton.Text == "Overzicht")
            {
                detailsButton.Enabled = true;
                expertenItemListView.Visible = true;
                groupBox1.Location = new Point(1008, 3);
                detailsButton.Text = "Details";
                detailsButton.Image = Resources.Volgend;
                toevoegenButton.Enabled = true;
            }
        }

        private void ToonContactGegevens(Persoon persoon = null)
        {
            detailsPersoonBedrijfUserControl.ZoekFunctiePersonen = false;

            if (persoon != null)
            {
                detailsPersoonBedrijfUserControl.ZoekFunctieBedrijf = false;
                detailsPersoonBedrijfUserControl.Voornaam = persoon.Voornaam;
                detailsPersoonBedrijfUserControl.Achternaam = persoon.Achternaam;
                detailsPersoonBedrijfUserControl.Straat = persoon.Straat;
                detailsPersoonBedrijfUserControl.Huisnummer = persoon.Huisnummer;
                detailsPersoonBedrijfUserControl.Gemeente = persoon.Gemeente;
                detailsPersoonBedrijfUserControl.TelefoonNr = persoon.TelefoonNummer;
                detailsPersoonBedrijfUserControl.GsmNr = persoon.GsmNummer;
                detailsPersoonBedrijfUserControl.Email = persoon.EmailAdres;
                detailsPersoonBedrijfUserControl.Bedrijfsnaam = persoon.Bedrijf.Bedrijfsnaam;
                detailsPersoonBedrijfUserControl.BedrijfStraat = persoon.Bedrijf.Straat;
                detailsPersoonBedrijfUserControl.BedrijfHuisnummer = persoon.Bedrijf.Huisnummer;
                detailsPersoonBedrijfUserControl.BedrijfGemeente = persoon.Bedrijf.Gemeente;
                detailsPersoonBedrijfUserControl.BedrijfGsmNr = persoon.Bedrijf.GsmNummer;
                detailsPersoonBedrijfUserControl.TelefoonNr = persoon.Bedrijf.TelefoonNummer;
                detailsPersoonBedrijfUserControl.Email = persoon.Bedrijf.EmailAdres;
                detailsPersoonBedrijfUserControl.BTWNummer = persoon.Bedrijf.BtwNummer;
            }
            else
            {
                detailsPersoonBedrijfUserControl.ZoekFunctieBedrijf = true;
                detailsPersoonBedrijfUserControl.Voornaam = string.Empty;
                detailsPersoonBedrijfUserControl.Achternaam = string.Empty;
                detailsPersoonBedrijfUserControl.Straat = string.Empty;
                detailsPersoonBedrijfUserControl.Huisnummer = string.Empty;
                detailsPersoonBedrijfUserControl.Gemeente = null;
                detailsPersoonBedrijfUserControl.TelefoonNr = string.Empty;
                detailsPersoonBedrijfUserControl.GsmNr = string.Empty;
                detailsPersoonBedrijfUserControl.Email = string.Empty;
                detailsPersoonBedrijfUserControl.Bedrijfsnaam = string.Empty;
                detailsPersoonBedrijfUserControl.BedrijfStraat = string.Empty;
                detailsPersoonBedrijfUserControl.BedrijfHuisnummer = string.Empty;
                detailsPersoonBedrijfUserControl.BedrijfGemeente = null;
                detailsPersoonBedrijfUserControl.BedrijfGsmNr = string.Empty;
                detailsPersoonBedrijfUserControl.TelefoonNr = string.Empty;
                detailsPersoonBedrijfUserControl.Email = string.Empty;
                detailsPersoonBedrijfUserControl.BTWNummer = string.Empty;
            }
        }

        private void ExpertToevoegen()
        {
            ToonContactGegevens();

            if (toevoegenButton.Text == "Toevoegen")
            {
                //ga naar details
                
                expertenItemListView.Visible = false;
                groupBox1.Location = new Point(7, 3);
                toevoegenButton.Text = "Opslaan";
                toevoegenButton.Image = Resources.Opslaan16;
                toevoegenButton.Enabled = false;
                anulerenButton.Visible = true;
                detailsButton.Enabled = false;
            }

            else if (toevoegenButton.Text == "Opslaan")
            {
                //opslaan
                ExpertOpslaan();

                anulerenButton.Visible = false;
                detailsButton.Enabled = false;
                expertenItemListView.Visible = true;
                groupBox1.Location = new Point(1008, 3);
                toevoegenButton.Text = "Toevoegen";
                detailsButton.Text = "Details";
                detailsButton.Image = Resources.Volgend;
                toevoegenButton.Image = Resources.Toevoegen16;
            }
        }

        private void ExpertOpslaan()
        {
            if (!DataPersoon.BestaatPersoon(detailsPersoonBedrijfUserControl.Voornaam, detailsPersoonBedrijfUserControl.Achternaam))
            {
                int bedrijfsId;

                if (!DataBedrijf.BestaatBedrijf(detailsPersoonBedrijfUserControl.Bedrijfsnaam))
                {
                    bedrijfsId = DataBedrijf.BedrijfToevoegenEnGeefId(detailsPersoonBedrijfUserControl.Bedrijfsnaam, detailsPersoonBedrijfUserControl.BedrijfStraat, detailsPersoonBedrijfUserControl.BedrijfHuisnummer, detailsPersoonBedrijfUserControl.BedrijfGemeente, detailsPersoonBedrijfUserControl.BedrijfTelefoonNr, detailsPersoonBedrijfUserControl.BedrijfGsmNr, detailsPersoonBedrijfUserControl.BedrijfEmail, detailsPersoonBedrijfUserControl.BTWNummer);
                }
                else
                {
                    bedrijfsId = DataBedrijf.GeefBedrijf(detailsPersoonBedrijfUserControl.Bedrijfsnaam);
                }

                DataPersoon.PersoonToevoegen(detailsPersoonBedrijfUserControl.Voornaam, detailsPersoonBedrijfUserControl.Achternaam, detailsPersoonBedrijfUserControl.Straat, detailsPersoonBedrijfUserControl.Huisnummer, detailsPersoonBedrijfUserControl.Gemeente, detailsPersoonBedrijfUserControl.TelefoonNr, detailsPersoonBedrijfUserControl.GsmNr, detailsPersoonBedrijfUserControl.Email, 3, bedrijfsId, detailsPersoonBedrijfUserControl.Gebruikersnaam, detailsPersoonBedrijfUserControl.Wachtwoord);

                MessageBox.Show("Persoon is toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            ExpertToevoegen();
        }

        private void anulerenButton_Click(object sender, EventArgs e)
        {
            anulerenButton.Visible = false;
            detailsButton.Enabled = true;
            toevoegenButton.Enabled = true;
            expertenItemListView.Visible = true;
            groupBox1.Location = new Point(1008, 3);
            toevoegenButton.Text = "Toevoegen";
            detailsButton.Text = "Details";
            detailsButton.Image = Resources.Volgend;
            toevoegenButton.Image = Resources.Toevoegen16;
        }
    }
}
