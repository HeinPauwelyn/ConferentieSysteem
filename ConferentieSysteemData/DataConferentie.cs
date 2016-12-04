using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataConferentie
    {
        public static void ConferentieToevoegen(string naam, string beschrijving, DateTime inschrijvingslimiet, DateTime startInschrijvingen, int voorzitterId, int aantalDeelnemers)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Conferentie conferentie = new Conferentie(naam, beschrijving, inschrijvingslimiet, startInschrijvingen,  voorzitterId, aantalDeelnemers);

            data.Conferenties.InsertOnSubmit(conferentie);
            data.SubmitChanges();
        }

        public static List<Conferentie> GeefConferenties()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from c
                     in data.Conferenties
                     orderby c.NaamConferentie
                     select c).ToList<Conferentie>());
        }

        public static List<Conferentie> GeefInschrijvingConferenties()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from c
                     in data.Conferenties
                     where c.StartInschrijvingen <= DateTime.Now
                     orderby c.NaamConferentie
                     select c).ToList<Conferentie>());
        }

        public static bool BestaatConferentie(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from c
                           in data.Conferenties
                           where c.NaamConferentie == naam
                           select c).Count());

            return aantal == 1;
        }

        public static Conferentie GeefConferentie(string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return (from c in data.Conferenties
                    where c.NaamConferentie == naam
                    select c).Single<Conferentie>();
        }


        public static void UpdateConferentie(string naam, string bexchrijving, DateTime limiet, DateTime start, int maxDeelnemers)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            Conferentie conf = (from c in data.Conferenties
                                where c.NaamConferentie == naam
                                select c).Single<Conferentie>();

            conf.Inschrijvingslimiet = limiet;
            conf.MaxDeelnemers = maxDeelnemers;
            conf.Beschrijving = bexchrijving;
            conf.NaamConferentie = naam;
            conf.StartInschrijvingen = start;

            data.SubmitChanges();
        }
    }
}
