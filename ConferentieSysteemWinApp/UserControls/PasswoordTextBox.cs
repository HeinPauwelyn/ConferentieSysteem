using System;
using System.Security.Cryptography;
using System.Text;

namespace ConferentieSysteemWinApp.UserControls
{
    public partial class PasswoordTextBox : LimietTextBox
    {
        private string _hash;

        #region properties

        public string Hash
        {
            get
            {
                #region Hasher

                SHA512 hasher = SHA512.Create();
                byte[] textAsByteArray = Encoding.UTF32.GetBytes(base.Text);
                byte[] hashedByteArray = hasher.ComputeHash(textAsByteArray);

                _hash = Convert.ToBase64String(hashedByteArray);
                
                #endregion Hasher
                return _hash;
 
            }

            private set 
            { 
                _hash = value; 
            }
        }

        #endregion properies

        public PasswoordTextBox()
        {
            base.UseSystemPasswordChar = true;
        }
    }
}
