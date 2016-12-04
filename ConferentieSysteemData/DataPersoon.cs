using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataPersoon
    {
        public static void PersoonToevoegen(string voornaam, string achternaam, string staat, string huisnummer, Gemeente Gemeente, string telefoon, string gsm, string email, int functieId, Nullable<int> bedrijfsId, string gebruikersnaam, string wachtwoord)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Persoon pers = new Persoon(voornaam, achternaam, staat, huisnummer, Gemeente.ID, telefoon, gsm, email, functieId, bedrijfsId, gebruikersnaam, wachtwoord);

            data.Persoons.InsertOnSubmit(pers);
            data.SubmitChanges();
        }

        public static bool BestaatPersoon(string voornaam, string achternaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from p
                                          in data.Persoons
                                          where p.Voornaam == voornaam && p.Achternaam == achternaam
                                          select p).Count());

            return aantal == 1;
        }

        public static bool BestaatGebruiker(string gebruikersnaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from p
                                          in data.Persoons
                                          where p.Gebruikernaam == gebruikersnaam
                                          select p).Count());

            if (aantal == 1)
            {
                return true;
            }
            return false;
        }

        public static Persoon GeefWachtwoord(string gebruikersnaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where p.Gebruikernaam == gebruikersnaam
                     select p).Single<Persoon>());
        }

        public static void UpdatePersoon(string voornaam, string achternaam, string oudGebruikersnaam, string nieuwGebruikersnaam, string staat, string huisnummer, Gemeente gemeente, string telefoon, string gsm, string email)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            Persoon persoon = ((from p
                                in data.Persoons
                                where p.Gebruikernaam == oudGebruikersnaam
                                select p).Single<Persoon>());

            persoon.Gebruikernaam = nieuwGebruikersnaam;
            persoon.Voornaam = voornaam;
            persoon.Achternaam = achternaam;
            persoon.Straat = staat;
            persoon.Huisnummer = huisnummer;
            persoon.GsmNummer = gsm;
            persoon.TelefoonNummer = telefoon;
            persoon.GemeenteID = gemeente.ID;

            data.SubmitChanges();
        }

        public static Persoon GeefPersoonByID(int id)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where p.ID == id
                     select p).Single<Persoon>());
        }

        public static void UpdatePersoon(string wachtwoord, string gebruikersnaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            Persoon persoon = ((from p
                                in data.Persoons
                                where p.Gebruikernaam == gebruikersnaam
                                select p).Single<Persoon>());

            persoon.Wachtwoord = wachtwoord;

            data.SubmitChanges();
        }

        /// <param name="functieNaam">
        /// Deelnemer, Adminestratieve medewerker, Expert, Conferentie voorzitter of Directie
        /// </param>
        public static List<Persoon> GeefPersonen(string functieNaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where p.Functie.FunctieNaam == functieNaam
                     orderby p.Voornaam ascending
                     select p).ToList<Persoon>());
        }

        public static void VerwijderPersoon(Persoon persoon)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            Persoon pers = ((from p
                             in data.Persoons
                             where p.Voornaam == persoon.Voornaam && p.Achternaam == p.Achternaam
                             select p).Single<Persoon>());

            data.Persoons.DeleteOnSubmit(pers);
            data.SubmitChanges();
        }

        public static Persoon GeefPersoonBijNaam(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where  p.Voornaam + " " + p.Achternaam == naam
                     select p).Single<Persoon>()); 
        }

        public static Persoon GeefPersoonBijNaam(string voornaam, string achternaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where p.Voornaam == voornaam && p.Achternaam == achternaam
                     select p).Single<Persoon>()); 
        }

        public static List<Persoon> Zoeken(string voornaam, string achternaam, string functie)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from p
                     in data.Persoons
                     where p.Achternaam.StartsWith(achternaam) && p.Voornaam.StartsWith(voornaam) && p.Functie.FunctieNaam == functie
                     orderby p.Voornaam, p.Achternaam
                     select p).ToList<Persoon>());
        }
    }
}
