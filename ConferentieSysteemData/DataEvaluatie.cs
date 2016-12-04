using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataEvaluatie
    {
        public static void EvaluatieToevoegen(int expertId, int deelnemerId, float schore, string opmerkingen, int sessieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Evaluatie ev = new Evaluatie(expertId, deelnemerId, schore, opmerkingen, sessieId);

            data.Evaluaties.InsertOnSubmit(ev);
            data.SubmitChanges();
        }

        public static bool BestaatEvaluatie(int expertId, int sessieId, int deelnemerId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int a = ((from e in data.Evaluaties
                      where e.DeelnemerID == deelnemerId && e.ExpertID == expertId && e.SessieID == sessieId
                      select e).Count());

            return a >= 1;
        }
    }
}
