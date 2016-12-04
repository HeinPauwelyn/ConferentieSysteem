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
    public partial class SessieUserControl : UserControl
    {
        public SessieUserControl()
        {
            InitializeComponent();
        }

        public void AanvullenExpertenEnExpertisen()
        {
            AanvulenExperten();
            expertiseComboBox.Items.AddRange(DataExpertiseDomein.GeefDomeinen().ToArray());
        }

        public void AanvulenExperten()
        {
            expertComboBox.Items.AddRange(DataPersoon.GeefPersonen("Expert").ToArray());
        }

        protected void VerwijderExpertComboBoxEnVersleepButton()
        {
            this.Controls.Remove(expertiseComboBox);
            this.Controls.Remove(verplaatsButton);
        }
    }
}
