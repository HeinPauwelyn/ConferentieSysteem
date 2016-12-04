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
using System.Diagnostics;
using System.IO;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class ContractenUserControl : UserControl
    {
        public ContractenUserControl()
        {
            InitializeComponent();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(toevoegenButton, "Contract toevoegen.");
            tip.SetToolTip(verwijderenButton, "Verwijder geselecteerd contract");
            tip.SetToolTip(bekijkButton, "Bekijk het bestand van de geselecteerde contract");
        }

        public void AanvullenContracten(Persoon persoon)
        {
            expertLabel.Text = persoon.ToString();

            List<Overeenkomst> overeenkomsten = DataOvereenkomst.GeefContracten(persoon);

            overeenkomstItemListView.ClearItems();
            domeinenListBox.Items.Clear();

            foreach (Overeenkomst overeenkomst in overeenkomsten)
            {
                ListViewItem lvi = new ListViewItem(overeenkomst.BeginDatum.ToShortDateString());
                lvi.SubItems.Add(overeenkomst.EindDatum.ToShortDateString());

                overeenkomstItemListView.Add(overeenkomst, lvi);
            }
        }

        private void overeenkomstItemListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Overeenkomst overeenkomst = (Overeenkomst)overeenkomstItemListView.GetSelectedItem();
            domeinenListBox.Items.Clear();

            if (overeenkomst != null)
            {
                domeinenListBox.Items.AddRange(DataOvereenkomstDomeinLink.GeefDomeinen(overeenkomst.ID).ToArray());
                verwijderenButton.Enabled = true;
                bekijkButton.Enabled = true;
            }
        }

        private void bekijkButton_Click(object sender, EventArgs e)
        {
            Overeenkomst overeenkomst = (Overeenkomst)overeenkomstItemListView.GetSelectedItem();

            if (overeenkomst.Bestandslokatie != null)
            {
                if (File.Exists(overeenkomst.Bestandslokatie))
                {
                    Process.Start(overeenkomst.Bestandslokatie);
                }
                else
                {
                    MessageBox.Show("Het bastand is jammer genoeg niet te vinden.", "Opgapast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Er is geen contract aan toegevoegd.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toevoegenButton_Click(object sender, EventArgs e)
        {
            //nieuwE
        }
    }
}
