using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferentieSysteemWinApp.Properties;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class ControleUserControl : UserControl
    {
        public new event EventHandler Click;
        public event EventHandler CheckVeranderd;

        private bool _check = false;
        private string _bericht;

        public string Bericht
        {
            get
            {
                return _bericht;
            }
            set 
            {
                label1.Text = value;
                _bericht = value; 

                if (_check == true)
                {
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                }
            }
        }


        public bool Check
        {
            get 
            {
                return _check; 
            }
            set 
            {
                if (value == true)
                {
                    checkPictureBox.Image = Resources.Vink;
                }
                else
                {
                    checkPictureBox.Image = Resources.Kruis;
                }

                _check = value;

                if (CheckVeranderd != null)
                {
                    CheckVeranderd(this, new EventArgs());
                }
            }
        }

        public ControleUserControl()
        {
            InitializeComponent();
            label1.Click += DoClick;
            checkPictureBox.Click += DoClick;
        }

        public void DoClick(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }

        private void ControleUserControl_MouseHover(object sender, EventArgs e)
        {
            if (Check == false)
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void ControleUserControl_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
