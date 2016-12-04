using ConferentieSysteemData;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class BasisForm : Form
    {
        protected Persoon _persoon;
        public event Action<string> ToonForm; 

        #region constructor

        public BasisForm()
        {
            InitializeComponent();
        }

        public BasisForm(Persoon persoon)
        {
            _persoon = persoon;
        }

        #endregion

        #region Toon account instellingen

        private void instellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToonForm == null)
            {
                //InstelingenForm form = new InstelingenForm(_persoon);
                //form.Show();
            }
            else
            {
                ToonForm("InstelingenForm");
            }
        }

        #endregion
        
        #region Enabelen van knoppen

        protected void EnabelInstellingenKnop()
        {
            instellingenToolStripMenuItem.Enabled = false;
        }

        #endregion

        private void BasisForm_Resize(object sender, EventArgs e)
        {
            optiesSplitButton.Location = new Point(this.Size.Width - 175, 12);
            logoPictureBox.Location = new Point(this.Size.Width - 175, this.Size.Height - 95);
        }
    }
}
