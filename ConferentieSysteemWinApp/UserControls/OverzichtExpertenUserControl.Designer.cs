namespace ConferentieSysteemWinApp.UserControls
{
    partial class OverzichtExpertenUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.anulerenButton = new System.Windows.Forms.Button();
            this.detailsPersoonBedrijfUserControl = new ConferentieSysteemWinApp.UserControls.PersoonBedrijfUserControl();
            this.contractenUserControl1 = new ConferentieSysteemWinApp.UserControls.ContractenUserControl();
            this.expertenItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(1008, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.detailsPersoonBedrijfUserControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contact gegevens";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contractenUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contracten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(632, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Evaluaties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.toevoegenButton.Location = new System.Drawing.Point(343, 353);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(127, 26);
            this.toevoegenButton.TabIndex = 3;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Enabled = false;
            this.detailsButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Volgend;
            this.detailsButton.Location = new System.Drawing.Point(476, 353);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(127, 26);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // anulerenButton
            // 
            this.anulerenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.anulerenButton.Location = new System.Drawing.Point(210, 353);
            this.anulerenButton.Name = "anulerenButton";
            this.anulerenButton.Size = new System.Drawing.Size(127, 26);
            this.anulerenButton.TabIndex = 4;
            this.anulerenButton.Text = "Anuleren";
            this.anulerenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anulerenButton.UseVisualStyleBackColor = true;
            this.anulerenButton.Visible = false;
            this.anulerenButton.Click += new System.EventHandler(this.anulerenButton_Click);
            // 
            // detailsPersoonBedrijfUserControl
            // 
            this.detailsPersoonBedrijfUserControl.AangeslotenBijBedrijf = true;
            this.detailsPersoonBedrijfUserControl.Achternaam = "";
            this.detailsPersoonBedrijfUserControl.AutoSize = true;
            this.detailsPersoonBedrijfUserControl.BedrijfEmail = "";
            this.detailsPersoonBedrijfUserControl.BedrijfGemeente = null;
            this.detailsPersoonBedrijfUserControl.BedrijfGsmNr = "    /   .";
            this.detailsPersoonBedrijfUserControl.BedrijfHuisnummer = "";
            this.detailsPersoonBedrijfUserControl.Bedrijfsnaam = "";
            this.detailsPersoonBedrijfUserControl.BedrijfStraat = "";
            this.detailsPersoonBedrijfUserControl.BedrijfTelefoonNr = "   /  .  .";
            this.detailsPersoonBedrijfUserControl.BTWNummer = "BE   .    .";
            this.detailsPersoonBedrijfUserControl.Email = "";
            this.detailsPersoonBedrijfUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsPersoonBedrijfUserControl.Gebruikersnaam = "";
            this.detailsPersoonBedrijfUserControl.Gemeente = null;
            this.detailsPersoonBedrijfUserControl.GsmNr = "    /   .";
            this.detailsPersoonBedrijfUserControl.Huisnummer = "";
            this.detailsPersoonBedrijfUserControl.Location = new System.Drawing.Point(7, 8);
            this.detailsPersoonBedrijfUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsPersoonBedrijfUserControl.Name = "detailsPersoonBedrijfUserControl";
            this.detailsPersoonBedrijfUserControl.Size = new System.Drawing.Size(593, 828);
            this.detailsPersoonBedrijfUserControl.Straat = "";
            this.detailsPersoonBedrijfUserControl.TabIndex = 0;
            this.detailsPersoonBedrijfUserControl.TelefoonNr = "   /  .  .";
            this.detailsPersoonBedrijfUserControl.Voornaam = "";
            this.detailsPersoonBedrijfUserControl.Wachtwoord = "";
            // 
            // contractenUserControl1
            // 
            this.contractenUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractenUserControl1.Location = new System.Drawing.Point(7, 16);
            this.contractenUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.contractenUserControl1.Name = "contractenUserControl1";
            this.contractenUserControl1.Size = new System.Drawing.Size(409, 249);
            this.contractenUserControl1.TabIndex = 0;
            // 
            // expertenItemListView
            // 
            this.expertenItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.expertenItemListView.FullRowSelect = true;
            this.expertenItemListView.HideSelection = false;
            this.expertenItemListView.Location = new System.Drawing.Point(3, 3);
            this.expertenItemListView.MultiSelect = false;
            this.expertenItemListView.Name = "expertenItemListView";
            this.expertenItemListView.Size = new System.Drawing.Size(600, 344);
            this.expertenItemListView.TabIndex = 0;
            this.expertenItemListView.UseCompatibleStateImageBehavior = false;
            this.expertenItemListView.View = System.Windows.Forms.View.Details;
            this.expertenItemListView.SelectedIndexChanged += new System.EventHandler(this.itemListView1_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Bedrijfsnaam";
            this.columnHeader3.Width = 150;
            // 
            // OverzichtExpertenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anulerenButton);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.expertenItemListView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OverzichtExpertenUserControl";
            this.Size = new System.Drawing.Size(1694, 382);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ItemListView expertenItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PersoonBedrijfUserControl detailsPersoonBedrijfUserControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ContractenUserControl contractenUserControl1;
        private System.Windows.Forms.Button anulerenButton;
    }
}
