using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    partial class Conferentie
    {
        public Conferentie(string naam, string beschrijving, DateTime inschrijvingslimiet, DateTime startInschrijvingen, int voorzitterId, int aantalDeelnemers)
            :this()
        {
            NaamConferentie = naam;
            Beschrijving = beschrijving;
            Inschrijvingslimiet = inschrijvingslimiet;
            VoorzitterID = voorzitterId;
            MaxDeelnemers = aantalDeelnemers;
            StartInschrijvingen = startInschrijvingen;
        }

        public override string ToString()
        {
            return NaamConferentie;
        }
    }
}
