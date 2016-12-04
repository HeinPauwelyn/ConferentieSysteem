namespace ConferentieSysteemWinApp.UserControls
{
    partial class OverzichtConferentiesUserControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niuewButton = new System.Windows.Forms.Button();
            this.bekijkInschrijvingenButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bewerkenSplitButton1 = new ConferentieSysteemWinApp.UserControls.SplitButton();
            this.overzichtConferentiesItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conferentiesItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bewerkenSplitButton = new ConferentieSysteemWinApp.UserControls.SplitButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bewerk16;
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bewerkenToolStripMenuItem.Text = "Bewerken";
            this.bewerkenToolStripMenuItem.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verxijderen_16;
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.verwijderenToolStripMenuItem_Click);
            // 
            // niuewButton
            // 
            this.niuewButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.niuewButton.Location = new System.Drawing.Point(470, 344);
            this.niuewButton.Name = "niuewButton";
            this.niuewButton.Size = new System.Drawing.Size(133, 27);
            this.niuewButton.TabIndex = 10;
            this.niuewButton.Text = "Nieuw";
            this.niuewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.niuewButton.UseVisualStyleBackColor = true;
            this.niuewButton.Click += new System.EventHandler(this.NieuweConferentie);
            // 
            // bekijkInschrijvingenButton
            // 
            this.bekijkInschrijvingenButton.Enabled = false;
            this.bekijkInschrijvingenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Deelnemer16;
            this.bekijkInschrijvingenButton.Location = new System.Drawing.Point(192, 344);
            this.bekijkInschrijvingenButton.Name = "bekijkInschrijvingenButton";
            this.bekijkInschrijvingenButton.Size = new System.Drawing.Size(133, 27);
            this.bekijkInschrijvingenButton.TabIndex = 12;
            this.bekijkInschrijvingenButton.Text = "Deelnemers";
            this.bekijkInschrijvingenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bekijkInschrijvingenButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.button2.Location = new System.Drawing.Point(321, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Toevoegen";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NieuweConferentie);
            // 
            // splitButton1
            // 
            this.bewerkenSplitButton1.AutoSize = true;
            this.bewerkenSplitButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.bewerkenSplitButton1.Enabled = false;
            this.bewerkenSplitButton1.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bewerk16;
            this.bewerkenSplitButton1.Location = new System.Drawing.Point(465, 347);
            this.bewerkenSplitButton1.Name = "splitButton1";
            this.bewerkenSplitButton1.Size = new System.Drawing.Size(138, 27);
            this.bewerkenSplitButton1.SplitMenuStrip = this.contextMenuStrip1;
            this.bewerkenSplitButton1.TabIndex = 4;
            this.bewerkenSplitButton1.Text = "Bewerken";
            this.bewerkenSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bewerkenSplitButton1.UseVisualStyleBackColor = true;
            this.bewerkenSplitButton1.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // itemListView1
            // 
            this.overzichtConferentiesItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.overzichtConferentiesItemListView.FullRowSelect = true;
            this.overzichtConferentiesItemListView.Location = new System.Drawing.Point(3, 3);
            this.overzichtConferentiesItemListView.MultiSelect = false;
            this.overzichtConferentiesItemListView.Name = "itemListView1";
            this.overzichtConferentiesItemListView.Size = new System.Drawing.Size(600, 338);
            this.overzichtConferentiesItemListView.TabIndex = 1;
            this.overzichtConferentiesItemListView.UseCompatibleStateImageBehavior = false;
            this.overzichtConferentiesItemListView.View = System.Windows.Forms.View.Details;
            this.overzichtConferentiesItemListView.SelectedIndexChanged += new System.EventHandler(this.conferentiesDetailListView_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Conferentie naam";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Voorzitter";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inschrijvings limiet";
            this.columnHeader6.Width = 70;
            // 
            // conferentiesItemListView
            // 
            this.conferentiesItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.conferentiesItemListView.FullRowSelect = true;
            this.conferentiesItemListView.Location = new System.Drawing.Point(3, 3);
            this.conferentiesItemListView.MultiSelect = false;
            this.conferentiesItemListView.Name = "conferentiesItemListView";
            this.conferentiesItemListView.Size = new System.Drawing.Size(600, 335);
            this.conferentiesItemListView.TabIndex = 13;
            this.conferentiesItemListView.UseCompatibleStateImageBehavior = false;
            this.conferentiesItemListView.View = System.Windows.Forms.View.Details;
            //this.conferentiesItemListView.SelectedIndexChanged += new System.EventHandler(this.conferentiesDetailListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Conferentie naam";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voorzitter";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inschrijvings limiet";
            this.columnHeader3.Width = 120;
            // 
            // bewerkenSplitButton
            // 
            this.bewerkenSplitButton.AutoSize = true;
            this.bewerkenSplitButton.ContextMenuStrip = this.contextMenuStrip1;
            this.bewerkenSplitButton.Enabled = false;
            this.bewerkenSplitButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bewerk16;
            this.bewerkenSplitButton.Location = new System.Drawing.Point(331, 344);
            this.bewerkenSplitButton.Name = "bewerkenSplitButton";
            this.bewerkenSplitButton.Size = new System.Drawing.Size(133, 27);
            this.bewerkenSplitButton.SplitMenuStrip = this.contextMenuStrip1;
            this.bewerkenSplitButton.TabIndex = 15;
            this.bewerkenSplitButton.Text = "Bewerken";
            this.bewerkenSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bewerkenSplitButton.UseVisualStyleBackColor = true;
            this.bewerkenSplitButton.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // OverzichtConferentiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bewerkenSplitButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.overzichtConferentiesItemListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OverzichtConferentiesUserControl";
            this.Size = new System.Drawing.Size(618, 385);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ItemListView conferentiesItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button bekijkInschrijvingenButton;
        private System.Windows.Forms.Button niuewButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private SplitButton bewerkenSplitButton;
        private ItemListView overzichtConferentiesItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button2;
        private SplitButton bewerkenSplitButton1;
    }
}
