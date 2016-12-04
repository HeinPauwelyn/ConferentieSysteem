namespace ConferentieSysteemData
{
    partial class ExpertiseDomein
    {
        public ExpertiseDomein(int expertieId, string domeinNaam, string beschrijving)
            : this()
        {
            ExpertiseID = expertieId;
            ExpertiseDomeinNaam = domeinNaam;
            Beschrijving = beschrijving;
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", Expertise.ExpertiseNaam, ExpertiseDomeinNaam);
        }
    }
}
