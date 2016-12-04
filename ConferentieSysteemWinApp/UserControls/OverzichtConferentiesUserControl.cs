using ConferentieSysteemData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class OverzichtConferentiesUserControl : UserControl
    {
        private Persoon _voorzitter;
        public event Action<Conferentie> ConferentieAanmaken;

        public OverzichtConferentiesUserControl()
        {
            InitializeComponent();
        }

        public void AanvullenLijst()
        {
            List<Conferentie> conferenties = DataConferentie.GeefConferenties();

            foreach (Conferentie conferentie in conferenties)
            {
                ListViewItem lvi = new ListViewItem(conferentie.NaamConferentie);
                lvi.SubItems.AddRange(new string[] {
                    conferentie.Persoon.ToString(),
                    conferentie.StartInschrijvingen.ToShortDateString()
                });

                overzichtConferentiesItemListView.Add(conferentie, lvi);
            }
        }

        private void conferentiesDetailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bewerkenSplitButton1.Enabled = overzichtConferentiesItemListView.CountSelectedItems() == 1;
        }

        public void ZetVoorzitter(Persoon persoon)
        {
            _voorzitter = persoon;
        }

        private void NieuweConferentie(object sender, EventArgs e)
        {
            ConferentieAanmaken(null);
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conferentie conf = GeefConferentie();

            if (conf.StartInschrijvingen <= DateTime.Now)
            {
                MessageBox.Show("Deze conferentie kan je niet meer verwijderen omdat de inschrijvingen begonnen zijn.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Conferentie GeefConferentie()
        {
            return (Conferentie)overzichtConferentiesItemListView.GetSelectedItem();
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conferentie conf = GeefConferentie();

            if (conf.StartInschrijvingen <= DateTime.Now)
            {
                MessageBox.Show("Deze conferentie kan je niet meer aanpassen omdat de inschrijvingen begonnen zijn.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ConferentieAanmaken(conf);
            }
        }
    }
}
