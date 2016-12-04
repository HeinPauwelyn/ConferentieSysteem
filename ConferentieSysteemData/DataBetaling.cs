using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
    public class DataBetaling
    {
        public static List<Tuple<Factuur, decimal, int>> GeefBetalingen()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            var sqlString = (from b in data.Betaalds
                             orderby b.Factuur.FactuurNummer
                             group b by b.FactuurID into bg
                             select new
                             {
                                 FactuurID = bg.Key,
                                 Bedrag = Convert.ToDecimal(bg.Sum(b => b.Bedrag)),
                                 Aantal = bg.Count()
                             });

            List<Tuple<Factuur, decimal, int>> betaald = new List<Tuple<Factuur, decimal, int>>();

            foreach (var item in sqlString)
            {
                betaald.Add(new Tuple<Factuur, decimal, int>(DataFactuur.GeefFactuurVanID(item.FactuurID), item.Bedrag, item.Aantal));
            }

            return betaald;
        }

        public static Tuple<decimal, int> GeefBetalingen(int factuurId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            var sqlString = (from b in data.Betaalds
                             orderby b.Factuur.FactuurNummer
                             where b.FactuurID == factuurId
                             group b by b.FactuurID into bg
                             select new
                             {
                                 Bedrag = Convert.ToDecimal(bg.Sum(b => b.Bedrag)),
                                 Aantal = bg.Count()
                             });

            foreach (var item in sqlString)
            {
                 return new Tuple< decimal, int>(item.Bedrag, item.Aantal);
            }

            throw new InvalidOperationException("Geen items in sqlString");
        }

        public static void BetalingToevoegen(decimal bedrag, int factuurId)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Betaald betaald = new Betaald(bedrag, factuurId);

            data.Betaalds.InsertOnSubmit(betaald);
            data.SubmitChanges();
        }
    }
}
