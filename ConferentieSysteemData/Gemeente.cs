namespace ConferentieSysteemData
{
    partial class Gemeente
    {
        public override string ToString()
        {
            return string.Format("{0} {1}", Postcode, GemeenteNaam);
        }
    }
}
