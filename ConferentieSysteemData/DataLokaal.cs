using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataLokaal
    {
        public static bool BestaatLokaal(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from l
                                          in data.Lokaals
                                          where l.LokaalNummer == naam
                                          select l).Count());

            return aantal == 1;
        }

        public static void LokaalToevoegen(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Lokaal lokaal = new Lokaal(naam);

            data.Lokaals.InsertOnSubmit(lokaal);
            data.SubmitChanges();
        }

        public static List<Lokaal> GeefLokaken()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from l
                     in data.Lokaals
                     orderby l.LokaalNummer
                     select l).ToList<Lokaal>());
        }
    }
}
