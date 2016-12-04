using System;
using System.Text;

namespace ConferentieSysteemWinApp
{
    public class Wachtwoord
    {
        private static Random _rnd = new Random();

        public static string MaakWachtwoord()
        {
            StringBuilder tekst = new StringBuilder();
            char[] karakters = new char[] { 'a', 'z', 'e', 'r', 't', 'u', 'y', 'i', 'o', 'p', 'q', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'w', 'x', 'c', 'v', 'b', 'n', '9', '6', '3', '2', '1', '4', '7', '8', '5', '0' };

            tekst.Append(karakters[_rnd.Next(karakters.Length - 1)].ToString().ToUpper());

            for (int teller = 0; teller < 4; teller++)
            {
                tekst.Append(karakters[_rnd.Next(karakters.Length - 1)].ToString());
            }

            return tekst.ToString();
        }
    }
}
