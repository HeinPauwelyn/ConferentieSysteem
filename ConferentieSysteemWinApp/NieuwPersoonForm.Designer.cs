namespace ConferentieSysteemWinApp
{
    partial class NieuwPersoonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NieuwPersoonForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.InschrijvingenButton = new System.Windows.Forms.Button();
            this.persoonBedrijfUserControl1 = new ConferentieSysteemWinApp.UserControls.PersoonBedrijfUserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.persoonBedrijfUserControl1);
            this.panel1.Location = new System.Drawing.Point(187, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 399);
            this.panel1.TabIndex = 11;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.InschrijvingenButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(181, 410);
            this.menuPanel.TabIndex = 12;
            // 
            // InschrijvingenButton
            // 
            this.InschrijvingenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Personen;
            this.InschrijvingenButton.Location = new System.Drawing.Point(12, 12);
            this.InschrijvingenButton.Name = "InschrijvingenButton";
            this.InschrijvingenButton.Size = new System.Drawing.Size(151, 45);
            this.InschrijvingenButton.TabIndex = 0;
            this.InschrijvingenButton.Text = "Beheer personen";
            this.InschrijvingenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InschrijvingenButton.UseVisualStyleBackColor = true;
            // 
            // persoonBedrijfUserControl1
            // 
            this.persoonBedrijfUserControl1.AangeslotenBijBedrijf = false;
            this.persoonBedrijfUserControl1.Achternaam = "";
            this.persoonBedrijfUserControl1.AutoSize = true;
            this.persoonBedrijfUserControl1.BedrijfEmail = "";
            this.persoonBedrijfUserControl1.BedrijfGemeente = null;
            this.persoonBedrijfUserControl1.BedrijfGsmNr = "    /   .";
            this.persoonBedrijfUserControl1.BedrijfHuisnummer = "";
            this.persoonBedrijfUserControl1.Bedrijfsnaam = "";
            this.persoonBedrijfUserControl1.BedrijfStraat = "";
            this.persoonBedrijfUserControl1.BedrijfTelefoonNr = "   /  .  .";
            this.persoonBedrijfUserControl1.BTWNummer = "BE   .    .";
            this.persoonBedrijfUserControl1.Email = "";
            this.persoonBedrijfUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persoonBedrijfUserControl1.Gebruikersnaam = "";
            this.persoonBedrijfUserControl1.Gemeente = null;
            this.persoonBedrijfUserControl1.GsmNr = "    /   .";
            this.persoonBedrijfUserControl1.Huisnummer = "";
            this.persoonBedrijfUserControl1.Location = new System.Drawing.Point(1, 41);
            this.persoonBedrijfUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persoonBedrijfUserControl1.Name = "persoonBedrijfUserControl1";
            this.persoonBedrijfUserControl1.Size = new System.Drawing.Size(593, 454);
            this.persoonBedrijfUserControl1.Straat = "";
            this.persoonBedrijfUserControl1.TabIndex = 0;
            this.persoonBedrijfUserControl1.TelefoonNr = "   /  .  .";
            this.persoonBedrijfUserControl1.Voornaam = "";
            this.persoonBedrijfUserControl1.Wachtwoord = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Functie:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adminestratieve medewerker",
            "Voorzitter"});
            this.comboBox1.Location = new System.Drawing.Point(142, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // NieuwPersoonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(977, 410);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NieuwPersoonForm";
            this.Text = "Menu directie";
            this.Load += new System.EventHandler(this.NieuwPersoonForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button InschrijvingenButton;
        private UserControls.PersoonBedrijfUserControl persoonBedrijfUserControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
