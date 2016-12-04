namespace ConferentieSysteemWinApp
{
    partial class BasisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasisForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optiesSplitButton = new ConferentieSysteemWinApp.UserControls.SplitButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instellingenToolStripMenuItem,
            this.toolStripSeparator1,
            this.afmeldenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 54);
            // 
            // instellingenToolStripMenuItem
            // 
            this.instellingenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.AccountInstellingen;
            this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
            this.instellingenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.instellingenToolStripMenuItem.Text = "Instellingen...";
            this.instellingenToolStripMenuItem.Click += new System.EventHandler(this.instellingenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // afmeldenToolStripMenuItem
            // 
            this.afmeldenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.LogOut16;
            this.afmeldenToolStripMenuItem.Name = "afmeldenToolStripMenuItem";
            this.afmeldenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.afmeldenToolStripMenuItem.Text = "Afmelden";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logoPictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.HP;
            this.logoPictureBox.Location = new System.Drawing.Point(616, 343);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(151, 56);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(607, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 399);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // optiesSplitButton
            // 
            this.optiesSplitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optiesSplitButton.AutoSize = true;
            this.optiesSplitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.optiesSplitButton.ContextMenuStrip = this.contextMenuStrip1;
            this.optiesSplitButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Tandwiel32;
            this.optiesSplitButton.Location = new System.Drawing.Point(616, 12);
            this.optiesSplitButton.Name = "optiesSplitButton";
            this.optiesSplitButton.Size = new System.Drawing.Size(151, 45);
            this.optiesSplitButton.SplitMenuStrip = this.contextMenuStrip1;
            this.optiesSplitButton.TabIndex = 0;
            this.optiesSplitButton.Text = "Instellingen";
            this.optiesSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.optiesSplitButton.UseVisualStyleBackColor = false;
            // 
            // BasisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 399);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.optiesSplitButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BasisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BasisForm";
            this.Resize += new System.EventHandler(this.BasisForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConferentieSysteemWinApp.UserControls.SplitButton optiesSplitButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}