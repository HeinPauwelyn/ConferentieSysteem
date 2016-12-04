namespace ConferentieSysteemWinApp
{
    partial class EvaluatieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluatieForm));
            this.label1 = new System.Windows.Forms.Label();
            this.coneferentieComboBox = new System.Windows.Forms.ComboBox();
            this.conferentieDagComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expertComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vraagEenComboBox = new System.Windows.Forms.ComboBox();
            this.vraagTweeComboBox = new System.Windows.Forms.ComboBox();
            this.vraagDrieComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.opmerkingenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.evaluatieGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.sessieComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.siteButton = new System.Windows.Forms.Button();
            this.facebookButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.evaluatieGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conferentie:";
            // 
            // coneferentieComboBox
            // 
            this.coneferentieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coneferentieComboBox.FormattingEnabled = true;
            this.coneferentieComboBox.Location = new System.Drawing.Point(285, 12);
            this.coneferentieComboBox.Name = "coneferentieComboBox";
            this.coneferentieComboBox.Size = new System.Drawing.Size(218, 24);
            this.coneferentieComboBox.TabIndex = 7;
            this.coneferentieComboBox.SelectedIndexChanged += new System.EventHandler(this.coneferentieComboBox_SelectedIndexChanged);
            this.coneferentieComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // conferentieDagComboBox
            // 
            this.conferentieDagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conferentieDagComboBox.FormattingEnabled = true;
            this.conferentieDagComboBox.Location = new System.Drawing.Point(285, 42);
            this.conferentieDagComboBox.Name = "conferentieDagComboBox";
            this.conferentieDagComboBox.Size = new System.Drawing.Size(218, 24);
            this.conferentieDagComboBox.TabIndex = 11;
            this.conferentieDagComboBox.SelectedIndexChanged += new System.EventHandler(this.sessieComboBox_SelectedIndexChanged);
            this.conferentieDagComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dag:";
            // 
            // expertComboBox
            // 
            this.expertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertComboBox.FormattingEnabled = true;
            this.expertComboBox.Location = new System.Drawing.Point(285, 72);
            this.expertComboBox.Name = "expertComboBox";
            this.expertComboBox.Size = new System.Drawing.Size(218, 24);
            this.expertComboBox.TabIndex = 13;
            this.expertComboBox.SelectedIndexChanged += new System.EventHandler(this.expertComboBox_SelectedIndexChanged);
            this.expertComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Expert:";
            // 
            // vraagEenComboBox
            // 
            this.vraagEenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vraagEenComboBox.FormattingEnabled = true;
            this.vraagEenComboBox.Items.AddRange(new object[] {
            "Volledig eens",
            "Gedeeltelijk eens",
            "Gedeeltelijk oneens",
            "Volledig oneens"});
            this.vraagEenComboBox.Location = new System.Drawing.Point(249, 19);
            this.vraagEenComboBox.Name = "vraagEenComboBox";
            this.vraagEenComboBox.Size = new System.Drawing.Size(218, 24);
            this.vraagEenComboBox.TabIndex = 14;
            this.vraagEenComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // vraagTweeComboBox
            // 
            this.vraagTweeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vraagTweeComboBox.FormattingEnabled = true;
            this.vraagTweeComboBox.Items.AddRange(new object[] {
            "Volledig eens",
            "Gedeeltelijk eens",
            "Gedeeltelijk oneens",
            "Volledig oneens"});
            this.vraagTweeComboBox.Location = new System.Drawing.Point(249, 66);
            this.vraagTweeComboBox.Name = "vraagTweeComboBox";
            this.vraagTweeComboBox.Size = new System.Drawing.Size(218, 24);
            this.vraagTweeComboBox.TabIndex = 15;
            this.vraagTweeComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // vraagDrieComboBox
            // 
            this.vraagDrieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vraagDrieComboBox.FormattingEnabled = true;
            this.vraagDrieComboBox.Items.AddRange(new object[] {
            "Volledig eens",
            "Gedeeltelijk eens",
            "Gedeeltelijk oneens",
            "Volledig oneens"});
            this.vraagDrieComboBox.Location = new System.Drawing.Point(249, 113);
            this.vraagDrieComboBox.Name = "vraagDrieComboBox";
            this.vraagDrieComboBox.Size = new System.Drawing.Size(218, 24);
            this.vraagDrieComboBox.TabIndex = 16;
            this.vraagDrieComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "De inhoud kwam volledig overeens\r\nmet mijn verwachtingen:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 41);
            this.label5.TabIndex = 18;
            this.label5.Text = "De inhoud werd goed gebracht:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 41);
            this.label6.TabIndex = 19;
            this.label6.Text = "De spreker antwoorde goed op de \r\nvragen uit het publiek:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 54);
            this.label7.TabIndex = 20;
            this.label7.Text = "Zijn er nog opmerkingen?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // opmerkingenRichTextBox
            // 
            this.opmerkingenRichTextBox.Location = new System.Drawing.Point(250, 155);
            this.opmerkingenRichTextBox.Name = "opmerkingenRichTextBox";
            this.opmerkingenRichTextBox.Size = new System.Drawing.Size(217, 54);
            this.opmerkingenRichTextBox.TabIndex = 21;
            this.opmerkingenRichTextBox.Text = "";
            // 
            // evaluatieGroupBox
            // 
            this.evaluatieGroupBox.Controls.Add(this.panel1);
            this.evaluatieGroupBox.Location = new System.Drawing.Point(187, 147);
            this.evaluatieGroupBox.Name = "evaluatieGroupBox";
            this.evaluatieGroupBox.Size = new System.Drawing.Size(524, 240);
            this.evaluatieGroupBox.TabIndex = 22;
            this.evaluatieGroupBox.TabStop = false;
            this.evaluatieGroupBox.Text = "Evaluatie";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.opmerkingenRichTextBox);
            this.panel1.Controls.Add(this.vraagEenComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.vraagTweeComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.vraagDrieComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 215);
            this.panel1.TabIndex = 22;
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.opslaanButton.Location = new System.Drawing.Point(576, 394);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(135, 28);
            this.opslaanButton.TabIndex = 23;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // sessieComboBox
            // 
            this.sessieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sessieComboBox.FormattingEnabled = true;
            this.sessieComboBox.Location = new System.Drawing.Point(285, 102);
            this.sessieComboBox.Name = "sessieComboBox";
            this.sessieComboBox.Size = new System.Drawing.Size(218, 24);
            this.sessieComboBox.TabIndex = 25;
            this.sessieComboBox.SelectedValueChanged += new System.EventHandler(this.EnabelOpslaanKnop);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sessie:";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.siteButton);
            this.menuPanel.Controls.Add(this.facebookButton);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(181, 432);
            this.menuPanel.TabIndex = 26;
            // 
            // siteButton
            // 
            this.siteButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Website32;
            this.siteButton.Location = new System.Drawing.Point(12, 375);
            this.siteButton.Name = "siteButton";
            this.siteButton.Size = new System.Drawing.Size(151, 45);
            this.siteButton.TabIndex = 2;
            this.siteButton.Text = "Ga naar onze site";
            this.siteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.siteButton.UseVisualStyleBackColor = true;
            this.siteButton.Click += new System.EventHandler(this.siteButton_Click);
            // 
            // facebookButton
            // 
            this.facebookButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Facebook32;
            this.facebookButton.Location = new System.Drawing.Point(12, 324);
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.Size = new System.Drawing.Size(151, 45);
            this.facebookButton.TabIndex = 1;
            this.facebookButton.Text = "Like ons op Facebook";
            this.facebookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.facebookButton.UseVisualStyleBackColor = true;
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ConferentieSysteemWinApp.Properties.Resources.Evaluaties;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Evaluaties";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EvaluatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(898, 432);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.sessieComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.evaluatieGroupBox);
            this.Controls.Add(this.expertComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conferentieDagComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coneferentieComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluatieForm";
            this.Text = "Evaluatie";
            this.Load += new System.EventHandler(this.EvaluatieForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.coneferentieComboBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.conferentieDagComboBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.expertComboBox, 0);
            this.Controls.SetChildIndex(this.evaluatieGroupBox, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.sessieComboBox, 0);
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.Controls.SetChildIndex(this.opslaanButton, 0);
            this.evaluatieGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coneferentieComboBox;
        private System.Windows.Forms.ComboBox conferentieDagComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expertComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vraagEenComboBox;
        private System.Windows.Forms.ComboBox vraagTweeComboBox;
        private System.Windows.Forms.ComboBox vraagDrieComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox opmerkingenRichTextBox;
        private System.Windows.Forms.GroupBox evaluatieGroupBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sessieComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button facebookButton;
        private System.Windows.Forms.Button siteButton;
    }
}
