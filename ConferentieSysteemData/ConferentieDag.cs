using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class ConferentieDag
    {
        public ConferentieDag(DateTime datum, decimal geld, int conferentieId)
            :this()
        {
            Datum = datum;
            InschrijvingsGeld = geld;
            ConferentieID = conferentieId;
        }

        public override string ToString()
        {
            return Datum.ToShortDateString();
        }
    }
}
