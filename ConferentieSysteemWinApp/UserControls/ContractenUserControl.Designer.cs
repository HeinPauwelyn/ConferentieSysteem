namespace ConferentieSysteemWinApp.UserControls
{
    partial class ContractenUserControl
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
            this.overeenkomstItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.expertLabel = new System.Windows.Forms.Label();
            this.domeinenListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.bekijkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overeenkomstItemListView
            // 
            this.overeenkomstItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.overeenkomstItemListView.FullRowSelect = true;
            this.overeenkomstItemListView.HideSelection = false;
            this.overeenkomstItemListView.Location = new System.Drawing.Point(0, 50);
            this.overeenkomstItemListView.MultiSelect = false;
            this.overeenkomstItemListView.Name = "overeenkomstItemListView";
            this.overeenkomstItemListView.Size = new System.Drawing.Size(206, 197);
            this.overeenkomstItemListView.TabIndex = 0;
            this.overeenkomstItemListView.UseCompatibleStateImageBehavior = false;
            this.overeenkomstItemListView.View = System.Windows.Forms.View.Details;
            this.overeenkomstItemListView.SelectedIndexChanged += new System.EventHandler(this.overeenkomstItemListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BeginDatum";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Einddatum";
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expert:";
            // 
            // expertLabel
            // 
            this.expertLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expertLabel.Location = new System.Drawing.Point(61, 12);
            this.expertLabel.Name = "expertLabel";
            this.expertLabel.Size = new System.Drawing.Size(286, 22);
            this.expertLabel.TabIndex = 2;
            // 
            // domeinenListBox
            // 
            this.domeinenListBox.FormattingEnabled = true;
            this.domeinenListBox.IntegralHeight = false;
            this.domeinenListBox.ItemHeight = 16;
            this.domeinenListBox.Location = new System.Drawing.Point(212, 78);
            this.domeinenListBox.Name = "domeinenListBox";
            this.domeinenListBox.Size = new System.Drawing.Size(141, 169);
            this.domeinenListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domeinen:";
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen;
            this.toevoegenButton.Location = new System.Drawing.Point(368, 165);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(38, 38);
            this.toevoegenButton.TabIndex = 5;
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Enabled = false;
            this.verwijderenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verwijderen1;
            this.verwijderenButton.Location = new System.Drawing.Point(368, 209);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(38, 38);
            this.verwijderenButton.TabIndex = 6;
            this.verwijderenButton.UseVisualStyleBackColor = true;
            // 
            // bekijkButton
            // 
            this.bekijkButton.Enabled = false;
            this.bekijkButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bekijk;
            this.bekijkButton.Location = new System.Drawing.Point(368, 121);
            this.bekijkButton.Name = "bekijkButton";
            this.bekijkButton.Size = new System.Drawing.Size(38, 38);
            this.bekijkButton.TabIndex = 7;
            this.bekijkButton.UseVisualStyleBackColor = true;
            this.bekijkButton.Click += new System.EventHandler(this.bekijkButton_Click);
            // 
            // ContractenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bekijkButton);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domeinenListBox);
            this.Controls.Add(this.expertLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overeenkomstItemListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractenUserControl";
            this.Size = new System.Drawing.Size(409, 249);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ItemListView overeenkomstItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label expertLabel;
        private System.Windows.Forms.ListBox domeinenListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Button verwijderenButton;
        private System.Windows.Forms.Button bekijkButton;
    }
}
