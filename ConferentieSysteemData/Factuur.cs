using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Factuur
    {
        public Factuur(decimal prijs, int inschrijvingId, string nummer, DateTime aanmaak, string bestandslokatie)
            :this()
        {
            TotaalBedrag = prijs;
            InschrijvingID = inschrijvingId;
            FactuurNummer = nummer;
            OpmaakDatum = aanmaak;
            Bestandslokatie = bestandslokatie;
        }

        public override string ToString()
        {
            return FactuurNummer;
        }
    }
}
