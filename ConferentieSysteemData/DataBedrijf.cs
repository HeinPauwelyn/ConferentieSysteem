using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferentieSysteemData
{
    public class DataBedrijf
    {
        public static void BedrijfToevoegen(string naam, string straat, string nummer, Gemeente gemeente, string telefoon, string gsm, string email, string btw)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Bedrijf bed = new Bedrijf(naam, straat, nummer, gemeente.ID, telefoon, gsm, email, btw);

            data.Bedrijfs.InsertOnSubmit(bed);
            data.SubmitChanges();
        }

        public static bool BestaatBedrijf (string naam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            byte aantal = Convert.ToByte((from b
                                          in data.Bedrijfs
                                          where b.Bedrijfsnaam == naam
                                          select b).Count());

            return aantal == 1;
        }


        public static List<Bedrijf> GeefBedrijven()
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from d
                     in data.Bedrijfs
                     select d).ToList<Bedrijf>());
        }

        public static int BedrijfToevoegenEnGeefId(string naam, string straat, string nummer, Gemeente gemeente, string telefoon, string gsm, string email, string btw)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();
            Bedrijf bed = new Bedrijf(naam, straat, nummer, gemeente.ID, telefoon, gsm, email, btw);

            data.Bedrijfs.InsertOnSubmit(bed);
            data.SubmitChanges();

            return bed.ID;
        }

        public static int GeefBedrijf(string bedrijfsnaam)
        {
            ConferentieSysteemDataContext data = new ConferentieSysteemDataContext();

            return ((from d
                     in data.Bedrijfs
                     select d.ID).Single<int>());
        }
    }
}
