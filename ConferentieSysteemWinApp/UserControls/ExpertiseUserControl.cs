using ConferentieSysteemData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class ExpertiseUserControl : UserControl
    {
        private List<ExpertiseDomein> _ToegevoegdeExpertisen = new List<ExpertiseDomein>();
        public event Action ExpertiseToegevoegdVerwijderd;

        public List<ExpertiseDomein> ToegevoegdeExpertisen
        {
            get { return _ToegevoegdeExpertisen; }
            private set { _ToegevoegdeExpertisen = value; }
        }

        public ExpertiseUserControl()
        {
            InitializeComponent();
        }

        private void AanvullenDomeinen(object sender, EventArgs e)
        {
            Expertise expertise = (Expertise)expertiseComboBox.SelectedItem;

            domeinenComboBox.Items.Clear();
            domeinenComboBox.Items.AddRange(DataExpertiseDomein.GeefDomeinenVanExpertiseID(expertise.ID).ToArray());
        }

        private void domeinenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            
            if (domeinenListBox.SelectedItem != null)
            {
                string[] gesplitst = domeinenListBox.SelectedItem.ToString().Split(new char[] { '/' });
                ExpertiseDomein domein = DataExpertiseDomein.GeefDomeinVanNaam(gesplitst[1].Trim());

                tip.IsBalloon = true;
                tip.SetToolTip(domeinenListBox, string.Format("{0}: {1}{2}-----{2}{3}: {4}", domein.Expertise.ExpertiseNaam, domein.Expertise.Beschrijving, Environment.NewLine, domein.ExpertiseDomeinNaam, domein.Beschrijving));

                verwijderenButton.Enabled = true;
            }

            else
            {
                tip = null;
            }
        }

        private void ToevoegenAanLijst(object sender, EventArgs e)
        {
            if (domeinenComboBox.Text != string.Empty)
            {
                ExpertiseDomein domein = (ExpertiseDomein)domeinenComboBox.SelectedItem;
                string tekst =  domein.ToString();

                if (!domeinenListBox.Items.Contains(tekst))
                {
                    domeinenListBox.Items.Add(tekst);
                    ToegevoegdeExpertisen.Add(domein);

                    if (ExpertiseToegevoegdVerwijderd != null)
                    {
                        ExpertiseToegevoegdVerwijderd();
                    }
                }
                else
                {
                    MessageBox.Show("Je kan geen twee keer dezelfde expertise domeinen toevoegen.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void VerwijderenUitLijst(object sender, EventArgs e)
        {
            if (domeinenComboBox.SelectedItem != null)
            {
                ExpertiseDomein domein = (ExpertiseDomein)domeinenComboBox.SelectedItem;

                domeinenListBox.Items.Remove(domeinenListBox.SelectedItem);
                ToegevoegdeExpertisen.Remove(domein);

                verwijderenButton.Enabled = false;

                if (ExpertiseToegevoegdVerwijderd != null)
                {
                    ExpertiseToegevoegdVerwijderd();
                }
            }
        }

        private void domeinenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toevoegenButton.Enabled = true;
        }

        public void AanvullenExpertisen()
        {
            expertiseComboBox.Items.AddRange(DataExpertise.GeefExpertisen().ToArray());
        }
    }
}
