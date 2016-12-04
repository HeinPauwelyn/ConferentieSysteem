using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataConferentieDag
    {
        public static void ToevoegenConferentieDag(DateTime datum, decimal geld, int conferentieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            ConferentieDag dag = new ConferentieDag(datum, geld, conferentieId);

            data.ConferentieDags.InsertOnSubmit(dag);
            data.SubmitChanges();
        }

        public static bool BestaatConferentieDag(DateTime datum, int conferentieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from cd
                           in data.ConferentieDags
                           where cd.ConferentieID == conferentieId && cd.Datum == datum
                           select cd).Count());

            return aantal == 1;
        }

        public static ConferentieDag GeefConferentieDag(DateTime datum, int conferentieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from cd
                     in data.ConferentieDags
                     where cd.ConferentieID == conferentieId && cd.Datum == datum
                     select cd).Single());

        }

        public static List<ConferentieDag> GeefConferentieDagen(int conferentieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from cd
                     in data.ConferentieDags
                     where cd.ConferentieID == conferentieId
                     orderby cd.Datum
                     select cd).ToList<ConferentieDag>());
        }
    }
}
