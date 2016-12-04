namespace ConferentieSysteemWinApp.UserControls
{
    partial class PersoonBedrijfUserControl
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wachtwoordPasswoordTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gebruikersnaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.bedrijfGroupBox = new System.Windows.Forms.GroupBox();
            this.bedrijfZoekenButton = new System.Windows.Forms.Button();
            this.btwNummerMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.bedrijfContactGegevens2 = new ConferentieSysteemWinApp.UserControls.ContactGegevens();
            this.bedrijfsnaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bedrijfCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.persoonZoekenButton = new System.Windows.Forms.Button();
            this.DeelnemerContactGegevens1 = new ConferentieSysteemWinApp.UserControls.ContactGegevens();
            this.achternaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.voornaamLimietTextBox1 = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.groupBox1.SuspendLayout();
            this.bedrijfGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "BTW-nummer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bedrijfsnaam:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.wachtwoordPasswoordTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.gebruikersnaamLimietTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(401, 101);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Wachtwoord:";
            // 
            // wachtwoordPasswoordTextBox
            // 
            this.wachtwoordPasswoordTextBox.Location = new System.Drawing.Point(138, 60);
            this.wachtwoordPasswoordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wachtwoordPasswoordTextBox.MaxLength = 50;
            this.wachtwoordPasswoordTextBox.Name = "wachtwoordPasswoordTextBox";
            this.wachtwoordPasswoordTextBox.ReadOnly = true;
            this.wachtwoordPasswoordTextBox.Size = new System.Drawing.Size(221, 22);
            this.wachtwoordPasswoordTextBox.TabIndex = 0;
            this.wachtwoordPasswoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordPasswoordTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamLimietTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Gebruikersnaam:";
            // 
            // gebruikersnaamLimietTextBox
            // 
            this.gebruikersnaamLimietTextBox.Location = new System.Drawing.Point(138, 25);
            this.gebruikersnaamLimietTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gebruikersnaamLimietTextBox.MaxLength = 50;
            this.gebruikersnaamLimietTextBox.Name = "gebruikersnaamLimietTextBox";
            this.gebruikersnaamLimietTextBox.Size = new System.Drawing.Size(221, 22);
            this.gebruikersnaamLimietTextBox.TabIndex = 13;
            this.gebruikersnaamLimietTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamLimietTextBox_TextChanged);
            // 
            // bedrijfGroupBox
            // 
            this.bedrijfGroupBox.Controls.Add(this.bedrijfZoekenButton);
            this.bedrijfGroupBox.Controls.Add(this.btwNummerMaskedTextBox1);
            this.bedrijfGroupBox.Controls.Add(this.label9);
            this.bedrijfGroupBox.Controls.Add(this.label8);
            this.bedrijfGroupBox.Controls.Add(this.bedrijfContactGegevens2);
            this.bedrijfGroupBox.Controls.Add(this.bedrijfsnaamLimietTextBox);
            this.bedrijfGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfGroupBox.Location = new System.Drawing.Point(4, 482);
            this.bedrijfGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedrijfGroupBox.Name = "bedrijfGroupBox";
            this.bedrijfGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedrijfGroupBox.Size = new System.Drawing.Size(583, 341);
            this.bedrijfGroupBox.TabIndex = 22;
            this.bedrijfGroupBox.TabStop = false;
            this.bedrijfGroupBox.Text = "Bedrijf";
            this.bedrijfGroupBox.Visible = false;
            // 
            // bedrijfZoekenButton
            // 
            this.bedrijfZoekenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfZoekenButton.Location = new System.Drawing.Point(403, 12);
            this.bedrijfZoekenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedrijfZoekenButton.Name = "bedrijfZoekenButton";
            this.bedrijfZoekenButton.Size = new System.Drawing.Size(157, 31);
            this.bedrijfZoekenButton.TabIndex = 25;
            this.bedrijfZoekenButton.Text = "Zoek bedrijf";
            this.bedrijfZoekenButton.UseVisualStyleBackColor = true;
            // 
            // btwNummerMaskedTextBox1
            // 
            this.btwNummerMaskedTextBox1.Culture = new System.Globalization.CultureInfo("");
            this.btwNummerMaskedTextBox1.Location = new System.Drawing.Point(131, 284);
            this.btwNummerMaskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btwNummerMaskedTextBox1.Mask = "BE 00.0000.0000";
            this.btwNummerMaskedTextBox1.Name = "btwNummerMaskedTextBox1";
            this.btwNummerMaskedTextBox1.PromptChar = '-';
            this.btwNummerMaskedTextBox1.Size = new System.Drawing.Size(221, 22);
            this.btwNummerMaskedTextBox1.TabIndex = 18;
            this.btwNummerMaskedTextBox1.TextChanged += new System.EventHandler(this.gebruikersnaamLimietTextBox_TextChanged);
            // 
            // bedrijfContactGegevens2
            // 
            this.bedrijfContactGegevens2.Email = "";
            this.bedrijfContactGegevens2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfContactGegevens2.Gemeente = null;
            this.bedrijfContactGegevens2.GsmNr = "    /   .";
            this.bedrijfContactGegevens2.Huisnummer = "";
            this.bedrijfContactGegevens2.Location = new System.Drawing.Point(10, 48);
            this.bedrijfContactGegevens2.Margin = new System.Windows.Forms.Padding(6);
            this.bedrijfContactGegevens2.Name = "bedrijfContactGegevens2";
            this.bedrijfContactGegevens2.Size = new System.Drawing.Size(550, 233);
            this.bedrijfContactGegevens2.Straat = "";
            this.bedrijfContactGegevens2.TabIndex = 14;
            this.bedrijfContactGegevens2.TelefoonNr = "   /  .  .";
            // 
            // bedrijfsnaamLimietTextBox
            // 
            this.bedrijfsnaamLimietTextBox.Location = new System.Drawing.Point(131, 21);
            this.bedrijfsnaamLimietTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedrijfsnaamLimietTextBox.MaxLength = 50;
            this.bedrijfsnaamLimietTextBox.Name = "bedrijfsnaamLimietTextBox";
            this.bedrijfsnaamLimietTextBox.Size = new System.Drawing.Size(221, 22);
            this.bedrijfsnaamLimietTextBox.TabIndex = 13;
            this.bedrijfsnaamLimietTextBox.TextChanged += new System.EventHandler(this.gebruikersnaamLimietTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Aangesloten bij\r\nbedrijf?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bedrijfCheckBox
            // 
            this.bedrijfCheckBox.AutoSize = true;
            this.bedrijfCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfCheckBox.Location = new System.Drawing.Point(144, 298);
            this.bedrijfCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedrijfCheckBox.Name = "bedrijfCheckBox";
            this.bedrijfCheckBox.Size = new System.Drawing.Size(15, 14);
            this.bedrijfCheckBox.TabIndex = 20;
            this.bedrijfCheckBox.UseVisualStyleBackColor = true;
            this.bedrijfCheckBox.CheckedChanged += new System.EventHandler(this.bedrijfCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Achternaam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Voornaam:";
            // 
            // persoonZoekenButton
            // 
            this.persoonZoekenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persoonZoekenButton.Location = new System.Drawing.Point(371, 2);
            this.persoonZoekenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.persoonZoekenButton.Name = "persoonZoekenButton";
            this.persoonZoekenButton.Size = new System.Drawing.Size(157, 31);
            this.persoonZoekenButton.TabIndex = 24;
            this.persoonZoekenButton.Text = "Zoek persoon";
            this.persoonZoekenButton.UseVisualStyleBackColor = true;
            this.persoonZoekenButton.Click += new System.EventHandler(this.persoonZoekenButton_Click);
            // 
            // DeelnemerContactGegevens1
            // 
            this.DeelnemerContactGegevens1.Email = "";
            this.DeelnemerContactGegevens1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeelnemerContactGegevens1.Gemeente = null;
            this.DeelnemerContactGegevens1.GsmNr = "    /   .";
            this.DeelnemerContactGegevens1.Huisnummer = "";
            this.DeelnemerContactGegevens1.Location = new System.Drawing.Point(21, 53);
            this.DeelnemerContactGegevens1.Margin = new System.Windows.Forms.Padding(6);
            this.DeelnemerContactGegevens1.Name = "DeelnemerContactGegevens1";
            this.DeelnemerContactGegevens1.Size = new System.Drawing.Size(566, 234);
            this.DeelnemerContactGegevens1.Straat = "";
            this.DeelnemerContactGegevens1.TabIndex = 17;
            this.DeelnemerContactGegevens1.TelefoonNr = "   /  .  .";
            // 
            // achternaamLimietTextBox
            // 
            this.achternaamLimietTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaamLimietTextBox.Location = new System.Drawing.Point(142, 28);
            this.achternaamLimietTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.achternaamLimietTextBox.MaxLength = 50;
            this.achternaamLimietTextBox.Name = "achternaamLimietTextBox";
            this.achternaamLimietTextBox.Size = new System.Drawing.Size(221, 22);
            this.achternaamLimietTextBox.TabIndex = 16;
            this.achternaamLimietTextBox.TextChanged += new System.EventHandler(this.voornaamLimietTextBox1_TextChanged);
            // 
            // voornaamLimietTextBox1
            // 
            this.voornaamLimietTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamLimietTextBox1.Location = new System.Drawing.Point(142, 0);
            this.voornaamLimietTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voornaamLimietTextBox1.MaxLength = 50;
            this.voornaamLimietTextBox1.Name = "voornaamLimietTextBox1";
            this.voornaamLimietTextBox1.Size = new System.Drawing.Size(221, 22);
            this.voornaamLimietTextBox1.TabIndex = 15;
            this.voornaamLimietTextBox1.TextChanged += new System.EventHandler(this.voornaamLimietTextBox1_TextChanged);
            // 
            // PersoonBedrijfUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.persoonZoekenButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bedrijfGroupBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bedrijfCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeelnemerContactGegevens1);
            this.Controls.Add(this.achternaamLimietTextBox);
            this.Controls.Add(this.voornaamLimietTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersoonBedrijfUserControl";
            this.Size = new System.Drawing.Size(593, 828);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bedrijfGroupBox.ResumeLayout(false);
            this.bedrijfGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ContactGegevens bedrijfContactGegevens2;
        private LimietTextBox bedrijfsnaamLimietTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private PasswoordTextBox wachtwoordPasswoordTextBox;
        private System.Windows.Forms.Label label11;
        private LimietTextBox gebruikersnaamLimietTextBox;
        private System.Windows.Forms.GroupBox bedrijfGroupBox;
        private System.Windows.Forms.MaskedTextBox btwNummerMaskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox bedrijfCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ContactGegevens DeelnemerContactGegevens1;
        private LimietTextBox achternaamLimietTextBox;
        private LimietTextBox voornaamLimietTextBox1;
        private System.Windows.Forms.Button bedrijfZoekenButton;
        private System.Windows.Forms.Button persoonZoekenButton;
    }
}
