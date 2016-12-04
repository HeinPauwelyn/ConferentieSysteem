using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataGemeente
    {
        public static List<Gemeente> GeefGemeenten(string tekst)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from g
                     in data.Gemeentes
                     where g.GemeenteNaam.ToLower().StartsWith(tekst.ToLower())
                     select g).ToList<Gemeente>());
        }

        public static List<Gemeente> GeefGemeenten(int postcode)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from g
                     in data.Gemeentes
                     where g.Postcode.ToString().StartsWith(postcode.ToString())
                     select g).ToList<Gemeente>());
        }

        public static bool BestaatGemeente(string gemeenteNaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from g
                           in data.Gemeentes
                           where g.GemeenteNaam == gemeenteNaam
                           select g).Count());

            return aantal == 1;
        }

        public static bool BestaatGemeente(int postcode)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from g
                           in data.Gemeentes
                           where g.Postcode == postcode
                           select g).Count());

            return aantal == 1;
        }

        public static bool KloptGemeente(string gemeenteNaam, int postcode)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from g
                           in data.Gemeentes
                           where g.GemeenteNaam == gemeenteNaam && g.Postcode == postcode
                           select g).Count());

            return aantal >= 1;
        }
    }
}
