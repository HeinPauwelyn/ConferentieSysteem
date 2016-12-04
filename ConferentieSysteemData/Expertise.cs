namespace ConferentieSysteemData
{
    partial class Expertise
    {
        public Expertise(string naam, string beschrijving)
            :this()
        {
            ExpertiseNaam = naam;
            Beschrijving = beschrijving;
        }

        public override string ToString()
        {
            return ExpertiseNaam;
        }
    }
}
