using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataInschrijving
    {
        public static int InschrijvingToevoegen(int deelnemerId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Inschrijving ins = new Inschrijving(deelnemerId);

            data.Inschrijvings.InsertOnSubmit(ins);
            data.SubmitChanges();

            return ins.ID;
        }

        public static List<Inschrijving> GeefInschrijving(Persoon persoon)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return (from i in data.Inschrijvings
                    where i.Persoon.ID == persoon.ID
                    select i).ToList<Inschrijving>();
        }
    }
}
