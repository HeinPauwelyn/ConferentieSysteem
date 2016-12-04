using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataExpertiseDomein
    {
        public static bool BestaatDomein(int expertiseId, string expertiseDomeinNaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from ed
                                          in data.ExpertiseDomeins
                                          where ed.ExpertiseID == expertiseId && ed.ExpertiseDomeinNaam == expertiseDomeinNaam
                                          select ed).Count());

            return aantal == 1;
        }

        public static void DomeinToevoegen(int expertieId, string domeinNaam, string beschrijving)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            ExpertiseDomein domein = new ExpertiseDomein(expertieId, domeinNaam, beschrijving);

            data.ExpertiseDomeins.InsertOnSubmit(domein);
            data.SubmitChanges();
        }

        public static List<ExpertiseDomein> GeefDomeinenVanExpertiseID(int expertiseId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from ed
                     in data.ExpertiseDomeins
                     where ed.ExpertiseID == expertiseId
                     select ed).ToList<ExpertiseDomein>());
        }

        public static ExpertiseDomein GeefDomeinVanNaam(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from ed
                     in data.ExpertiseDomeins
                     where ed.ExpertiseDomeinNaam == naam
                     select ed).Single());
        }

        public static List<ExpertiseDomein> GeefDomeinen()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from ed
                     in data.ExpertiseDomeins
                     orderby ed.Expertise.ExpertiseNaam, ed.ExpertiseDomeinNaam
                     select ed).ToList<ExpertiseDomein>());
        }
    }
}
