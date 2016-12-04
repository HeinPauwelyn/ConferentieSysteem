using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class KeynoteUserControl : SessieUserControl
    {
        private Label _keynoteLabel = new Label();

        public KeynoteUserControl()
        {
            InitializeComponent();
            VerwijderExpertComboBoxEnVersleepButton();
            PlaatLabel();
        }

        private void PlaatLabel()
        {
            _keynoteLabel.Location = new Point(6, 3);
            _keynoteLabel.AutoSize = false;
            _keynoteLabel.Size = new Size(149, 24);
            _keynoteLabel.Text = "Keynote";
            _keynoteLabel.TextAlign = ContentAlignment.MiddleCenter;
            _keynoteLabel.BringToFront();
            Controls.Add(_keynoteLabel);
        }
    }
}
