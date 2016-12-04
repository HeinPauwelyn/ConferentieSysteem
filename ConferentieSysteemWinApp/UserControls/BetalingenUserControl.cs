using ConferentieSysteemData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class BetalingenUserControl : UserControl
    {
        public event Action NieuweStorting;

        public BetalingenUserControl()
        {
            InitializeComponent();
        }

        public void AanvullenFacturen()
        {
            List<Tuple<Factuur, decimal, int>> lijst = DataBetaling.GeefBetalingen();

            foreach (Tuple<Factuur, decimal, int> tuple in lijst)
            {
                ListViewItem lvi = new ListViewItem(tuple.Item1.FactuurNummer);
                lvi.SubItems.AddRange(new string[]{
                    tuple.Item1.OpmaakDatum.ToShortDateString(),
                    tuple.Item1.Inschrijving.Persoon.ToString(),
                    string.Format("€{0:0.00}",tuple.Item1.TotaalBedrag),
                    string.Format("€{0:0.00}",tuple.Item2),
                    tuple.Item3.ToString()
                });

                if (tuple.Item1.TotaalBedrag == tuple.Item2)
                {
                    lvi.ForeColor = Color.Green;
                }
                else if (tuple.Item1.TotaalBedrag > tuple.Item2)
                {
                    lvi.ForeColor = Color.Red;
                }
                else
                {
                    lvi.ForeColor = Color.Black;
                }

                betalingenItemListView.Add(tuple, lvi);
            }
        }

        private void stortingButton_Click(object sender, EventArgs e)
        {
            if (NieuweStorting != null)
            {
                NieuweStorting();
            }
        }
    }
}
