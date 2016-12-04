using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class ConferentieDagUserControl : UserControl
    {
        private int _yLocatie  = 5;

        public ConferentieDagUserControl()
        {
            InitializeComponent();

            KeynoteUserControl keynoteUC = new KeynoteUserControl();
            keynoteUC.Location = new Point(5, _yLocatie);
            keynoteUC.AanvulenExperten();
            sessiesPanel.Controls.Add(keynoteUC);
            _yLocatie += 120;
        }

        private void ToevoegenButtonClick(object sender, EventArgs e)
        {
            SessieUserControl sessieUC = new SessieUserControl();
            sessieUC.Location = new Point(5, _yLocatie);
            sessiesPanel.Controls.Add(sessieUC);
            _yLocatie += 120;
        }

        private void VerwijderenButtonClick(object sender, EventArgs e)
        {
            
        }
    }
}
