using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Betaald
    {
        public Betaald(decimal bedrag, int factuurId)
            :this() 
        {
            Bedrag = bedrag;
            FactuurID = factuurId;
        }
    }
}
