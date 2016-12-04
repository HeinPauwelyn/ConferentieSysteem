using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace ConferentieSysteemWinApp
{
    public class Email
    {
        public static event Action<bool, string> EmailVerzonden;

        public static void Zenden(MailMessage bericht, string naar, string van, string wachtwoordVan)
        {
            bool internet = NetworkInterface.GetIsNetworkAvailable();

            if (internet)
            {
                ZendBericht(bericht, naar, van, wachtwoordVan);
            }
            else
            {
                if (EmailVerzonden != null)
                {
                    EmailVerzonden(false, "Je bericht is niet verzonden omdat er geen internet is.");
                    
                    //OpslaanBericht(bericht, naar, van, wachtwoordVan);
                }
            }
        }

        //private static void OpslaanBericht(MailMessage bericht, string naar, string van, string wachtwoordVan)
        //{
        //    using (FileStream stream = new FileStream("NietVerzondenBerichten.nvbhpc", FileMode.OpenOrCreate))
        //    {
        //        using (BinaryFormatter fromatter = new BinaryFormatter())
        //        {
        //            fromatter.Serialize(stream, )
        //        }
        //    }
        //}

        private static void ZendBericht(MailMessage bericht, string naar, string van, string wachtwoordVan)
        {
            MailAddress adres = new MailAddress(van);
            string[] email = adres.Host.ToString().Split('.');
            SmtpClient smtp = null;

            #region Smtp van email server

            switch (email[0])
            {
                case "hotmail":
                    goto case "outlook";

                case "outlook":
                    smtp = new SmtpClient("smtp.live.com");
                    break;

                case "gmail":
                    smtp = new SmtpClient("smtp.gmail.com");
                    break;

                case "skynet":
                    smtp = new SmtpClient("smtp.skynet.be");
                    break;

                case "telenet":
                    smtp = new SmtpClient("smtp.telenet.be");
                    break;
            }
            #endregion

            if (smtp != null)
            {
                try
                {
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(van, wachtwoordVan);
                    smtp.Send(bericht);

                    if (EmailVerzonden != null)
                    {
                        EmailVerzonden(true, "Bericht is verzonden");
                    }
                }

                catch (SmtpException)
                {
                    if (EmailVerzonden != null)
                    {
                        EmailVerzonden(false, "Er is een fout opgetreden bij het verzenden van de e-mail. Controleer als je e-mail adres correct is.");
                    }
                }
            }
            else
            {
                if (EmailVerzonden != null)
                {
                    EmailVerzonden(false, "Er is een fout opgetreden bij het verzenden van de e-mail. Controleer als je e-mail adres correct is.");
                }
            }
        }

        public static bool ControleerEmail(string email)
        {
            //info op: http://nl.wikipedia.org/wiki/Reguliere_expressie
            return Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }
    }
}
