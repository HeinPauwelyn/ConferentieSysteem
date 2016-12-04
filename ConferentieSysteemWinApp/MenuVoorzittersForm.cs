using ConferentieSysteemData;
using ConferentieSysteemWinApp.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class MenuVoorzittersForm : BasisForm
    {
        #region Constructor en load
        
        public MenuVoorzittersForm(Persoon persoon)
        {
            InitializeComponent();
            _persoon = persoon;
        }

        #endregion

        private void ToonOverzichtConferenties(object sender, EventArgs e)
        {
            if (controlPanel.Controls.Count <= 1)
            {
                OverzichtConferentiesUserControl confUC = new OverzichtConferentiesUserControl();
                confUC.ConferentieAanmaken += ToonConferentieAanmakenForm;
                confUC.ZetVoorzitter(_persoon);
                confUC.AanvullenLijst();
                confUC.Location = new Point(5, 5);
                confUC.Visible = true;
            
                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(confUC);
            }
        }

        void ToonConferentieAanmakenForm(Conferentie conf)
        {
            controlPanel.Controls.Clear();
            BewerkenConferentieForm form = null;

            if (conf == null)
            {
                form = new BewerkenConferentieForm(_persoon);
            }
            else
            {
                form = new BewerkenConferentieForm(_persoon, conf);
            }

            form.ConferentieToegevogd += form_ConferentieToegevogd;
            form.Terug += form_Terug;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            controlPanel.Controls.Add(form);
            form.Show();
        }

        private void form_ConferentieToegevogd()
        {
            
        }

        private void form_Terug()
        {
            controlPanel.Controls.Clear();
            OverzichtConferentiesUserControl confUC = new OverzichtConferentiesUserControl();
            confUC.ConferentieAanmaken += ToonConferentieAanmakenForm;
            confUC.ZetVoorzitter(_persoon);
            confUC.AanvullenLijst();
            confUC.Location = new Point(5, 5);
            confUC.Visible = true;
            controlPanel.Controls.Add(confUC);
        }

        private void ToonOverzichtExperten(object sender, EventArgs e)
        {
            if (controlPanel.Controls.Count <= 1)
            {
                OverzichtExpertenUserControl confUC = new OverzichtExpertenUserControl();
                confUC.AanvullenExperten();
                confUC.Location = new Point(5, 5);
                confUC.Visible = true;

                controlPanel.Controls.Clear();
                controlPanel.Controls.Add(confUC);
            }
        }

        private void ToonExpertiseToevoegen(object sender, EventArgs e)
        {
            ExpertiseToevoegenForm form = new ExpertiseToevoegenForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(form);
            form.Show();
        }

        private void Wissen(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
        }
    }
}
