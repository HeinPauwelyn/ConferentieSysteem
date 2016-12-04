namespace ConferentieSysteemWinApp
{
    partial class MenuAdminestratieveMedewerkerForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.factuurButton = new System.Windows.Forms.Button();
            this.betalingenButton = new System.Windows.Forms.Button();
            this.wisButton = new System.Windows.Forms.Button();
            this.InschrijvingenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuPanel.Controls.Add(this.factuurButton);
            this.menuPanel.Controls.Add(this.betalingenButton);
            this.menuPanel.Controls.Add(this.wisButton);
            this.menuPanel.Controls.Add(this.InschrijvingenButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(181, 473);
            this.menuPanel.TabIndex = 11;
            // 
            // factuurButton
            // 
            this.factuurButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Factuur;
            this.factuurButton.Location = new System.Drawing.Point(12, 63);
            this.factuurButton.Name = "factuurButton";
            this.factuurButton.Size = new System.Drawing.Size(151, 45);
            this.factuurButton.TabIndex = 5;
            this.factuurButton.Text = "Facturen";
            this.factuurButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.factuurButton.UseVisualStyleBackColor = true;
            this.factuurButton.Click += new System.EventHandler(this.ToonFactuur);
            // 
            // betalingenButton
            // 
            this.betalingenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Betalingen;
            this.betalingenButton.Location = new System.Drawing.Point(12, 114);
            this.betalingenButton.Name = "betalingenButton";
            this.betalingenButton.Size = new System.Drawing.Size(151, 45);
            this.betalingenButton.TabIndex = 4;
            this.betalingenButton.Text = "Betalingen";
            this.betalingenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.betalingenButton.UseVisualStyleBackColor = true;
            this.betalingenButton.Click += new System.EventHandler(this.betalingenButton_Click);
            // 
            // wisButton
            // 
            this.wisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wisButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.wisButton.Location = new System.Drawing.Point(12, 436);
            this.wisButton.Name = "wisButton";
            this.wisButton.Size = new System.Drawing.Size(151, 26);
            this.wisButton.TabIndex = 3;
            this.wisButton.Text = "Wissen";
            this.wisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.wisButton.UseVisualStyleBackColor = true;
            // 
            // InschrijvingenButton
            // 
            this.InschrijvingenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Inschrijvignen32;
            this.InschrijvingenButton.Location = new System.Drawing.Point(12, 12);
            this.InschrijvingenButton.Name = "InschrijvingenButton";
            this.InschrijvingenButton.Size = new System.Drawing.Size(151, 45);
            this.InschrijvingenButton.TabIndex = 0;
            this.InschrijvingenButton.Text = "Inschrijvingen";
            this.InschrijvingenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InschrijvingenButton.UseVisualStyleBackColor = true;
            this.InschrijvingenButton.Click += new System.EventHandler(this.ToonOverzichtInschrijvingen);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(181, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 473);
            this.panel1.TabIndex = 12;
            // 
            // MenuAdminestratieveMedewerkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1032, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Name = "MenuAdminestratieveMedewerkerForm";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button wisButton;
        private System.Windows.Forms.Button InschrijvingenButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button betalingenButton;
        private System.Windows.Forms.Button factuurButton;
    }
}
