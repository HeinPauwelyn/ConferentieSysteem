namespace ConferentieSysteemWinApp.UserControls
{
    partial class NieuweInschrijngUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deelnemerPersoonBedrijfUserControl = new ConferentieSysteemWinApp.UserControls.PersoonBedrijfUserControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.conferentieDagPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.sessieListBox = new System.Windows.Forms.ListBox();
            this.prijsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volledigeConferentieCheckBox = new System.Windows.Forms.CheckBox();
            this.conferentieDagenCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.conferentieListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.factuurUserControl2 = new ConferentieSysteemWinApp.UserControls.FactuurUserControl();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.conferentieDagPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 376);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.deelnemerPersoonBedrijfUserControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(612, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deelnemer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deelnemerPersoonBedrijfUserControl
            // 
            this.deelnemerPersoonBedrijfUserControl.AangeslotenBijBedrijf = false;
            this.deelnemerPersoonBedrijfUserControl.Achternaam = "";
            this.deelnemerPersoonBedrijfUserControl.AutoSize = true;
            this.deelnemerPersoonBedrijfUserControl.BedrijfEmail = "";
            this.deelnemerPersoonBedrijfUserControl.BedrijfGemeente = null;
            this.deelnemerPersoonBedrijfUserControl.BedrijfGsmNr = "    /   .";
            this.deelnemerPersoonBedrijfUserControl.BedrijfHuisnummer = "";
            this.deelnemerPersoonBedrijfUserControl.Bedrijfsnaam = "";
            this.deelnemerPersoonBedrijfUserControl.BedrijfStraat = "";
            this.deelnemerPersoonBedrijfUserControl.BedrijfTelefoonNr = "   /  .  .";
            this.deelnemerPersoonBedrijfUserControl.BTWNummer = "BE   .    .";
            this.deelnemerPersoonBedrijfUserControl.Email = "";
            this.deelnemerPersoonBedrijfUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deelnemerPersoonBedrijfUserControl.Gebruikersnaam = "";
            this.deelnemerPersoonBedrijfUserControl.Gemeente = null;
            this.deelnemerPersoonBedrijfUserControl.GsmNr = "    /   .";
            this.deelnemerPersoonBedrijfUserControl.Huisnummer = "";
            this.deelnemerPersoonBedrijfUserControl.Location = new System.Drawing.Point(-4, 6);
            this.deelnemerPersoonBedrijfUserControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deelnemerPersoonBedrijfUserControl.Name = "deelnemerPersoonBedrijfUserControl";
            this.deelnemerPersoonBedrijfUserControl.Size = new System.Drawing.Size(593, 559);
            this.deelnemerPersoonBedrijfUserControl.Straat = "";
            this.deelnemerPersoonBedrijfUserControl.TabIndex = 0;
            this.deelnemerPersoonBedrijfUserControl.TelefoonNr = "   /  .  .";
            this.deelnemerPersoonBedrijfUserControl.Voornaam = "";
            this.deelnemerPersoonBedrijfUserControl.Wachtwoord = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.conferentieDagPanel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.conferentieListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(612, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conferentie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // conferentieDagPanel
            // 
            this.conferentieDagPanel.Controls.Add(this.label6);
            this.conferentieDagPanel.Controls.Add(this.sessieListBox);
            this.conferentieDagPanel.Controls.Add(this.prijsLabel);
            this.conferentieDagPanel.Controls.Add(this.panel1);
            this.conferentieDagPanel.Controls.Add(this.label5);
            this.conferentieDagPanel.Controls.Add(this.label4);
            this.conferentieDagPanel.Location = new System.Drawing.Point(192, 8);
            this.conferentieDagPanel.Margin = new System.Windows.Forms.Padding(4);
            this.conferentieDagPanel.Name = "conferentieDagPanel";
            this.conferentieDagPanel.Size = new System.Drawing.Size(376, 335);
            this.conferentieDagPanel.TabIndex = 8;
            this.conferentieDagPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Totaal prijs:";
            // 
            // sessieListBox
            // 
            this.sessieListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessieListBox.FormattingEnabled = true;
            this.sessieListBox.IntegralHeight = false;
            this.sessieListBox.ItemHeight = 16;
            this.sessieListBox.Location = new System.Drawing.Point(193, 31);
            this.sessieListBox.Margin = new System.Windows.Forms.Padding(4);
            this.sessieListBox.Name = "sessieListBox";
            this.sessieListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.sessieListBox.Size = new System.Drawing.Size(173, 266);
            this.sessieListBox.Sorted = true;
            this.sessieListBox.TabIndex = 6;
            // 
            // prijsLabel
            // 
            this.prijsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prijsLabel.Location = new System.Drawing.Point(272, 300);
            this.prijsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prijsLabel.Name = "prijsLabel";
            this.prijsLabel.Size = new System.Drawing.Size(94, 27);
            this.prijsLabel.TabIndex = 1;
            this.prijsLabel.Text = "€0,00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.volledigeConferentieCheckBox);
            this.panel1.Controls.Add(this.conferentieDagenCheckedListBox);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 266);
            this.panel1.TabIndex = 5;
            // 
            // volledigeConferentieCheckBox
            // 
            this.volledigeConferentieCheckBox.AutoSize = true;
            this.volledigeConferentieCheckBox.Location = new System.Drawing.Point(4, 4);
            this.volledigeConferentieCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.volledigeConferentieCheckBox.Name = "volledigeConferentieCheckBox";
            this.volledigeConferentieCheckBox.Size = new System.Drawing.Size(160, 21);
            this.volledigeConferentieCheckBox.TabIndex = 4;
            this.volledigeConferentieCheckBox.Text = "Volledige conferentie";
            this.volledigeConferentieCheckBox.UseVisualStyleBackColor = true;
            this.volledigeConferentieCheckBox.CheckedChanged += new System.EventHandler(this.volledigeConferentieCheckBox_CheckedChanged);
            // 
            // conferentieDagenCheckedListBox
            // 
            this.conferentieDagenCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conferentieDagenCheckedListBox.CheckOnClick = true;
            this.conferentieDagenCheckedListBox.IntegralHeight = false;
            this.conferentieDagenCheckedListBox.Location = new System.Drawing.Point(28, 30);
            this.conferentieDagenCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.conferentieDagenCheckedListBox.Name = "conferentieDagenCheckedListBox";
            this.conferentieDagenCheckedListBox.Size = new System.Drawing.Size(139, 230);
            this.conferentieDagenCheckedListBox.TabIndex = 1;
            this.conferentieDagenCheckedListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.conferentieDagenCheckedListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(190, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sessie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conferentie dagen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conferentie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conferentieListBox
            // 
            this.conferentieListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conferentieListBox.FormattingEnabled = true;
            this.conferentieListBox.IntegralHeight = false;
            this.conferentieListBox.ItemHeight = 16;
            this.conferentieListBox.Location = new System.Drawing.Point(11, 43);
            this.conferentieListBox.Margin = new System.Windows.Forms.Padding(4);
            this.conferentieListBox.Name = "conferentieListBox";
            this.conferentieListBox.Size = new System.Drawing.Size(173, 300);
            this.conferentieListBox.Sorted = true;
            this.conferentieListBox.TabIndex = 0;
            this.conferentieListBox.SelectedIndexChanged += new System.EventHandler(this.conferentieListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.factuurUserControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Factuur";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // factuurUserControl2
            // 
            this.factuurUserControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factuurUserControl2.Location = new System.Drawing.Point(7, 20);
            this.factuurUserControl2.Margin = new System.Windows.Forms.Padding(4);
            this.factuurUserControl2.Name = "factuurUserControl2";
            this.factuurUserControl2.Size = new System.Drawing.Size(357, 277);
            this.factuurUserControl2.TabIndex = 0;
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.opslaanButton.Location = new System.Drawing.Point(492, 388);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(4);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(132, 28);
            this.opslaanButton.TabIndex = 13;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // NieuweInschrijngUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NieuweInschrijngUC";
            this.Size = new System.Drawing.Size(633, 418);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.conferentieDagPanel.ResumeLayout(false);
            this.conferentieDagPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        //private PersoonBedrijfUserControl persoonBedrijfUserControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel conferentieDagPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox sessieListBox;
        private System.Windows.Forms.Label prijsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox volledigeConferentieCheckBox;
        private System.Windows.Forms.CheckedListBox conferentieDagenCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox conferentieListBox;
        private System.Windows.Forms.Button opslaanButton;
        //private PersoonBedrijfUserControl persoonBedrijfUserControl2;
        private PersoonBedrijfUserControl deelnemerPersoonBedrijfUserControl;
        private System.Windows.Forms.TabPage tabPage3;
        //private FactuurUserControl factuurUserControl1;
        private FactuurUserControl factuurUserControl2;
    }
}
