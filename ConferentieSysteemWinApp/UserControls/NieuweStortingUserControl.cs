using ConferentieSysteemData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class NieuweStortingUserControl : UserControl
    {
        public event Action Terug;

        private Factuur _factuur = null;
        //Item1 = reeds betaald (decimal) //Item2 = in hoeveel keer (int)
        private Tuple<decimal, int> _tuple;

        public NieuweStortingUserControl()
        {
            InitializeComponent();
            stortingNumericUpDown.Maximum = decimal.MaxValue - 100;
        }

        public void AanvullenFactuurNummers()
        {
            facturenComboBox.Items.AddRange(DataFactuur.GeefFacturen().ToArray());
        }

        private void SelectedIndexChangedFacturenComboBox(object sender, EventArgs e)
        {
            _factuur = (Factuur)facturenComboBox.SelectedItem;
            InvullenLabels();
            ControleerNummericUpDown();
            opslaanButton.Enabled = true;
        }

        private void InvullenLabels()
        {       
            detailPanel.Visible = true;
            totaalBedragLabel.Text = string.Format("€{0:0.00}", _factuur.TotaalBedrag);
            bestemmingLabel.Text = _factuur.Inschrijving.Persoon.ToString();

            _tuple = DataBetaling.GeefBetalingen(_factuur.ID);
            int a = _tuple.Item2;
            hoeveelsteStortingLabel.Text = string.Format("{0}e", ++a);
            reedsGestortLabel.Text = string.Format("€{0:0.00}", _tuple.Item1);
        }

        private void ValueChangedStortingNummericUpDown(object sender, EventArgs e)
        {
            ControleerNummericUpDown();
        }

        private void ControleerNummericUpDown()
        {
            if (_factuur != null)
            {
                if (stortingNumericUpDown.Value + _tuple.Item1 == _factuur.TotaalBedrag)
                {
                    stortingNumericUpDown.ForeColor = Color.Green;
                }
                else if (stortingNumericUpDown.Value + _tuple.Item1 < _factuur.TotaalBedrag)
                {
                    stortingNumericUpDown.ForeColor = Color.Red;
                }
                else if (stortingNumericUpDown.Value + _tuple.Item1 > _factuur.TotaalBedrag)
                {
                    stortingNumericUpDown.ForeColor = Color.Black;
                }
            }
        }

        private void ClickOpslaanButton(object sender, EventArgs e)
        {
            DataBetaling.BetalingToevoegen(stortingNumericUpDown.Value, _factuur.ID);
            MessageBox.Show("Betaling toegevoegd", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Terug();
        }

        private void ClickAnulerenButton(object sender, EventArgs e)
        {
            Terug();
        }
    }
}
