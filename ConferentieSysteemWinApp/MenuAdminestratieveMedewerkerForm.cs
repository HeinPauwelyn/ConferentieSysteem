using ConferentieSysteemWinApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class MenuAdminestratieveMedewerkerForm : BasisForm
    {
        public MenuAdminestratieveMedewerkerForm()
        {
            InitializeComponent();
        }

        private void ToonOverzichtInschrijvingen(object sender, EventArgs e)
        {
            OverzichtInschrijvingenUserControl uc = new OverzichtInschrijvingenUserControl();
            uc.NieuweInschrijving += ToonNieuweInschijving;
            uc.Location = new Point(5, 5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void ToonNieuweInschijving()
        {
            NieuweInschrijngUC uc = new NieuweInschrijngUC();
            uc.AanvullenConferenties();
            uc.Location = new Point(5, 5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void ToonFactuur(object sender, EventArgs e)
        {
            FactuurUserControl uc = new FactuurUserControl();
            uc.PlaatsFactuurnummer();
            uc.Location = new Point(5, 5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void betalingenButton_Click(object sender, EventArgs e)
        {
            ToonOverzichtBetalingen();
        }

        private void NieuweStorting()
        {
            NieuweStortingUserControl uc = new NieuweStortingUserControl();
            uc.AanvullenFactuurNummers();
            uc.Terug += ToonOverzichtBetalingen;
            uc.Location = new Point(5, 5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        void ToonOverzichtBetalingen()
        {
            BetalingenUserControl uc = new BetalingenUserControl();
            uc.AanvullenFacturen();
            uc.NieuweStorting += NieuweStorting;
            uc.Location = new Point(5, 5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
