using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class InschrijvingConferntieDagLink
    {
        public InschrijvingConferntieDagLink(int inschrijvingId, int conferentieDagId)
            :this()
        {
            InschrijvingID = inschrijvingId;
            ConferentieDagID = conferentieDagId;
        }
    }
}
