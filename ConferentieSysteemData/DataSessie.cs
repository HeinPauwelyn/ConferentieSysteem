using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataSessie
    {
        public static void SessieToevoegen(TimeSpan begin, TimeSpan eind, int expertId, int conferentieId, bool isKeynote, int lokaalId, Nullable<int> domeinId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Sessie sessie = new Sessie(begin, eind, expertId, conferentieId, isKeynote, lokaalId, domeinId);

            data.Sessies.InsertOnSubmit(sessie);
            data.SubmitChanges();
        }

        public static bool ControleerKeynote(int dagId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            int aantal = ((from s
                           in data.Sessies
                           where s.ConferentieDagID == dagId && s.IsKeynote == true
                           select s).Count());

            return aantal == 1;
        }

        public static List<Sessie> GeefSessies(int conferentieDagId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from s
                     in data.Sessies
                     where s.ConferentieDagID == conferentieDagId
                     orderby s.ConferentieDag.Datum, s.AanvangUur
                     select s).ToList<Sessie>());
        }

        public static List<Persoon> GeefExperten(int dagId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            var SqlString = from s in data.Sessies
                            where s.ConferentieDagID == dagId
                            group s by s.Persoon into g
                            select new
                            {
                                Persoon = g.Key,
                            };

            List<Persoon> lijst = new List<Persoon>();

            foreach (var item in SqlString)
            {
                lijst.Add(item.Persoon);
            }

            return lijst;
        }

        public static List<Sessie> GeefSessiesVanPersoonOpDag(int dagId, int expertId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return (from s in data.Sessies
                    where s.ExpertID == expertId && s.ConferentieDagID == dagId
                    select s).ToList<Sessie>();
        }
    }
}
