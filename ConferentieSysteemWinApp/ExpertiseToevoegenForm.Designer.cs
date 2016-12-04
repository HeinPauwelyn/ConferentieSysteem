namespace ConferentieSysteemWinApp
{
    partial class ExpertiseToevoegenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertiseToevoegenForm));
            this.expertiseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nieuweExpertiseGroupBox = new System.Windows.Forms.GroupBox();
            this.anulerenExpertiseButton = new System.Windows.Forms.Button();
            this.infoExpertiseInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.nieuwExpertiseBeschrijvingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expertiseToevoegenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nieuweExpertiseTextBox = new System.Windows.Forms.TextBox();
            this.nieuwDomeinBechrijvingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.domeinGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoDomeinPictureBox = new System.Windows.Forms.PictureBox();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.domeinLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.nieuweExpertiseButton = new System.Windows.Forms.Button();
            this.domeinenListBox = new System.Windows.Forms.ListBox();
            this.expertiseBeshrijvingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.expertiseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.domeinBeschrijvingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.domeinLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AnulerenDomeinButton = new System.Windows.Forms.Button();
            this.nieuweExpertiseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoExpertiseInfoPictureBox)).BeginInit();
            this.domeinGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDomeinPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expertiseComboBox
            // 
            this.expertiseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertiseComboBox.FormattingEnabled = true;
            this.expertiseComboBox.Location = new System.Drawing.Point(139, 24);
            this.expertiseComboBox.Name = "expertiseComboBox";
            this.expertiseComboBox.Size = new System.Drawing.Size(231, 24);
            this.expertiseComboBox.TabIndex = 5;
            this.expertiseComboBox.TextChanged += new System.EventHandler(this.expertiseComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expertise:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expertise domein:";
            // 
            // nieuweExpertiseGroupBox
            // 
            this.nieuweExpertiseGroupBox.Controls.Add(this.anulerenExpertiseButton);
            this.nieuweExpertiseGroupBox.Controls.Add(this.infoExpertiseInfoPictureBox);
            this.nieuweExpertiseGroupBox.Controls.Add(this.nieuwExpertiseBeschrijvingRichTextBox);
            this.nieuweExpertiseGroupBox.Controls.Add(this.label5);
            this.nieuweExpertiseGroupBox.Controls.Add(this.expertiseToevoegenButton);
            this.nieuweExpertiseGroupBox.Controls.Add(this.label4);
            this.nieuweExpertiseGroupBox.Controls.Add(this.nieuweExpertiseTextBox);
            this.nieuweExpertiseGroupBox.Location = new System.Drawing.Point(349, 271);
            this.nieuweExpertiseGroupBox.Name = "nieuweExpertiseGroupBox";
            this.nieuweExpertiseGroupBox.Size = new System.Drawing.Size(544, 178);
            this.nieuweExpertiseGroupBox.TabIndex = 12;
            this.nieuweExpertiseGroupBox.TabStop = false;
            this.nieuweExpertiseGroupBox.Text = "Nieuwe expertise";
            this.nieuweExpertiseGroupBox.Visible = false;
            // 
            // anulerenExpertiseButton
            // 
            this.anulerenExpertiseButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.anulerenExpertiseButton.Location = new System.Drawing.Point(221, 146);
            this.anulerenExpertiseButton.Name = "anulerenExpertiseButton";
            this.anulerenExpertiseButton.Size = new System.Drawing.Size(151, 26);
            this.anulerenExpertiseButton.TabIndex = 18;
            this.anulerenExpertiseButton.Text = "Anuleren";
            this.anulerenExpertiseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anulerenExpertiseButton.UseVisualStyleBackColor = true;
            this.anulerenExpertiseButton.Click += new System.EventHandler(this.Anuleren);
            // 
            // infoExpertiseInfoPictureBox
            // 
            this.infoExpertiseInfoPictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Informatie;
            this.infoExpertiseInfoPictureBox.Location = new System.Drawing.Point(378, 32);
            this.infoExpertiseInfoPictureBox.Name = "infoExpertiseInfoPictureBox";
            this.infoExpertiseInfoPictureBox.Size = new System.Drawing.Size(34, 23);
            this.infoExpertiseInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoExpertiseInfoPictureBox.TabIndex = 17;
            this.infoExpertiseInfoPictureBox.TabStop = false;
            // 
            // nieuwExpertiseBeschrijvingRichTextBox
            // 
            this.nieuwExpertiseBeschrijvingRichTextBox.Location = new System.Drawing.Point(139, 73);
            this.nieuwExpertiseBeschrijvingRichTextBox.Name = "nieuwExpertiseBeschrijvingRichTextBox";
            this.nieuwExpertiseBeschrijvingRichTextBox.Size = new System.Drawing.Size(231, 64);
            this.nieuwExpertiseBeschrijvingRichTextBox.TabIndex = 16;
            this.nieuwExpertiseBeschrijvingRichTextBox.Text = "";
            this.nieuwExpertiseBeschrijvingRichTextBox.TextChanged += new System.EventHandler(this.EnabelExpertiseToevoegenButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Beschrijving:";
            // 
            // expertiseToevoegenButton
            // 
            this.expertiseToevoegenButton.Enabled = false;
            this.expertiseToevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.expertiseToevoegenButton.Location = new System.Drawing.Point(378, 146);
            this.expertiseToevoegenButton.Name = "expertiseToevoegenButton";
            this.expertiseToevoegenButton.Size = new System.Drawing.Size(151, 26);
            this.expertiseToevoegenButton.TabIndex = 13;
            this.expertiseToevoegenButton.Text = "Expertise opslaan";
            this.expertiseToevoegenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.expertiseToevoegenButton.UseVisualStyleBackColor = true;
            this.expertiseToevoegenButton.Click += new System.EventHandler(this.ExpertiseToevoegen);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Expertise:";
            // 
            // nieuweExpertiseTextBox
            // 
            this.nieuweExpertiseTextBox.Location = new System.Drawing.Point(139, 32);
            this.nieuweExpertiseTextBox.Name = "nieuweExpertiseTextBox";
            this.nieuweExpertiseTextBox.Size = new System.Drawing.Size(231, 23);
            this.nieuweExpertiseTextBox.TabIndex = 14;
            this.nieuweExpertiseTextBox.TextChanged += new System.EventHandler(this.EnabelExpertiseToevoegenButton);
            // 
            // nieuwDomeinBechrijvingRichTextBox
            // 
            this.nieuwDomeinBechrijvingRichTextBox.Location = new System.Drawing.Point(139, 87);
            this.nieuwDomeinBechrijvingRichTextBox.Name = "nieuwDomeinBechrijvingRichTextBox";
            this.nieuwDomeinBechrijvingRichTextBox.Size = new System.Drawing.Size(231, 98);
            this.nieuwDomeinBechrijvingRichTextBox.TabIndex = 18;
            this.nieuwDomeinBechrijvingRichTextBox.Text = "";
            this.nieuwDomeinBechrijvingRichTextBox.TextChanged += new System.EventHandler(this.expertiseComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Beschrijving:";
            // 
            // domeinGroupBox
            // 
            this.domeinGroupBox.Controls.Add(this.AnulerenDomeinButton);
            this.domeinGroupBox.Controls.Add(this.InfoDomeinPictureBox);
            this.domeinGroupBox.Controls.Add(this.opslaanButton);
            this.domeinGroupBox.Controls.Add(this.domeinLimietTextBox);
            this.domeinGroupBox.Controls.Add(this.nieuwDomeinBechrijvingRichTextBox);
            this.domeinGroupBox.Controls.Add(this.label6);
            this.domeinGroupBox.Controls.Add(this.label3);
            this.domeinGroupBox.Controls.Add(this.label2);
            this.domeinGroupBox.Controls.Add(this.nieuweExpertiseButton);
            this.domeinGroupBox.Controls.Add(this.expertiseComboBox);
            this.domeinGroupBox.Location = new System.Drawing.Point(349, 12);
            this.domeinGroupBox.Name = "domeinGroupBox";
            this.domeinGroupBox.Size = new System.Drawing.Size(544, 253);
            this.domeinGroupBox.TabIndex = 21;
            this.domeinGroupBox.TabStop = false;
            this.domeinGroupBox.Text = "Nieuwe expertise domein";
            this.domeinGroupBox.Visible = false;
            // 
            // InfoDomeinPictureBox
            // 
            this.InfoDomeinPictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Informatie;
            this.InfoDomeinPictureBox.Location = new System.Drawing.Point(378, 58);
            this.InfoDomeinPictureBox.Name = "InfoDomeinPictureBox";
            this.InfoDomeinPictureBox.Size = new System.Drawing.Size(34, 23);
            this.InfoDomeinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoDomeinPictureBox.TabIndex = 18;
            this.InfoDomeinPictureBox.TabStop = false;
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.opslaanButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.opslaanButton.Location = new System.Drawing.Point(378, 221);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(151, 26);
            this.opslaanButton.TabIndex = 20;
            this.opslaanButton.Text = "Domein opslaan";
            this.opslaanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // domeinLimietTextBox
            // 
            this.domeinLimietTextBox.Location = new System.Drawing.Point(139, 58);
            this.domeinLimietTextBox.MaxLength = 50;
            this.domeinLimietTextBox.Name = "domeinLimietTextBox";
            this.domeinLimietTextBox.Size = new System.Drawing.Size(231, 23);
            this.domeinLimietTextBox.TabIndex = 19;
            this.domeinLimietTextBox.TextChanged += new System.EventHandler(this.expertiseComboBox_TextChanged);
            // 
            // nieuweExpertiseButton
            // 
            this.nieuweExpertiseButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.nieuweExpertiseButton.Location = new System.Drawing.Point(378, 22);
            this.nieuweExpertiseButton.Name = "nieuweExpertiseButton";
            this.nieuweExpertiseButton.Size = new System.Drawing.Size(151, 26);
            this.nieuweExpertiseButton.TabIndex = 6;
            this.nieuweExpertiseButton.Text = "Nieuwe expertise";
            this.nieuweExpertiseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.nieuweExpertiseButton.UseVisualStyleBackColor = true;
            this.nieuweExpertiseButton.Click += new System.EventHandler(this.GroupBoxNieuweExpertiseTonen);
            // 
            // domeinenListBox
            // 
            this.domeinenListBox.FormattingEnabled = true;
            this.domeinenListBox.ItemHeight = 16;
            this.domeinenListBox.Location = new System.Drawing.Point(12, 11);
            this.domeinenListBox.Name = "domeinenListBox";
            this.domeinenListBox.Size = new System.Drawing.Size(253, 148);
            this.domeinenListBox.TabIndex = 22;
            this.domeinenListBox.SelectedIndexChanged += new System.EventHandler(this.domeinenListBox_SelectedIndexChanged);
            // 
            // expertiseBeshrijvingRichTextBox
            // 
            this.expertiseBeshrijvingRichTextBox.Location = new System.Drawing.Point(111, 54);
            this.expertiseBeshrijvingRichTextBox.Name = "expertiseBeshrijvingRichTextBox";
            this.expertiseBeshrijvingRichTextBox.ReadOnly = true;
            this.expertiseBeshrijvingRichTextBox.Size = new System.Drawing.Size(149, 65);
            this.expertiseBeshrijvingRichTextBox.TabIndex = 30;
            this.expertiseBeshrijvingRichTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Beschrijving:";
            // 
            // expertiseLabel
            // 
            this.expertiseLabel.Location = new System.Drawing.Point(110, 23);
            this.expertiseLabel.Name = "expertiseLabel";
            this.expertiseLabel.Size = new System.Drawing.Size(150, 22);
            this.expertiseLabel.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Expertise:";
            // 
            // domeinBeschrijvingRichTextBox
            // 
            this.domeinBeschrijvingRichTextBox.Location = new System.Drawing.Point(111, 177);
            this.domeinBeschrijvingRichTextBox.Name = "domeinBeschrijvingRichTextBox";
            this.domeinBeschrijvingRichTextBox.ReadOnly = true;
            this.domeinBeschrijvingRichTextBox.Size = new System.Drawing.Size(149, 65);
            this.domeinBeschrijvingRichTextBox.TabIndex = 34;
            this.domeinBeschrijvingRichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Beschrijving:";
            // 
            // domeinLabel
            // 
            this.domeinLabel.Location = new System.Drawing.Point(110, 151);
            this.domeinLabel.Name = "domeinLabel";
            this.domeinLabel.Size = new System.Drawing.Size(150, 22);
            this.domeinLabel.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Domein:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.domeinBeschrijvingRichTextBox);
            this.groupBox2.Controls.Add(this.expertiseLabel);
            this.groupBox2.Controls.Add(this.expertiseBeshrijvingRichTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.domeinLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(5, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 256);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // button2
            // 
            this.button2.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.button2.Location = new System.Drawing.Point(137, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Toevoegen";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnulerenDomeinButton
            // 
            this.AnulerenDomeinButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.AnulerenDomeinButton.Location = new System.Drawing.Point(219, 221);
            this.AnulerenDomeinButton.Name = "AnulerenDomeinButton";
            this.AnulerenDomeinButton.Size = new System.Drawing.Size(151, 26);
            this.AnulerenDomeinButton.TabIndex = 19;
            this.AnulerenDomeinButton.Text = "Anuleren";
            this.AnulerenDomeinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AnulerenDomeinButton.UseVisualStyleBackColor = true;
            this.AnulerenDomeinButton.Click += new System.EventHandler(this.AnulerenDomeinButton_Click);
            // 
            // ExpertiseToevoegenForm
            // 
            this.ClientSize = new System.Drawing.Size(905, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.domeinenListBox);
            this.Controls.Add(this.domeinGroupBox);
            this.Controls.Add(this.nieuweExpertiseGroupBox);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpertiseToevoegenForm";
            this.Text = "Expertise toevoegen";
            this.Load += new System.EventHandler(this.ExpertiseToevoegenForm_Load);
            this.nieuweExpertiseGroupBox.ResumeLayout(false);
            this.nieuweExpertiseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoExpertiseInfoPictureBox)).EndInit();
            this.domeinGroupBox.ResumeLayout(false);
            this.domeinGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDomeinPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox expertiseComboBox;
        private System.Windows.Forms.Button nieuweExpertiseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox nieuweExpertiseGroupBox;
        private System.Windows.Forms.Button expertiseToevoegenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nieuweExpertiseTextBox;
        private System.Windows.Forms.RichTextBox nieuwExpertiseBeschrijvingRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox nieuwDomeinBechrijvingRichTextBox;
        private System.Windows.Forms.Label label6;
        private ConferentieSysteemWinApp.UserControls.LimietTextBox domeinLimietTextBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.PictureBox infoExpertiseInfoPictureBox;
        private System.Windows.Forms.PictureBox InfoDomeinPictureBox;
        private System.Windows.Forms.GroupBox domeinGroupBox;
        private System.Windows.Forms.Button anulerenExpertiseButton;
        private System.Windows.Forms.ListBox domeinenListBox;
        private System.Windows.Forms.RichTextBox expertiseBeshrijvingRichTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label expertiseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox domeinBeschrijvingRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label domeinLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AnulerenDomeinButton;
    }
}
