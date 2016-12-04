using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Lokaal
    {
        public Lokaal(string naam)
            :this  ()
        {
            LokaalNummer = naam;
        }

        public override string ToString()
        {
            return LokaalNummer;
        }
    }
}
