using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Persoon
    {
        public Persoon(string voornaam, string achternaam, string staat, string huisnummer, int gemeenteId, string telefoon, string gsm, string email, int functieId, Nullable<int> bedrijfsId, string gebruikersnaam, string wachtwoord)
            : this()
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Straat = staat;
            Huisnummer = huisnummer;
            GemeenteID = gemeenteId;
            TelefoonNummer = telefoon;
            GsmNummer = gsm;
            EmailAdres = email;
            FunctieID = functieId;
            BedrijfID = bedrijfsId;
            Gebruikernaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Voornaam, Achternaam);
        }
    }
}
