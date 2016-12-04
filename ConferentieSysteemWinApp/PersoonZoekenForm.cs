using ConferentieSysteemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class PersoonZoekenForm : BasisForm
    {
        public event Action<Persoon> PersoonGevonden;

        private string _functie;

        public PersoonZoekenForm(string functie)
        {
            InitializeComponent();

            _functie = functie;
        }

        private void ZoekenPersoon(object sender, EventArgs e)
        {
            resultatenItemListView.ClearItems();

            List<Persoon> personen = DataPersoon.Zoeken(voornaamLimietTextBox.Text, achternaamLimietTextBox.Text, _functie);

            foreach (Persoon p in personen)
            {
                ListViewItem lvi = new ListViewItem(p.Voornaam);
                lvi.SubItems.AddRange(new string[] {
                    p.Achternaam,
                    p.Straat,
                    p.Huisnummer,
                    p.Gemeente.ToString(),
                    p.Gemeente.Provincie.ProvincieNaam,
                    p.TelefoonNummer,
                    p.GsmNummer,
                    p.EmailAdres,
                    p.Bedrijf == null ? " ":p.Bedrijf.Bedrijfsnaam
                });

                resultatenItemListView.Add(p, lvi);
            }
        }

        private void PersoonZoekenForm_Load(object sender, EventArgs e)
        {
            ZoekenPersoon(null, null);
        }

        private void resultatenItemListView_DoubleClick(object sender, EventArgs e)
        {
            if (resultatenItemListView.CountSelectedItems() == 1 && PersoonGevonden != null)
            {
                Persoon pers = (Persoon)resultatenItemListView.GetSelectedItem();
                PersoonGevonden(pers);
                this.Close();
            }
        }
    }
}
