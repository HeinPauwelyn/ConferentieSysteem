namespace ConferentieSysteemWinApp
{
    partial class PersoonZoekenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersoonZoekenForm));
            this.resultatenItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.functieLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.achternaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.voornaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultatenItemListView
            // 
            this.resultatenItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader6});
            this.resultatenItemListView.FullRowSelect = true;
            this.resultatenItemListView.Location = new System.Drawing.Point(12, 138);
            this.resultatenItemListView.MultiSelect = false;
            this.resultatenItemListView.Name = "resultatenItemListView";
            this.resultatenItemListView.Size = new System.Drawing.Size(626, 226);
            this.resultatenItemListView.TabIndex = 6;
            this.resultatenItemListView.UseCompatibleStateImageBehavior = false;
            this.resultatenItemListView.View = System.Windows.Forms.View.Details;
            this.resultatenItemListView.DoubleClick += new System.EventHandler(this.resultatenItemListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Voornaam";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Achternaam";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Straat";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nr.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gemeente";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Provincie";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Telefoon";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Gsm";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Email";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bedrijf";
            this.columnHeader6.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.functieLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.achternaamLimietTextBox);
            this.groupBox1.Controls.Add(this.voornaamLimietTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(169, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoek criteria";
            // 
            // functieLabel
            // 
            this.functieLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.functieLabel.Location = new System.Drawing.Point(119, 86);
            this.functieLabel.Name = "functieLabel";
            this.functieLabel.Size = new System.Drawing.Size(180, 23);
            this.functieLabel.TabIndex = 5;
            this.functieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Functie:";
            // 
            // achternaamLimietTextBox
            // 
            this.achternaamLimietTextBox.Location = new System.Drawing.Point(119, 57);
            this.achternaamLimietTextBox.MaxLength = 50;
            this.achternaamLimietTextBox.Name = "achternaamLimietTextBox";
            this.achternaamLimietTextBox.Size = new System.Drawing.Size(180, 23);
            this.achternaamLimietTextBox.TabIndex = 3;
            this.achternaamLimietTextBox.TextChanged += new System.EventHandler(this.ZoekenPersoon);
            // 
            // voornaamLimietTextBox
            // 
            this.voornaamLimietTextBox.Location = new System.Drawing.Point(119, 26);
            this.voornaamLimietTextBox.MaxLength = 50;
            this.voornaamLimietTextBox.Name = "voornaamLimietTextBox";
            this.voornaamLimietTextBox.Size = new System.Drawing.Size(180, 23);
            this.voornaamLimietTextBox.TabIndex = 2;
            this.voornaamLimietTextBox.TextChanged += new System.EventHandler(this.ZoekenPersoon);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dubbelklik voor in te voegen.";
            // 
            // PersoonZoekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultatenItemListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersoonZoekenForm";
            this.Text = "Persoon zoeken";
            this.Load += new System.EventHandler(this.PersoonZoekenForm_Load);
            this.Controls.SetChildIndex(this.resultatenItemListView, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ItemListView resultatenItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.LimietTextBox achternaamLimietTextBox;
        private UserControls.LimietTextBox voornaamLimietTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label functieLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
