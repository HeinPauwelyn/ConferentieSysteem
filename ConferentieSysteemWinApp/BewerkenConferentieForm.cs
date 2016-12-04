using ConferentieSysteemData;
using ConferentieSysteemWinApp.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class BewerkenConferentieForm : Form
    {
        public event Action ConferentieToegevogd;
        public event Action Terug;

        private List<Persoon> _personen = null;
        private Persoon _verwijderPersoon;
        private Persoon _voorzitter;
        private Conferentie _conferentie;

        #region Constructor en load

        public BewerkenConferentieForm(Persoon voorzitter)
        {
            InitializeComponent();
            startInschrijvingenDateTimePicker.MinDate = DateTime.Now.Date;
            inscrijvingsLimietdateTimePicker.MinDate = DateTime.Now.Date.AddMonths(1);
            _voorzitter = voorzitter;
        }

        public BewerkenConferentieForm(Persoon persoon, Conferentie conferentie)
            : this(persoon)
        {
            _conferentie = conferentie;
        }

        private void BewerkenConferentieForm_Load(object sender, EventArgs e)
        {
            #region Tool tip
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.SetToolTip(pictureBox1, "Typ hier tot wanneer de deelnemers\n zich mogen inschrijven.");
            #endregion Tool tip

            AanvullenExperten();

            expertisenExpertiseUserControl.AanvullenExpertisen();
            lokaalComboBox.Items.AddRange(DataLokaal.GeefLokaken().ToArray());

            sessieUserControl1.AanvullenExpertenEnExpertisen();

            if (_conferentie != null)
            {
                naamLimietTextBox.Text = _conferentie.NaamConferentie;
                inscrijvingsLimietdateTimePicker.Value = _conferentie.Inschrijvingslimiet;
                beschrijvingRichTextBox.Text = _conferentie.Beschrijving;
                //aantalDagenNumericUpDown.Value = _conferentie.MaxDeelnemers;
                startInschrijvingenDateTimePicker.Value = _conferentie.StartInschrijvingen;
            }

            AantalDagenNumericUpDownValueChanged(null, null);
        }
        #endregion Constructor en load

        #region Lokaal toevoegen

        private void anderLokaalButton_Click(object sender, EventArgs e)
        {
            lokaalGroupBox.Visible = true;
        }

        private void nieuwLokaalTextBox_TextChanged(object sender, EventArgs e)
        {
            lokaalToevoegenButton.Enabled = nieuwLokaalTextBox.Text.Trim() != string.Empty;
        }

        private void lokaalToevoegenButton_Click(object sender, EventArgs e)
        {
            if (DataLokaal.BestaatLokaal(nieuwLokaalTextBox.Text.Trim()) == false)
            {
                DataLokaal.LokaalToevoegen(nieuwLokaalTextBox.Text.Trim());

                MessageBox.Show("Lokaal is toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nieuwLokaalTextBox.Text = string.Empty;
                lokaalGroupBox.Visible = false;

                lokaalComboBox.Items.Clear();
                lokaalComboBox.Items.AddRange(DataLokaal.GeefLokaken().ToArray());
            }
        }

        private void anulerenButton_Click(object sender, EventArgs e)
        {
            lokaalGroupBox.Visible = false;
        }
        #endregion Lokaal toevoegen

        #region Experten toevoegen, verwijderen en bewerken

        private void expertenDetailListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            agendaExpertenComboBox.Items.Clear();
            agendaExpertenComboBox.Items.AddRange(expertenItemListView.GiveCheckedItems().ToArray());
        }

        private void ExpertBewerken(object sender, EventArgs e)
        {
        }

        private void ExpertVerwijderen(object sender, EventArgs e)
        {
            _verwijderPersoon = (Persoon)expertenItemListView.GetSelectedItem();

            if (MessageBox.Show("Weet u zeker dat u deze expert wilt verwijderen?", "Bevesteging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DataPersoon.VerwijderPersoon(_verwijderPersoon);

                AanvullenExperten();
            }
        }

        private void AanvullenExperten()
        {
            _personen = DataPersoon.GeefPersonen("Expert");

            expertenItemListView.ClearItems();

            foreach (Persoon persoon in _personen)
            {
                ListViewItem lvi = new ListViewItem(persoon.Voornaam);

                lvi.SubItems.AddRange(new string[]{
                    persoon.Achternaam,
                    persoon.Bedrijf.Bedrijfsnaam
                });

                expertenItemListView.Add(persoon, lvi);
            }
        }
        #endregion

        #region enabelen van knoppen

        private void expertenDetailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Persoon expert = (Persoon)expertenItemListView.GetSelectedItem();

                List<Overeenkomst> overeenkomsten = DataOvereenkomst.GeeftDomeinen(expert);
                List<ExpertiseDomein> domeinen = new List<ExpertiseDomein>();

                if (overeenkomsten.Count != 0)
                {
                    foreach (Overeenkomst overeenkomst in overeenkomsten)
                    {
                        domeinen.AddRange(DataOvereenkomstDomeinLink.GeefDomeinen(overeenkomst.ID));
                    }

                    domeinenListBox.Items.Clear();
                    domeinenListBox.Items.AddRange(domeinen.ToArray());
                }
            }

            catch (ArgumentOutOfRangeException)
            { }
        }

        private void ControleerDatums(object sender, EventArgs e)
        {
            bool resultaat = startInschrijvingenDateTimePicker.Value > DateTime.Now &&
                             startInschrijvingenDateTimePicker.Value.AddMonths(1) < inscrijvingsLimietdateTimePicker.Value;

            controleUserControl1.Check = resultaat;

            if (resultaat == true)
            {
                controleUserControl1.Bericht = "OK";
            }
            else
            {
                controleUserControl1.Bericht = "De datums zijn niet correct.";
            }
            naamLimietTextBox_TextChanged(null, null);
        }

        #endregion

        #region opslaan

        private Conferentie ConferentieToevoegen()
        {
            if (!DataConferentie.BestaatConferentie(naamLimietTextBox.Text))
            {
                DataConferentie.ConferentieToevoegen(naamLimietTextBox.Text, beschrijvingRichTextBox.Text.Trim(), inscrijvingsLimietdateTimePicker.Value, startInschrijvingenDateTimePicker.Value, _voorzitter.ID, 100);
                MessageBox.Show("Conferentie toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataConferentie.UpdateConferentie(naamLimietTextBox.Text, beschrijvingRichTextBox.Text.Trim(), inscrijvingsLimietdateTimePicker.Value, startInschrijvingenDateTimePicker.Value, 100);
                MessageBox.Show("Conferentie geüpdate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ConferentieToegevogd != null)
            {
                ConferentieToegevogd();
            }

            return DataConferentie.GeefConferentie(naamLimietTextBox.Text);
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Conferentie conf;

            switch (bewerkConferentieTabControl.SelectedTab.Text)
            {
                case "Algemeen":
                    conf = ConferentieToevoegen();
                    break;

                case "Agenda":
                    conf = ConferentieToevoegen();
                    ConferentieDagToevoegen(conf);
                    SessieToevoegen(conf);
                    break;
            }
        }

        private void ConferentieDagToevoegen(Conferentie conf)
        {
            if (!DataConferentieDag.BestaatConferentieDag(agendaMonthCalendar.SelectionStart, conf.ID))
            {
                DataConferentieDag.ToevoegenConferentieDag(agendaMonthCalendar.SelectionStart, inschrijvingsGeldNumericUpDown.Value, conf.ID);
                MessageBox.Show("Conferentie dag toegevoegd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SessieToevoegen(Conferentie conf = null)
        {
            TimeSpan begin, eind;

            if (TimeSpan.TryParse(startUurMaskedTextBox2.Text, out begin) && TimeSpan.TryParse(eindUurMaskedTextBox.Text, out eind))
            {
                ConferentieDag dag;

                if (_conferentie != null)
                {
                    dag = DataConferentieDag.GeefConferentieDag(agendaMonthCalendar.SelectionStart, _conferentie.ID);
                }
                else
                {
                    dag = DataConferentieDag.GeefConferentieDag(agendaMonthCalendar.SelectionStart, conf.ID);
                }

                Persoon expert = DataPersoon.GeefPersoonBijNaam(agendaExpertenComboBox.Text);
                ExpertiseDomein domein = (ExpertiseDomein)agendaExpertiseDomeinComboBox.SelectedItem;
                Lokaal lokaal = (Lokaal)lokaalComboBox.SelectedItem;
                bool keynote = keynoteCheckBox.Checked;

                if (keynote)
                {
                    if (!DataSessie.ControleerKeynote(dag.ID))
                    {
                        DataSessie.SessieToevoegen(begin, eind, expert.ID, dag.ID, keynote, lokaal.ID, null);
                    }
                    else
                    {
                        MessageBox.Show("Er is al een keynote toegevoegd op deze dag.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                else
                {
                    DataSessie.SessieToevoegen(begin, eind, expert.ID, dag.ID, keynote, lokaal.ID, domein.ID);
                }

                MessageBox.Show("Sessie toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("De ingevoerde start en/of eind uur is ongeldig.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region toevoegen en verwijderen expertisen

        private void expertiseUserControl1_ExpertiseToegevoegdVerwijderd()
        {
            agendaExpertiseDomeinComboBox.Items.Clear();
            agendaExpertiseDomeinComboBox.Items.AddRange(expertisenExpertiseUserControl.ToegevoegdeExpertisen.ToArray());
        }
        #endregion

        #region Fout controle

        private void controleUserControl1_Click(object sender, EventArgs e)
        {
            if (controleUserControl1.Check == false)
            {
                MessageBox.Show("Zorg ervoor dat de inschrijvings limiet 1 maand later is dan vandaag, de start van de inschrijvingen later is dan vandaag en dat de start van de inschrijvingen minstens 1 maand vroeger is dan de limiet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void controleUserControl1_CheckVeranderd(object sender, EventArgs e)
        {
        }
        #endregion

        private void TerugNaarOverzicht(object sender, EventArgs e)
        {
            if (Terug != null)
            {
                Terug();
            }
        }

        private void naamLimietTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (bewerkConferentieTabControl.SelectedTab.Text)
            {
                case "Algemeen":
                    opslaanButton.Enabled = naamLimietTextBox.Text != string.Empty &&
                                            startInschrijvingenDateTimePicker.Value > DateTime.Now &&
                                            startInschrijvingenDateTimePicker.Value.AddMonths(1) < inscrijvingsLimietdateTimePicker.Value &&
                                            beschrijvingRichTextBox.Text != string.Empty;
                    break;
                
                case "Agenda":
                    opslaanButton.Enabled = naamLimietTextBox.Text != string.Empty &&
                                            startInschrijvingenDateTimePicker.Value > DateTime.Now &&
                                            startInschrijvingenDateTimePicker.Value.AddMonths(1) < inscrijvingsLimietdateTimePicker.Value &&
                                            beschrijvingRichTextBox.Text != string.Empty &&
                                            agendaExpertenComboBox.Text != string.Empty &&
                                            agendaExpertiseDomeinComboBox.Text != string.Empty &&
                                            lokaalComboBox.Text != string.Empty;
                    break;

                default:
                    opslaanButton.Enabled = false;
                    break;
            }
        }

        private void AanpassenLimiet(object sender, EventArgs e)
        {            
            inscrijvingsLimietdateTimePicker.MinDate = startInschrijvingenDateTimePicker.Value.Date.AddMonths(1);

            inscrijvingsLimietdateTimePicker.Value = startInschrijvingenDateTimePicker.Value.Date.AddMonths(1).AddDays(1);
            ControleerDatums(null, null);
        }

        private void AantalDagenNumericUpDownValueChanged(object sender, EventArgs e)
        {      
            agendaPanel.Controls.Clear();
            int _xLocatie = 5;

            for (int teller = 1; teller <= aantalDagenNumericUpDown.Value; teller++)
            {
                ConferentieDagUserControl uc = new ConferentieDagUserControl();
                uc.Location = new Point(_xLocatie, 5);
                _xLocatie += 210;
                agendaPanel.Controls.Add(uc);
            }
        }
    }
}
