using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataOvereenkomst
    {
        public static int OvereenkomstToevoegen(int expertId, int voorzitterId, DateTime begin, DateTime eind, string Bestandslokatie)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Overeenkomst over = new Overeenkomst(expertId, voorzitterId, begin, eind, Bestandslokatie);

            data.Overeenkomsts.InsertOnSubmit(over);
            data.SubmitChanges();

            data = new ConferentieSysteemDataContext();

            return ((from o
                     in data.Overeenkomsts
                     where o.ExpertID == expertId && o.VoorzitterID == voorzitterId && o.BeginDatum == begin && o.EindDatum == eind
                     select o.ID).Single());
        }

        public static List<Overeenkomst> GeeftDomeinen(Persoon expert)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from o
                     in data.Overeenkomsts
                     where o.Persoon == expert && o.EindDatum > DateTime.Now
                     select o).ToList<Overeenkomst>());
        }

        public static List<Overeenkomst> GeefContracten(Persoon persoon)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return (from c in data.Overeenkomsts
                    where c.ExpertID == persoon.ID
                    select c).ToList<Overeenkomst>();
        }
    }
}
