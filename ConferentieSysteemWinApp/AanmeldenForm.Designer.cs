namespace ConferentieSysteemWinApp
{
    partial class AanmeldenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AanmeldenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.verbergButton = new System.Windows.Forms.Button();
            this.info2PictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.info1PictureBox = new System.Windows.Forms.PictureBox();
            this.verzendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gebruikersnaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.nieuwWachtwoordButton = new System.Windows.Forms.Button();
            this.aanmeldenButton = new System.Windows.Forms.Button();
            this.aanmeldenProsesBar = new ConferentieSysteemWinApp.UserControls.ProsesBar();
            this.progressPictureBox = new ConferentieSysteemWinApp.UserControls.ProsesBar();
            this.passwoordEmailTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.wachtwoordpasswoordTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailLimietTextBox);
            this.groupBox1.Controls.Add(this.verbergButton);
            this.groupBox1.Controls.Add(this.progressPictureBox);
            this.groupBox1.Controls.Add(this.info2PictureBox);
            this.groupBox1.Controls.Add(this.passwoordEmailTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.info1PictureBox);
            this.groupBox1.Controls.Add(this.verzendButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 197);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuw wachtwoord verzenden (stap 1)";
            // 
            // emailLimietTextBox
            // 
            this.emailLimietTextBox.Location = new System.Drawing.Point(97, 24);
            this.emailLimietTextBox.MaxLength = 50;
            this.emailLimietTextBox.Name = "emailLimietTextBox";
            this.emailLimietTextBox.Size = new System.Drawing.Size(227, 23);
            this.emailLimietTextBox.TabIndex = 14;
            // 
            // verbergButton
            // 
            this.verbergButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verberg16;
            this.verbergButton.Location = new System.Drawing.Point(121, 93);
            this.verbergButton.Margin = new System.Windows.Forms.Padding(4);
            this.verbergButton.Name = "verbergButton";
            this.verbergButton.Size = new System.Drawing.Size(115, 26);
            this.verbergButton.TabIndex = 8;
            this.verbergButton.Text = "Verberg";
            this.verbergButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.verbergButton.UseVisualStyleBackColor = true;
            this.verbergButton.Click += new System.EventHandler(this.verbergButton_Click);
            // 
            // info2PictureBox
            // 
            this.info2PictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Kleine_help;
            this.info2PictureBox.Location = new System.Drawing.Point(330, 63);
            this.info2PictureBox.Name = "info2PictureBox";
            this.info2PictureBox.Size = new System.Drawing.Size(29, 23);
            this.info2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info2PictureBox.TabIndex = 13;
            this.info2PictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wachtwoord\r\ne-mail adres:";
            // 
            // info1PictureBox
            // 
            this.info1PictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Kleine_help;
            this.info1PictureBox.Location = new System.Drawing.Point(330, 22);
            this.info1PictureBox.Name = "info1PictureBox";
            this.info1PictureBox.Size = new System.Drawing.Size(29, 23);
            this.info1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info1PictureBox.TabIndex = 11;
            this.info1PictureBox.TabStop = false;
            // 
            // verzendButton
            // 
            this.verzendButton.Enabled = false;
            this.verzendButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Zend16;
            this.verzendButton.Location = new System.Drawing.Point(244, 93);
            this.verzendButton.Margin = new System.Windows.Forms.Padding(4);
            this.verzendButton.Name = "verzendButton";
            this.verzendButton.Size = new System.Drawing.Size(115, 26);
            this.verzendButton.TabIndex = 7;
            this.verzendButton.Text = "Verzend";
            this.verzendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.verzendButton.UseVisualStyleBackColor = true;
            this.verzendButton.Click += new System.EventHandler(this.verzendButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(398, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 393);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::ConferentieSysteemWinApp.Properties.Resources.HP;
            this.pictureBox1.Location = new System.Drawing.Point(0, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gebruikersnaamLimietTextBox
            // 
            this.gebruikersnaamLimietTextBox.Location = new System.Drawing.Point(151, 16);
            this.gebruikersnaamLimietTextBox.MaxLength = 50;
            this.gebruikersnaamLimietTextBox.Name = "gebruikersnaamLimietTextBox";
            this.gebruikersnaamLimietTextBox.Size = new System.Drawing.Size(224, 23);
            this.gebruikersnaamLimietTextBox.TabIndex = 1;
            this.gebruikersnaamLimietTextBox.TextChanged += new System.EventHandler(this.enableAanmeldButton);
            this.gebruikersnaamLimietTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AameldenEnter);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Location = new System.Drawing.Point(0, 162);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(392, 231);
            this.controlPanel.TabIndex = 12;
            // 
            // nieuwWachtwoordButton
            // 
            this.nieuwWachtwoordButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Sleutel16;
            this.nieuwWachtwoordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nieuwWachtwoordButton.Location = new System.Drawing.Point(192, 118);
            this.nieuwWachtwoordButton.Margin = new System.Windows.Forms.Padding(4);
            this.nieuwWachtwoordButton.Name = "nieuwWachtwoordButton";
            this.nieuwWachtwoordButton.Size = new System.Drawing.Size(183, 26);
            this.nieuwWachtwoordButton.TabIndex = 4;
            this.nieuwWachtwoordButton.Text = "Wachtwoord vergeten";
            this.nieuwWachtwoordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.nieuwWachtwoordButton.UseVisualStyleBackColor = true;
            this.nieuwWachtwoordButton.Click += new System.EventHandler(this.nieuwWachtwoordButton_Click);
            // 
            // aanmeldenButton
            // 
            this.aanmeldenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aanmeldenButton.Enabled = false;
            this.aanmeldenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.LogIn16;
            this.aanmeldenButton.Location = new System.Drawing.Point(257, 84);
            this.aanmeldenButton.Margin = new System.Windows.Forms.Padding(4);
            this.aanmeldenButton.Name = "aanmeldenButton";
            this.aanmeldenButton.Size = new System.Drawing.Size(118, 26);
            this.aanmeldenButton.TabIndex = 3;
            this.aanmeldenButton.Text = "Aanmelden";
            this.aanmeldenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aanmeldenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.aanmeldenButton.UseMnemonic = false;
            this.aanmeldenButton.UseVisualStyleBackColor = true;
            this.aanmeldenButton.Click += new System.EventHandler(this.AanmeldenKnop);
            // 
            // aanmeldenProsesBar
            // 
            this.aanmeldenProsesBar.Location = new System.Drawing.Point(151, 84);
            this.aanmeldenProsesBar.Margin = new System.Windows.Forms.Padding(5);
            this.aanmeldenProsesBar.Name = "aanmeldenProsesBar";
            this.aanmeldenProsesBar.Size = new System.Drawing.Size(98, 26);
            this.aanmeldenProsesBar.TabIndex = 15;
            this.aanmeldenProsesBar.Visible = false;
            // 
            // progressPictureBox
            // 
            this.progressPictureBox.Location = new System.Drawing.Point(121, 127);
            this.progressPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.progressPictureBox.Name = "progressPictureBox";
            this.progressPictureBox.Size = new System.Drawing.Size(238, 26);
            this.progressPictureBox.TabIndex = 12;
            this.progressPictureBox.Visible = false;
            // 
            // passwoordEmailTextBox
            // 
            this.passwoordEmailTextBox.Location = new System.Drawing.Point(97, 63);
            this.passwoordEmailTextBox.MaxLength = 50;
            this.passwoordEmailTextBox.Name = "passwoordEmailTextBox";
            this.passwoordEmailTextBox.Size = new System.Drawing.Size(227, 23);
            this.passwoordEmailTextBox.TabIndex = 6;
            this.passwoordEmailTextBox.UseSystemPasswordChar = true;
            this.passwoordEmailTextBox.TextChanged += new System.EventHandler(this.enabelVerzendKnop);
            // 
            // wachtwoordpasswoordTextBox
            // 
            this.wachtwoordpasswoordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.wachtwoordpasswoordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wachtwoordpasswoordTextBox.Location = new System.Drawing.Point(151, 54);
            this.wachtwoordpasswoordTextBox.MaxLength = 50;
            this.wachtwoordpasswoordTextBox.Name = "wachtwoordpasswoordTextBox";
            this.wachtwoordpasswoordTextBox.Size = new System.Drawing.Size(224, 23);
            this.wachtwoordpasswoordTextBox.TabIndex = 2;
            this.wachtwoordpasswoordTextBox.UseSystemPasswordChar = true;
            this.wachtwoordpasswoordTextBox.TextChanged += new System.EventHandler(this.enableAanmeldButton);
            this.wachtwoordpasswoordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AameldenEnter);
            // 
            // AanmeldenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(526, 393);
            this.Controls.Add(this.aanmeldenProsesBar);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nieuwWachtwoordButton);
            this.Controls.Add(this.wachtwoordpasswoordTextBox);
            this.Controls.Add(this.gebruikersnaamLimietTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aanmeldenButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AanmeldenForm";
            this.Text = "Aanmelden";
            this.Load += new System.EventHandler(this.AanmeldenForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aanmeldenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ConferentieSysteemWinApp.UserControls.LimietTextBox gebruikersnaamLimietTextBox;
        private System.Windows.Forms.Button nieuwWachtwoordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verzendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button verbergButton;
        private System.Windows.Forms.PictureBox info1PictureBox;
        private System.Windows.Forms.PictureBox info2PictureBox;
        private ConferentieSysteemWinApp.UserControls.PasswoordTextBox passwoordEmailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.ProsesBar progressPictureBox;
        private UserControls.PasswoordTextBox wachtwoordpasswoordTextBox;
        private UserControls.LimietTextBox emailLimietTextBox;
        private System.Windows.Forms.Panel controlPanel;
        private UserControls.ProsesBar aanmeldenProsesBar;
    }
}