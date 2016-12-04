using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Sessie
    {
        public Sessie(TimeSpan begin, TimeSpan eind, int expertId, int conferentieId, bool isKeynote, int lokaalId, Nullable<int> domeinId)
            :this()
        {
            AanvangUur = begin;
            EindUur = eind;
            ExpertID = expertId;
            ConferentieDagID = conferentieId;
            IsKeynote = isKeynote;
            LokaalID = lokaalId;
            DomeinID = domeinId;
        }

        public override string ToString()
        {
            if (ExpertiseDomein == null)
            {
                return "Keynote";
            }

            return ExpertiseDomein.ExpertiseDomeinNaam;
        }
    }
}
