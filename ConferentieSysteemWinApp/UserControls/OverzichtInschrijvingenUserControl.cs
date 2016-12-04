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
    public partial class OverzichtInschrijvingenUserControl : UserControl
    {
        public event Action NieuweInschrijving;

        public OverzichtInschrijvingenUserControl()
        {
            InitializeComponent();
            AanvullenIsnchrijvingen();
        }

        #region constructor en load

        private void AanvullenIsnchrijvingen()
        {
            List<Tuple<Persoon, Conferentie, int>> a = DataInschrijvingConferentieDagLink.GeefInschrijvingen();

            foreach (Tuple<Persoon, Conferentie, int> tuple in a)
            {
                ListViewItem lvi = new ListViewItem(tuple.Item1.ToString());
                lvi.SubItems.AddRange(new string[] 
                {
                        tuple.Item2.NaamConferentie,
                        tuple.Item3.ToString()
                });

                inschrijvingenItemListVieuw1.Add(tuple, lvi);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void InschrijvingToevoegen(object sender, EventArgs e)
        {
            NieuweInschrijving();
        }
    }
}
