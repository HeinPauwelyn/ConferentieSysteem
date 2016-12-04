using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataInschrijvingConferentieDagLink
    {
        public static void LinkToevoegen(int conferentieDagId, int inschrijvingId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            InschrijvingConferntieDagLink link = new InschrijvingConferntieDagLink(inschrijvingId, conferentieDagId);

            data.InschrijvingConferntieDagLinks.InsertOnSubmit(link);
            data.SubmitChanges();
        }

        public static bool BestaatLink(int conferentieDagId, int inschrijvingId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aa = ((from icdl
                       in data.InschrijvingConferntieDagLinks
                       where icdl.ConferentieDagID == conferentieDagId && icdl.InschrijvingID == inschrijvingId
                       select icdl).Count());

            return aa == 1;
        }

        public static bool BestaatLink(Inschrijving inschrijving, Conferentie conferentie)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int a = (from icdl in data.InschrijvingConferntieDagLinks
                     where icdl.Inschrijving.ID == inschrijving.ID && icdl.ConferentieDag.Conferentie.ID == conferentie.ID
                     select icdl).Count();

            return a >= 1;
        }

        public static List<Tuple<Persoon, Conferentie, int>> GeefInschrijvingen()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            var SqlString = from i in data.InschrijvingConferntieDagLinks
                            group i by new { i.ConferentieDag.Conferentie, i.Inschrijving.Persoon } into g
                            select new
                            {
                                Persoon = g.Key.Persoon,
                                Conferentie = g.Key.Conferentie,
                                Aantal = g.Count()
                            };

            List<Tuple<Persoon, Conferentie, int>> tupleLijst = new List<Tuple<Persoon, Conferentie, int>>();

            foreach (var item in SqlString)
            {
                tupleLijst.Add(new Tuple<Persoon, Conferentie, int>(item.Persoon, item.Conferentie, item.Aantal));
            }

            return tupleLijst;
        }

        public static List<Conferentie> GeefInschrijvingenVanPersoon(int persoonId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            var SqlString = from i in data.InschrijvingConferntieDagLinks
                            where i.Inschrijving.Persoon.ID == persoonId
                            group i by i.ConferentieDag.Conferentie into g
                            select new
                            {
                                Conferentie = g.Key,
                            };

            List<Conferentie> lijst = new List<Conferentie>();

            foreach (var item in SqlString)
            {
                lijst.Add(item.Conferentie);
            }

            return lijst;
        }

        public static List<ConferentieDag> GeefIngeschrevenDagenVanPersoon(int persoonId, int conferentieId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return (from icdl in data.InschrijvingConferntieDagLinks
                    where icdl.Inschrijving.Persoon.ID == persoonId && icdl.ConferentieDag.Conferentie.ID == conferentieId
                    select icdl.ConferentieDag).ToList<ConferentieDag>();
        }
    }
}
