using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferentieSysteemData
{
   public class DataFactuur
    {
       public static string GeefLaatsteFactuurNummer()
       {
           ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

           if ((from f in data.Factuurs
                where f.OpmaakDatum == DateTime.Now
                select f).Count() == 0)
           {
               return string.Format("{0:0000}.{1:00}.{2:00}.001", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
           }

           string factuurNummer = ((from f in data.Factuurs
                                    where f.OpmaakDatum == DateTime.Now
                                    orderby f.FactuurNummer descending
                                    select f.FactuurNummer).First());

           string[] gesplits = factuurNummer.Split(new char[] { '.' });
           int nummer = 0;

           if (Int32.TryParse(gesplits[3], out nummer))
           {
               return string.Format("{0:0000}.{1:00}.{2:00}.{3:000}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ++nummer);
           }
           else
           {
               throw new FormatException("kan nummer niet converteren naar een integer.");
           }
       }

       public static void FactuurToevoegen(decimal prijs, int inschrijvingId, string nummer, DateTime aanmaak, string bestandslokatie)
       {
           ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
           Factuur factuur = new Factuur(prijs, inschrijvingId, nummer, aanmaak, bestandslokatie);

           data.Factuurs.InsertOnSubmit(factuur);
           data.SubmitChanges();
       }

       internal static Factuur GeefFactuurVanID(int factuurId)
       {
           ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

           return (from f in data.Factuurs
                   where f.ID == factuurId
                   select f).Single<Factuur>();
       }

       public static List<Factuur> GeefFacturen()
       {
           ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

           return (from f in data.Factuurs
                   orderby f.FactuurNummer descending
                   select f).ToList<Factuur>();
       }
    }
}
