using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataOvereenkomstDomeinLink
    {
        public static void LinkToevoegen(int overeenkomstId, int expertiseDomeinId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            OvereenkomstExpertiseDomeinLink oedl = new OvereenkomstExpertiseDomeinLink();

            oedl.ExpertiseDomeinID = expertiseDomeinId;
            oedl.OvereenkomstID = overeenkomstId;
            
            data.OvereenkomstExpertiseDomeinLinks.InsertOnSubmit(oedl);
            data.SubmitChanges();
        }

        public static List<ExpertiseDomein> GeefDomeinen(int overeenkomstId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from odl
                     in data.OvereenkomstExpertiseDomeinLinks
                     where odl.OvereenkomstID == overeenkomstId
                     select odl.ExpertiseDomein).ToList<ExpertiseDomein>());
        }
    }
}
