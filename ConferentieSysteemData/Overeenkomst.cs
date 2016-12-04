using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Overeenkomst
    {
        public Overeenkomst(int expertId, int voorzitterId, DateTime begin, DateTime eind, String Bestandslokatie)
            : this()
        {
            ExpertID = expertId;
            VoorzitterID = voorzitterId;
            BeginDatum = begin;
            EindDatum = eind;
        }
    }
}
