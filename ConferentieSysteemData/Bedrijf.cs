using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Bedrijf
    {
        public Bedrijf(string naam, string straat, string nummer, int gemeenteId, string telefoon, string gsm, string email, string btw)
            :this()
        {
            Bedrijfsnaam = naam;
            Straat = straat;
            Huisnummer = nummer;
            GemeenteID = gemeenteId;
            TelefoonNummer = telefoon;
            GsmNummer = gsm;
            BtwNummer = btw;
            EmailAdres = email;
        }

        public override string ToString()
        {
            return Bedrijfsnaam;
        }
    }
}
