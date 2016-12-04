using ConferentieSysteemData;
using System;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class ExpertiseToevoegenForm : Form
    {
        public event Action DomeinToegevoegd;

        #region Constructor en load

        public ExpertiseToevoegenForm()
        {
            InitializeComponent();
        }

        private void ExpertiseToevoegenForm_Load(object sender, EventArgs e)
        {
            expertiseComboBox.Items.AddRange(DataExpertise.GeefExpertisen().ToArray());
            domeinenListBox.Items.AddRange(DataExpertiseDomein.GeefDomeinen().ToArray());

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.SetToolTip(InfoDomeinPictureBox, "/ is niet toegelaten");
            tip.SetToolTip(infoExpertiseInfoPictureBox , "/ is niet toegelaten");
        }
        #endregion

        #region Expertise toevoegen

        private void GroupBoxNieuweExpertiseTonen(object sender, EventArgs e)
        {
            nieuweExpertiseGroupBox.Visible = true;
            nieuweExpertiseButton.Enabled = false;
        }

        private void ExpertiseToevoegen(object sender, EventArgs e)
        {
            if (DataExpertise.BestaatExpetise(nieuweExpertiseTextBox.Text.Trim()) == false)
            {                
                DataExpertise.ExpertiseToevoegen(nieuweExpertiseTextBox.Text.Trim(), nieuwExpertiseBeschrijvingRichTextBox.Text.Trim());
                MessageBox.Show("Expetise is toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                expertiseComboBox.Items.Clear();
                expertiseComboBox.Items.AddRange(DataExpertise.GeefExpertisen().ToArray());
            }

            else
            {
                MessageBox.Show("Expertise bestaat al", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            nieuweExpertiseGroupBox.Visible = false;
            nieuwExpertiseBeschrijvingRichTextBox.Text = "";
            nieuweExpertiseTextBox.Text = "";
            nieuweExpertiseButton.Enabled = true;
        }

        private void EnabelExpertiseToevoegenButton(object sender, EventArgs e)
        {
            expertiseToevoegenButton.Enabled = nieuweExpertiseTextBox.Text.Trim() != string.Empty && nieuwExpertiseBeschrijvingRichTextBox.Text.Trim() != string.Empty && !nieuweExpertiseTextBox.Text.Contains("/");
        }
        #endregion

        #region Expertise domein opslaan

        private void expertiseComboBox_TextChanged(object sender, EventArgs e)
        {
            opslaanButton.Enabled = expertiseComboBox.Text != string.Empty && nieuwDomeinBechrijvingRichTextBox.Text.Trim() != string.Empty && domeinLimietTextBox.Text != string.Empty && !domeinLimietTextBox.Text.Contains("/");
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Expertise expertise = (Expertise)expertiseComboBox.SelectedItem;

            if (DataExpertiseDomein.BestaatDomein(expertise.ID, domeinLimietTextBox.Text) == false)
            {
                DataExpertiseDomein.DomeinToevoegen(expertise.ID, domeinLimietTextBox.Text, nieuwDomeinBechrijvingRichTextBox.Text.Trim());

                MessageBox.Show("Domein is toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DomeinToegevoegd != null)
                {
                    DomeinToegevoegd();
                }
            }

            else
            {
                MessageBox.Show("Domein bestaat al", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void Anuleren(object sender, EventArgs e)
        {
            nieuweExpertiseGroupBox.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            domeinGroupBox.Visible = true;
        }

        private void domeinenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpertiseDomein domein = (ExpertiseDomein)domeinenListBox.SelectedItem;
            expertiseLabel.Text = domein.Expertise.ExpertiseNaam;
            expertiseBeshrijvingRichTextBox.Text = domein.Expertise.Beschrijving;
            domeinLabel.Text = domein.ExpertiseDomeinNaam;
            domeinBeschrijvingRichTextBox.Text = domein.Beschrijving;
        }

        private void AnulerenDomeinButton_Click(object sender, EventArgs e)
        {
            domeinGroupBox.Visible = false;
        }
    }
}
