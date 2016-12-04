using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Evaluatie
    {
        public Evaluatie(int expertId, int deelnemerId, float schore, string opmerkingen, int sessieId)
            :this()
        {
            ExpertID = expertId;
            DeelnemerID = deelnemerId;
            Schore = schore;
            SessieID = sessieId;

            if (opmerkingen != string.Empty)
            {
                Opmerkingen = opmerkingen;
            }
            else
            {
                Opmerkingen = null;
            }
        }
    }
}
