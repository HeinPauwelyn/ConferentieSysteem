namespace ConferentieSysteemWinApp.UserControls
{
    partial class OverzichtInschrijvingenUserControl
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
            this.detailsButton = new System.Windows.Forms.Button();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.inschrijvingenItemListVieuw1 = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inschrijvingenItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toevoegenButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detailsButton
            // 
            this.detailsButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Volgend;
            this.detailsButton.Location = new System.Drawing.Point(494, 350);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(125, 25);
            this.detailsButton.TabIndex = 19;
            this.detailsButton.Text = "Details";
            this.detailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.detailsButton.UseVisualStyleBackColor = true;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.toevoegenButton.Location = new System.Drawing.Point(363, 350);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(125, 25);
            this.toevoegenButton.TabIndex = 17;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inschrijvingenItemListVieuw1
            // 
            this.inschrijvingenItemListVieuw1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.inschrijvingenItemListVieuw1.FullRowSelect = true;
            this.inschrijvingenItemListVieuw1.Location = new System.Drawing.Point(3, 0);
            this.inschrijvingenItemListVieuw1.MultiSelect = false;
            this.inschrijvingenItemListVieuw1.Name = "inschrijvingenItemListVieuw1";
            this.inschrijvingenItemListVieuw1.Size = new System.Drawing.Size(616, 344);
            this.inschrijvingenItemListVieuw1.TabIndex = 20;
            this.inschrijvingenItemListVieuw1.UseCompatibleStateImageBehavior = false;
            this.inschrijvingenItemListVieuw1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Naam";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Conferentie";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aantal dagen";
            this.columnHeader5.Width = 100;
            // 
            // inschrijvingenItemListView
            // 
            this.inschrijvingenItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.columnHeader1,
            this.columnHeader2});
            this.inschrijvingenItemListView.FullRowSelect = true;
            this.inschrijvingenItemListView.Location = new System.Drawing.Point(3, 3);
            this.inschrijvingenItemListView.MultiSelect = false;
            this.inschrijvingenItemListView.Name = "inschrijvingenItemListView";
            this.inschrijvingenItemListView.Size = new System.Drawing.Size(616, 341);
            this.inschrijvingenItemListView.TabIndex = 18;
            this.inschrijvingenItemListView.UseCompatibleStateImageBehavior = false;
            this.inschrijvingenItemListView.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Conferentie";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal dagen";
            this.columnHeader2.Width = 110;
            // 
            // toevoegenButton1
            // 
            this.toevoegenButton1.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.toevoegenButton1.Location = new System.Drawing.Point(363, 350);
            this.toevoegenButton1.Name = "toevoegenButton1";
            this.toevoegenButton1.Size = new System.Drawing.Size(125, 25);
            this.toevoegenButton1.TabIndex = 21;
            this.toevoegenButton1.Text = "Toevoegen";
            this.toevoegenButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toevoegenButton1.UseVisualStyleBackColor = true;
            this.toevoegenButton1.Click += new System.EventHandler(this.InschrijvingToevoegen);
            // 
            // OverzichtInschrijvingenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toevoegenButton1);
            this.Controls.Add(this.inschrijvingenItemListVieuw1);
            this.Controls.Add(this.detailsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OverzichtInschrijvingenUserControl";
            this.Size = new System.Drawing.Size(626, 382);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button detailsButton;
        private ItemListView inschrijvingenItemListView;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button toevoegenButton;
        private ItemListView inschrijvingenItemListVieuw1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button toevoegenButton1;

    }
}
