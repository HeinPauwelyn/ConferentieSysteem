using ConferentieSysteemData;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class EvaluatieForm : BasisForm
    {
        #region constructor en load

        public EvaluatieForm(Persoon persoon)
        {
            InitializeComponent();
            _persoon = persoon;
        }

        private void EvaluatieForm_Load(object sender, EventArgs e)
        {
            coneferentieComboBox.Items.AddRange(DataInschrijvingConferentieDagLink.GeefInschrijvingenVanPersoon(_persoon.ID).ToArray());
        }
        #endregion

        #region enabel knop
        
        private void EnabelOpslaanKnop(object sender, EventArgs e)
        {
            opslaanButton.Enabled = coneferentieComboBox.Text != string.Empty &&
                                    conferentieDagComboBox.Text != string.Empty &&
                                    expertComboBox.Text != string.Empty &&
                                    sessieComboBox.Text != string.Empty &&
                                    vraagDrieComboBox.Text != string.Empty &&
                                    vraagEenComboBox.Text != string.Empty &&
                                    vraagTweeComboBox.Text != string.Empty;
        }
        #endregion

        #region opslaan evaluatie

        private float BerekenUitslag()
        {
            float schore = 0;

            switch (vraagEenComboBox.Text)
            {
                case "Volledig eens":
                    schore += 8;
                    break;

                case "Gedeeltelijk eens":
                    schore += 4;
                    break;

                case "Gedeeltelijk oneens":
                    schore += 2;
                    break;

                case "Volledig oneens":
                    schore += 1;
                    break;
            }

            switch (vraagTweeComboBox.Text)
            {
                case "Volledig eens":
                    schore += 8;
                    break;

                case "Gedeeltelijk eens":
                    schore += 4;
                    break;

                case "Gedeeltelijk oneens":
                    schore += 2;
                    break;

                case "Volledig oneens":
                    schore += 1;
                    break;
            }

            switch (vraagDrieComboBox.Text)
            {
                case "Volledig eens":
                    schore += 8;
                    break;

                case "Gedeeltelijk eens":
                    schore += 4;
                    break;

                case "Gedeeltelijk oneens":
                    schore += 2;
                    break;

                case "Volledig oneens":
                    schore += 1;
                    break;
            }

            return schore;
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Persoon expert = (Persoon)expertComboBox.SelectedItem;
            Sessie sessie = (Sessie)sessieComboBox.SelectedItem;

            if (!DataEvaluatie.BestaatEvaluatie(expert.ID, sessie.ID, _persoon.ID))
            {
                float schore = BerekenUitslag();

                DataEvaluatie.EvaluatieToevoegen(expert.ID, _persoon.ID, schore, opmerkingenRichTextBox.Text.Trim(), sessie.ID);
                MessageBox.Show("Deze evaluatie is toegevoegd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("U hebt deze evaluatie ingevuld.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void coneferentieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conferentie conf = (Conferentie)coneferentieComboBox.SelectedItem;
            
            sessieComboBox.Items.Clear();
            expertComboBox.Items.Clear();
            conferentieDagComboBox.Items.Clear();
            conferentieDagComboBox.Items.AddRange(DataInschrijvingConferentieDagLink.GeefIngeschrevenDagenVanPersoon(_persoon.ID, conf.ID).ToArray());
        }

        private void sessieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConferentieDag dag = (ConferentieDag)conferentieDagComboBox.SelectedItem;

            sessieComboBox.Items.Clear();
            expertComboBox.Items.Clear();
            expertComboBox.Items.AddRange(DataSessie.GeefExperten(dag.ID).ToArray());
        }

        private void expertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConferentieDag dag = (ConferentieDag)conferentieDagComboBox.SelectedItem;
            Persoon expert = (Persoon)expertComboBox.SelectedItem;

            sessieComboBox.Items.Clear();
            sessieComboBox.Items.AddRange(DataSessie.GeefSessiesVanPersoonOpDag(dag.ID, expert.ID).ToArray());
        }

        private void facebookButton_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void siteButton_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.be");
        }
    }
}
