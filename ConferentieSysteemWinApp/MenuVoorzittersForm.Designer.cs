namespace ConferentieSysteemWinApp
{
    partial class MenuVoorzittersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVoorzittersForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.wisButton = new System.Windows.Forms.Button();
            this.expertiseToevoegenButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.wisButton);
            this.menuPanel.Controls.Add(this.expertiseToevoegenButton);
            this.menuPanel.Controls.Add(this.button2);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(181, 535);
            this.menuPanel.TabIndex = 10;
            // 
            // wisButton
            // 
            this.wisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wisButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.wisButton.Location = new System.Drawing.Point(12, 498);
            this.wisButton.Name = "wisButton";
            this.wisButton.Size = new System.Drawing.Size(151, 26);
            this.wisButton.TabIndex = 3;
            this.wisButton.Text = "Wissen";
            this.wisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.wisButton.UseVisualStyleBackColor = true;
            this.wisButton.Click += new System.EventHandler(this.Wissen);
            // 
            // button3
            // 
            this.expertiseToevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Expertise32;
            this.expertiseToevoegenButton.Location = new System.Drawing.Point(12, 114);
            this.expertiseToevoegenButton.Name = "button3";
            this.expertiseToevoegenButton.Size = new System.Drawing.Size(151, 45);
            this.expertiseToevoegenButton.TabIndex = 2;
            this.expertiseToevoegenButton.Text = "Expertisen";
            this.expertiseToevoegenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.expertiseToevoegenButton.UseVisualStyleBackColor = true;
            this.expertiseToevoegenButton.Click += new System.EventHandler(this.ToonExpertiseToevoegen);
            // 
            // button2
            // 
            this.button2.Image = global::ConferentieSysteemWinApp.Properties.Resources.Persoon32;
            this.button2.Location = new System.Drawing.Point(12, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Experten";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ToonOverzichtExperten);
            // 
            // button1
            // 
            this.button1.Image = global::ConferentieSysteemWinApp.Properties.Resources.dia;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conferenties";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ToonOverzichtConferenties);
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(181, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(964, 535);
            this.controlPanel.TabIndex = 11;
            // 
            // MenuVoorzittersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1314, 535);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuVoorzittersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Menu voorzitter";
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.Controls.SetChildIndex(this.controlPanel, 0);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button expertiseToevoegenButton;
        private System.Windows.Forms.Button wisButton;

    }
}
