namespace ConferentieSysteemWinApp.UserControls
{
    partial class ContactGegevens
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.provincieLabel = new System.Windows.Forms.Label();
            this.telefoonMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gsmMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sugestieListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.postcodeLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.gemeenteLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.huisnummerLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.straatLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Straat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Huisnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gemeente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Postcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Provincie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefoon nr.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gsm nr.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "E mail adres:";
            // 
            // provincieLabel
            // 
            this.provincieLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.provincieLabel.Location = new System.Drawing.Point(121, 116);
            this.provincieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provincieLabel.Name = "provincieLabel";
            this.provincieLabel.Size = new System.Drawing.Size(219, 23);
            this.provincieLabel.TabIndex = 16;
            this.provincieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telefoonMaskedTextBox
            // 
            this.telefoonMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.telefoonMaskedTextBox.Location = new System.Drawing.Point(121, 148);
            this.telefoonMaskedTextBox.Mask = "000/00.00.00";
            this.telefoonMaskedTextBox.Name = "telefoonMaskedTextBox";
            this.telefoonMaskedTextBox.PromptChar = '-';
            this.telefoonMaskedTextBox.Size = new System.Drawing.Size(219, 23);
            this.telefoonMaskedTextBox.TabIndex = 7;
            this.telefoonMaskedTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // gsmMaskedTextBox
            // 
            this.gsmMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.gsmMaskedTextBox.Location = new System.Drawing.Point(121, 174);
            this.gsmMaskedTextBox.Mask = "0000/000.000";
            this.gsmMaskedTextBox.Name = "gsmMaskedTextBox";
            this.gsmMaskedTextBox.PromptChar = '-';
            this.gsmMaskedTextBox.Size = new System.Drawing.Size(219, 23);
            this.gsmMaskedTextBox.TabIndex = 8;
            this.gsmMaskedTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // sugestieListBox
            // 
            this.sugestieListBox.FormattingEnabled = true;
            this.sugestieListBox.ItemHeight = 16;
            this.sugestieListBox.Location = new System.Drawing.Point(360, 0);
            this.sugestieListBox.Name = "sugestieListBox";
            this.sugestieListBox.Size = new System.Drawing.Size(201, 196);
            this.sugestieListBox.TabIndex = 19;
            this.sugestieListBox.Visible = false;
            this.sugestieListBox.DoubleClick += new System.EventHandler(this.sugestieListBox_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConferentieSysteemWinApp.Properties.Resources.Kleine_help;
            this.pictureBox1.Location = new System.Drawing.Point(360, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // emailLimietTextBox
            // 
            this.emailLimietTextBox.BackColor = System.Drawing.Color.White;
            this.emailLimietTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailLimietTextBox.Location = new System.Drawing.Point(121, 203);
            this.emailLimietTextBox.MaxLength = 50;
            this.emailLimietTextBox.Name = "emailLimietTextBox";
            this.emailLimietTextBox.Size = new System.Drawing.Size(221, 23);
            this.emailLimietTextBox.TabIndex = 9;
            this.emailLimietTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            this.emailLimietTextBox.Leave += new System.EventHandler(this.emailLimietTextBox_Leave);
            // 
            // postcodeLimietTextBox
            // 
            this.postcodeLimietTextBox.Location = new System.Drawing.Point(121, 87);
            this.postcodeLimietTextBox.MaxLength = 50;
            this.postcodeLimietTextBox.Name = "postcodeLimietTextBox";
            this.postcodeLimietTextBox.Size = new System.Drawing.Size(221, 23);
            this.postcodeLimietTextBox.TabIndex = 6;
            this.postcodeLimietTextBox.TextChanged += new System.EventHandler(this.postcodeLimietTextBox_TextChanged);
            this.postcodeLimietTextBox.Enter += new System.EventHandler(this.ToonListbox);
            this.postcodeLimietTextBox.Leave += new System.EventHandler(this.postcodeLimietTextBox_Leave);
            // 
            // gemeenteLimietTextBox
            // 
            this.gemeenteLimietTextBox.Location = new System.Drawing.Point(121, 58);
            this.gemeenteLimietTextBox.MaxLength = 50;
            this.gemeenteLimietTextBox.Name = "gemeenteLimietTextBox";
            this.gemeenteLimietTextBox.Size = new System.Drawing.Size(221, 23);
            this.gemeenteLimietTextBox.TabIndex = 5;
            this.gemeenteLimietTextBox.TextChanged += new System.EventHandler(this.gemeenteLimietTextBox_TextChanged);
            this.gemeenteLimietTextBox.Enter += new System.EventHandler(this.ToonListbox);
            this.gemeenteLimietTextBox.Leave += new System.EventHandler(this.postcodeLimietTextBox_Leave);
            // 
            // huisnummerLimietTextBox
            // 
            this.huisnummerLimietTextBox.Location = new System.Drawing.Point(121, 29);
            this.huisnummerLimietTextBox.MaxLength = 10;
            this.huisnummerLimietTextBox.Name = "huisnummerLimietTextBox";
            this.huisnummerLimietTextBox.Size = new System.Drawing.Size(221, 23);
            this.huisnummerLimietTextBox.TabIndex = 4;
            this.huisnummerLimietTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // straatLimietTextBox
            // 
            this.straatLimietTextBox.Location = new System.Drawing.Point(121, 0);
            this.straatLimietTextBox.MaxLength = 50;
            this.straatLimietTextBox.Name = "straatLimietTextBox";
            this.straatLimietTextBox.Size = new System.Drawing.Size(221, 23);
            this.straatLimietTextBox.TabIndex = 3;
            this.straatLimietTextBox.TextChanged += new System.EventHandler(this.GeefEvent);
            // 
            // ContactGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sugestieListBox);
            this.Controls.Add(this.gsmMaskedTextBox);
            this.Controls.Add(this.telefoonMaskedTextBox);
            this.Controls.Add(this.provincieLabel);
            this.Controls.Add(this.emailLimietTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postcodeLimietTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gemeenteLimietTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.huisnummerLimietTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.straatLimietTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactGegevens";
            this.Size = new System.Drawing.Size(561, 228);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LimietTextBox straatLimietTextBox;
        private LimietTextBox huisnummerLimietTextBox;
        private System.Windows.Forms.Label label2;
        private LimietTextBox gemeenteLimietTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LimietTextBox emailLimietTextBox;
        private System.Windows.Forms.Label label8;
        private LimietTextBox postcodeLimietTextBox;
        private System.Windows.Forms.Label provincieLabel;
        private System.Windows.Forms.MaskedTextBox telefoonMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox gsmMaskedTextBox;
        private System.Windows.Forms.ListBox sugestieListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
