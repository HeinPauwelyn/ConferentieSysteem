namespace ConferentieSysteemWinApp.UserControls
{
    partial class PersoonAccountUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.herhaalWachtwooordLabel = new System.Windows.Forms.Label();
            this.herhaalWachtwoorsPasswoordTextBox1 = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.zendProsesBar = new ConferentieSysteemWinApp.UserControls.ProsesBar();
            this.label12 = new System.Windows.Forms.Label();
            this.WachtwoordPasswoordTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.gebruikersnaamTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nieuwBedrijfButton = new System.Windows.Forms.Button();
            this.bedrijfComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.acternaamTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bedrijfCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.functieComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactContactGegevens = new ConferentieSysteemWinApp.UserControls.ContactGegevens();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.herhaalWachtwooordLabel);
            this.groupBox1.Controls.Add(this.herhaalWachtwoorsPasswoordTextBox1);
            this.groupBox1.Controls.Add(this.zendProsesBar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.WachtwoordPasswoordTextBox);
            this.groupBox1.Controls.Add(this.gebruikersnaamTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 431);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(379, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Expert";
            // 
            // herhaalWachtwooordLabel
            // 
            this.herhaalWachtwooordLabel.AutoSize = true;
            this.herhaalWachtwooordLabel.Location = new System.Drawing.Point(46, 103);
            this.herhaalWachtwooordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.herhaalWachtwooordLabel.Name = "herhaalWachtwooordLabel";
            this.herhaalWachtwooordLabel.Size = new System.Drawing.Size(82, 32);
            this.herhaalWachtwooordLabel.TabIndex = 15;
            this.herhaalWachtwooordLabel.Text = "Herhaal\r\nwachtwoord:";
            this.herhaalWachtwooordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.herhaalWachtwooordLabel.Visible = false;
            // 
            // herhaalWachtwoorsPasswoordTextBox1
            // 
            this.herhaalWachtwoorsPasswoordTextBox1.Location = new System.Drawing.Point(140, 108);
            this.herhaalWachtwoorsPasswoordTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.herhaalWachtwoorsPasswoordTextBox1.MaxLength = 50;
            this.herhaalWachtwoorsPasswoordTextBox1.Name = "herhaalWachtwoorsPasswoordTextBox1";
            this.herhaalWachtwoorsPasswoordTextBox1.Size = new System.Drawing.Size(222, 22);
            this.herhaalWachtwoorsPasswoordTextBox1.TabIndex = 14;
            this.herhaalWachtwoorsPasswoordTextBox1.UseSystemPasswordChar = true;
            this.herhaalWachtwoorsPasswoordTextBox1.Visible = false;
            this.herhaalWachtwoorsPasswoordTextBox1.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // zendProsesBar
            // 
            this.zendProsesBar.Location = new System.Drawing.Point(17, 150);
            this.zendProsesBar.Margin = new System.Windows.Forms.Padding(5);
            this.zendProsesBar.Name = "zendProsesBar";
            this.zendProsesBar.Size = new System.Drawing.Size(345, 30);
            this.zendProsesBar.TabIndex = 10;
            this.zendProsesBar.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Wachtwoord:";
            // 
            // WachtwoordPasswoordTextBox
            // 
            this.WachtwoordPasswoordTextBox.Location = new System.Drawing.Point(140, 70);
            this.WachtwoordPasswoordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WachtwoordPasswoordTextBox.MaxLength = 50;
            this.WachtwoordPasswoordTextBox.Name = "WachtwoordPasswoordTextBox";
            this.WachtwoordPasswoordTextBox.ReadOnly = true;
            this.WachtwoordPasswoordTextBox.Size = new System.Drawing.Size(222, 22);
            this.WachtwoordPasswoordTextBox.TabIndex = 12;
            this.WachtwoordPasswoordTextBox.UseSystemPasswordChar = true;
            this.WachtwoordPasswoordTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // gebruikersnaamTextBox
            // 
            this.gebruikersnaamTextBox.Location = new System.Drawing.Point(140, 40);
            this.gebruikersnaamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gebruikersnaamTextBox.MaxLength = 50;
            this.gebruikersnaamTextBox.Name = "gebruikersnaamTextBox";
            this.gebruikersnaamTextBox.Size = new System.Drawing.Size(222, 22);
            this.gebruikersnaamTextBox.TabIndex = 5;
            this.gebruikersnaamTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gebruikersnaam:";
            // 
            // nieuwBedrijfButton
            // 
            this.nieuwBedrijfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nieuwBedrijfButton.Location = new System.Drawing.Point(351, 298);
            this.nieuwBedrijfButton.Margin = new System.Windows.Forms.Padding(4);
            this.nieuwBedrijfButton.Name = "nieuwBedrijfButton";
            this.nieuwBedrijfButton.Size = new System.Drawing.Size(126, 24);
            this.nieuwBedrijfButton.TabIndex = 17;
            this.nieuwBedrijfButton.Text = "Nieuw bedrijf...";
            this.nieuwBedrijfButton.UseVisualStyleBackColor = true;
            this.nieuwBedrijfButton.Click += new System.EventHandler(this.nieuwBedrijfButton_Click);
            // 
            // bedrijfComboBox
            // 
            this.bedrijfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedrijfComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedrijfComboBox.FormattingEnabled = true;
            this.bedrijfComboBox.Location = new System.Drawing.Point(121, 298);
            this.bedrijfComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.bedrijfComboBox.Name = "bedrijfComboBox";
            this.bedrijfComboBox.Size = new System.Drawing.Size(222, 24);
            this.bedrijfComboBox.TabIndex = 15;
            this.bedrijfComboBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Bedrijf:";
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamTextBox.Location = new System.Drawing.Point(121, 6);
            this.voornaamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.voornaamTextBox.MaxLength = 50;
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(222, 22);
            this.voornaamTextBox.TabIndex = 10;
            this.voornaamTextBox.TextChanged += new System.EventHandler(this.voornaamTextBox_TextChanged);
            // 
            // acternaamTextBox
            // 
            this.acternaamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acternaamTextBox.Location = new System.Drawing.Point(121, 36);
            this.acternaamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.acternaamTextBox.MaxLength = 50;
            this.acternaamTextBox.Name = "acternaamTextBox";
            this.acternaamTextBox.Size = new System.Drawing.Size(222, 22);
            this.acternaamTextBox.TabIndex = 11;
            this.acternaamTextBox.TextChanged += new System.EventHandler(this.voornaamTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Achternaam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Voornaam:";
            // 
            // bedrijfCheckBox
            // 
            this.bedrijfCheckBox.AutoSize = true;
            this.bedrijfCheckBox.Location = new System.Drawing.Point(121, 340);
            this.bedrijfCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.bedrijfCheckBox.Name = "bedrijfCheckBox";
            this.bedrijfCheckBox.Size = new System.Drawing.Size(15, 14);
            this.bedrijfCheckBox.TabIndex = 19;
            this.bedrijfCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aangesloten \r\nbij bedrijf:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // functieComboBox
            // 
            this.functieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functieComboBox.FormattingEnabled = true;
            this.functieComboBox.Location = new System.Drawing.Point(121, 367);
            this.functieComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.functieComboBox.Name = "functieComboBox";
            this.functieComboBox.Size = new System.Drawing.Size(222, 24);
            this.functieComboBox.TabIndex = 22;
            this.functieComboBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Functie:";
            // 
            // contactContactGegevens
            // 
            this.contactContactGegevens.Email = "";
            this.contactContactGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactContactGegevens.Gemeente = null;
            this.contactContactGegevens.GsmNr = "    /   .";
            this.contactContactGegevens.Huisnummer = "";
            this.contactContactGegevens.Location = new System.Drawing.Point(0, 66);
            this.contactContactGegevens.Margin = new System.Windows.Forms.Padding(4);
            this.contactContactGegevens.Name = "contactContactGegevens";
            this.contactContactGegevens.Size = new System.Drawing.Size(561, 228);
            this.contactContactGegevens.Straat = "";
            this.contactContactGegevens.TabIndex = 21;
            this.contactContactGegevens.TelefoonNr = "   /  .  .";
            // 
            // PersoonAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.functieComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactContactGegevens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bedrijfCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nieuwBedrijfButton);
            this.Controls.Add(this.bedrijfComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.acternaamTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersoonAccountUserControl";
            this.Size = new System.Drawing.Size(569, 636);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ProsesBar zendProsesBar;
        private System.Windows.Forms.Label label12;
        private PasswoordTextBox WachtwoordPasswoordTextBox;
        private System.Windows.Forms.TextBox gebruikersnaamTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nieuwBedrijfButton;
        private System.Windows.Forms.ComboBox bedrijfComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox acternaamTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox bedrijfCheckBox;
        private System.Windows.Forms.Label label1;
        private ContactGegevens contactContactGegevens;
        private System.Windows.Forms.ComboBox functieComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label herhaalWachtwooordLabel;
        private PasswoordTextBox herhaalWachtwoorsPasswoordTextBox1;
    }
}
