using ConferentieSysteemData;
using ConferentieSysteemWinApp.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace ConferentieSysteemWinApp
{
    public partial class AanmeldenForm : Form
    {
        private Random _rnd = new Random();
        private string _wachtwoord = "";
        private int _code;
        private NieuwWachtwoordForm form;

        #region constructor en load

        public AanmeldenForm()
        {
            InitializeComponent();
        }
        private void AanmeldenForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(540, 210);

            #region tooltip
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.SetToolTip(nieuwWachtwoordButton, "Nieuw wachtwoord verzenden.");
            tip.SetToolTip(aanmeldenButton, "Aanmelden");
            tip.SetToolTip(verzendButton, "Verzend nieuw wachtwoord.");
            tip.SetToolTip(verbergButton, "Verberg \"zend e-mail\"");
            tip.SetToolTip(info1PictureBox, "Goed voorbeeld: \"goed@voorbeeld.com\"");
            tip.SetToolTip(info2PictureBox, "Geef hier je wachtwoord van je e-mail account. \nJe wachtwoord gaat niet gebruikt of opgeslagen worden.");
            #endregion
        }
        #endregion

        #region Aanmelden
        
        private void AanmeldenKnop(object sender, EventArgs e)
        {
            aanmeldenButton.Enabled = false;
            aanmeldenProsesBar.Visible = true;
            Aanmelden();
        }

        private void AameldenEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aanmeldenButton.Enabled = false;
                aanmeldenProsesBar.Visible = true;
                Aanmelden();
            }
        }

        private void InvokeAanmeldKnop()
        {
            if (aanmeldenButton.InvokeRequired)
            {
                aanmeldenButton.Invoke(new Action(InvokeAanmeldKnop));
            }
            else
            {
                
            }
        }

        private void InvokeAanmeldProcesBar()
        {
            if (aanmeldenProsesBar.InvokeRequired)
            {
                aanmeldenProsesBar.Invoke(new Action(InvokeAanmeldProcesBar));
            }
            else
            {
                aanmeldenProsesBar.Visible = false;
            }
        }

        private void InvokeForm(bool visible)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<bool>(InvokeForm), visible);
            }
            else
            {
                this.Visible = visible;
            }
        }

        private void Aanmelden()
        {
            try
            {
                if (DataPersoon.BestaatGebruiker(gebruikersnaamLimietTextBox.Text))
                {
                    Persoon persoon = DataPersoon.GeefWachtwoord(gebruikersnaamLimietTextBox.Text);

                    //StopThread();

                    if (wachtwoordpasswoordTextBox.Hash == persoon.Wachtwoord)
                    {
                        BasisForm formBasis = new BasisForm(persoon);

                        aanmeldenButton.Enabled = true;
                        aanmeldenProsesBar.Visible = false;
                        Visible = false;

                        switch (persoon.Functie.FunctieNaam)
                        {
                            case "Conferentie voorzitter":
                                MenuVoorzittersForm cf = new MenuVoorzittersForm(persoon);
                                cf.ShowDialog();
                                break;

                            case "Deelnemer":
                                EvaluatieForm ev = new EvaluatieForm(persoon);
                                ev.ShowDialog();
                                break;

                            case "Adminestratieve medewerker":
                                MenuAdminestratieveMedewerkerForm f = new MenuAdminestratieveMedewerkerForm();
                                f.ShowDialog();
                                break;

                            case "Expert":
                                break;

                            case "Directie":
                                NieuwPersoonForm nf = new NieuwPersoonForm(persoon);
                                nf.ShowDialog();
                                break;
                        }

                        InvokeForm(true);
                    }
                    else
                    {
                        MessageBox.Show("Het wachtwoord die u hebt ingegevens is verkeerd.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("De gebruikersnaam bestaat niet.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("De connectie met de database is verbroken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Aanmelden

        #region Wachtwoord vergeten

        private void nieuwWachtwoordButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(540, 430);
            nieuwWachtwoordButton.Enabled = false;
        }

        private void verbergButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(540, 210);
            nieuwWachtwoordButton.Enabled = true;
        }

        private void verzendButton_Click(object sender, EventArgs e)
        {
            EnabelKnoppen();

            MessageBox.Show("Je krijgt straks een bericht op je email adres met een code. Deze code gebruik je straks voor een nieuw wachtwoord te kunnen invoeren.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Thread tr = new Thread(VerzendWachtwoord);
            tr.IsBackground = false;
            tr.Start();
        }

        private void VerzendWachtwoord()
        {
            MailMessage bericht = new MailMessage();
            bericht.To.Add(emailLimietTextBox.Text);
            bericht.From = new MailAddress("noresponse@hp.com");
            bericht.Subject = "Nieuw wachtwoord HP";
            _wachtwoord = Wachtwoord.MaakWachtwoord();

            _code = _rnd.Next(1000, 10000);
            bericht.Body = string.Format("De code is: {0}", _code);

            Email.EmailVerzonden += ZendEmail_EmailVerzonden;
            Email.Zenden(bericht, emailLimietTextBox.Text, emailLimietTextBox.Text, passwoordEmailTextBox.Text);
            Email.EmailVerzonden -= ZendEmail_EmailVerzonden;
        }

        private void ZendEmail_EmailVerzonden(bool verzonden, string info)
        {
            if (verzonden)
            {
                MessageBox.Show(info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InvokeControlPanel(true);
            }
            else
            {
                MessageBox.Show(info, "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Email.EmailVerzonden -= ZendEmail_EmailVerzonden;
            InvokeControls();
        }

        #region invoke
        private void InvokeControls()
        {
            if (progressPictureBox.InvokeRequired || verzendButton.InvokeRequired || emailLimietTextBox.InvokeRequired || nieuwWachtwoordButton.InvokeRequired || passwoordEmailTextBox.InvokeRequired)
            {
                if (progressPictureBox.InvokeRequired)
                {
                    progressPictureBox.Invoke(new Action(InvokeControls));
                }
                else if (verzendButton.InvokeRequired)
                {
                    verzendButton.Invoke(new Action(InvokeControls));
                }
                else if (emailLimietTextBox.InvokeRequired)
                {
                    emailLimietTextBox.Invoke(new Action(InvokeControls));
                }
                else if (nieuwWachtwoordButton.InvokeRequired)
                {
                    nieuwWachtwoordButton.Invoke(new Action(InvokeControls));
                }

                else if (passwoordEmailTextBox.InvokeRequired)
                {
                    passwoordEmailTextBox.Invoke(new Action(InvokeControls));
                }
            }
            else
            {
                progressPictureBox.Visible = false;
                nieuwWachtwoordButton.Enabled = true;
                emailLimietTextBox.Enabled = true;
                emailLimietTextBox.Text = string.Empty;
                verzendButton.Enabled = true;
                passwoordEmailTextBox.Enabled = true;
                passwoordEmailTextBox.Text = string.Empty;
            }
        }

        private void InvokeControlPanel(bool stap2)
        {
            if (controlPanel.InvokeRequired || groupBox1.InvokeRequired)
            {
                if (controlPanel.InvokeRequired)
                {
                    controlPanel.Invoke(new Action<bool>(InvokeControlPanel), stap2);
                }
                else if (groupBox1.InvokeRequired)
                {
                    groupBox1.Invoke(new Action<bool>(InvokeControlPanel), stap2);
                }
            }
            else
            {     

                if (stap2 == true)
                {
                    form = new NieuwWachtwoordForm(_code);
                    form.Sluit += form_Sluit;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.TopLevel = false;
                    form.AutoScroll = true;
                    controlPanel.Controls.Add(form);
                    groupBox1.Visible = false;
                    form.BringToFront();
                    form.Show();
                }

                else
                {
                    controlPanel.Controls.Remove(form);
                    groupBox1.Visible = true;
                }
            }
        }

        private void form_Sluit()
        {
            
        }
        #endregion inoke

        #endregion Wachtwoord vergeten

        #region enabelen van knoppen

        private void EnabelKnoppen()
        {
            verzendButton.Enabled = false;
            progressPictureBox.Visible = true;
            emailLimietTextBox.Enabled = false;
            passwoordEmailTextBox.Enabled = false;
        }

        private void enabelVerzendKnop(object sender, EventArgs e)
        {
            verzendButton.Enabled = Email.ControleerEmail(emailLimietTextBox.Text) && passwoordEmailTextBox.Text.Trim() != string.Empty;
        }

        private void enableAanmeldButton(object sender, EventArgs e)
        {
            aanmeldenButton.Enabled = gebruikersnaamLimietTextBox.Text != string.Empty && wachtwoordpasswoordTextBox.Text.Trim() != string.Empty;
        }

        #endregion

        #region controleer email
        
        private void emailLimietTextBox_Leave(object sender, EventArgs e)
        {
            if (Email.ControleerEmail(emailLimietTextBox.Text))
            {
                emailLimietTextBox.BackColor = Color.White;
            }

            else
            {
                emailLimietTextBox.BackColor = Color.LightCoral;
            }
        }
        #endregion
    }
}
