using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataFunctie
    {
        public static List<Functie> GeefAlleFuncties()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from f
                     in data.Functies
                     orderby f.FunctieNaam ascending
                     select f).ToList<Functie>());
        }

        public static Functie GeefFunctie(string functienaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from f
                     in data.Functies
                     where f.FunctieNaam == functienaam
                     select f).Single());
        }
    }
}
