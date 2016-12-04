using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Inschrijving
    {
        public Inschrijving(int deelnemerId)
            :this()
        {
            DeelnemerID = deelnemerId;
            Datum = DateTime.Now.Date;
        }
    }
}
