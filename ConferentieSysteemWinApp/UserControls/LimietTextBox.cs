using System.Windows.Forms;

namespace ConferentieSysteemWinApp.UserControls
{
    public class LimietTextBox : TextBox
    {
        private string _text;

        public new string Text
        {
            get 
            {
                _text = base.Text.Trim();
                return _text; 
            }
            set 
            {
                _text = value.Trim();
                base.Text = _text;
            }
        }

        public LimietTextBox()
        {
            base.MaxLength = 50;
        }
    }
}
