using ConferentieSysteemData;
using System;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class NieuwWachtwoordForm : Form
    {
        private int _code;
        public event Action Sluit;

        public NieuwWachtwoordForm(int code)
        {
            InitializeComponent();
            _code = code;
        }

        private void WijzigWachtwoord(object sender, EventArgs e)
        {
            if (codeNumericUpDown.Value == _code && wachtwoordPasswoordTextBox.Text.Trim() == HerhaalPasswoordTextBox.Text && gebruikersnaamLimietTextBox.Text != string.Empty)
            {
                if (DataPersoon.BestaatGebruiker(gebruikersnaamLimietTextBox.Text))
                {
                    DataPersoon.UpdatePersoon(wachtwoordPasswoordTextBox.Hash, gebruikersnaamLimietTextBox.Text);

                    MessageBox.Show("Uw wachtwoord is aangepast.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Sluit();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam bestaat niet.", "Opgepast", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vul alle gegevens correct in.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
