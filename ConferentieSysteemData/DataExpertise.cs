using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataExpertise
    {
        public static void ExpertiseToevoegen(string naam, string beschrijving)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Expertise expertise = new Expertise(naam, beschrijving);

            data.Expertises.InsertOnSubmit(expertise);
            data.SubmitChanges();

            
        }

        public static bool BestaatExpetise(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from e
                                          in data.Expertises
                                          where e.ExpertiseNaam == naam
                                          select e).Count());

            return aantal == 1;
        }

        public static List<Expertise> GeefExpertisen()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from e
                     in data.Expertises
                     select e).ToList<Expertise>());
        }
    }
}
