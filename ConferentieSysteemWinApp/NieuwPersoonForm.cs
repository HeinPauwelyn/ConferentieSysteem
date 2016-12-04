using ConferentieSysteemData;
using System;

namespace ConferentieSysteemWinApp
{
    public partial class NieuwPersoonForm : BasisForm
    {
        #region Constructor en load

        public NieuwPersoonForm(Persoon persoon)
        {
            InitializeComponent();
            _persoon = persoon;
        }

        private void NieuwPersoonForm_Load(object sender, EventArgs e)
        {
            //persoonPersoonAccountUserControl.AanvullenBedrijven();
            //persoonPersoonAccountUserControl.AanvullenFuncties(true);
            //persoonPersoonAccountUserControl.InvullenWachtwoord(Wachtwoord.MaakWachtwoord());
        }
        #endregion
    }
}
