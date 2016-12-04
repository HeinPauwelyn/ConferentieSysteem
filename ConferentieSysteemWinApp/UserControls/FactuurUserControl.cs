using ConferentieSysteemData;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class FactuurUserControl : UserControl
    {
        public string Factuurnummer
        {
            get
            {
                return factuurNummerLabel.Text;
            }
            private set
            {
                factuurNummerLabel.Text = value;
            }
        }

        public string Bestandslokatie
        {
            get
            {
                if (bestandslokatieRichTextBox.Text == string.Empty)
                {
                    return null;
                }
                return bestandslokatieRichTextBox.Text;
            }

            private set
            {
                bestandslokatieRichTextBox.Text = value;
            }
        }

        public FactuurUserControl()
        {
            InitializeComponent();
        }

        public void PlaatsFactuurnummer()
        {
            factuurNummerLabel.Text = DataFactuur.GeefLaatsteFactuurNummer();
        }

        public void VeranderTotaalBedrag(decimal totaalBedrag)
        {
            bedragInclLabel.Text = string.Format("€{0:0.00}",totaalBedrag);
            decimal btw = totaalBedrag * (decimal)0.21;
            decimal exclBtw = totaalBedrag - btw;
            bedragExclLabel.Text = string.Format("€{0:0.00}", exclBtw);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (bestandlsokatieOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                bestandslokatieRichTextBox.Text = bestandlsokatieOpenFileDialog.FileName;
                Bestandslokatie = bestandlsokatieOpenFileDialog.FileName;
                bekijkButton.Enabled = true;
                verwijderButton.Enabled = true;
            }
        }

        private void bekijkButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(bestandslokatieRichTextBox.Text))
            {
                Process.Start(bestandslokatieRichTextBox.Text);
            }
            else
            {
                MessageBox.Show("Bestand is niet gevonden.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            bestandslokatieRichTextBox.Text = string.Empty;
            verwijderButton.Enabled = false;
            bekijkButton.Enabled = false;
        }
    }
}
