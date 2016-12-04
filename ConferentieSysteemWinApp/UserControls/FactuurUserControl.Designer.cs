namespace ConferentieSysteemWinApp.UserControls
{
    partial class FactuurUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.factuurNummerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bedragExclLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bedragInclLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bestandslokatieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.bekijkButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.bestandlsokatieOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuctuur n°:";
            // 
            // factuurNummerLabel
            // 
            this.factuurNummerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.factuurNummerLabel.Location = new System.Drawing.Point(167, 6);
            this.factuurNummerLabel.Name = "factuurNummerLabel";
            this.factuurNummerLabel.Size = new System.Drawing.Size(178, 21);
            this.factuurNummerLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bedrag excl. BTW:";
            // 
            // bedragExclLabel
            // 
            this.bedragExclLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bedragExclLabel.Location = new System.Drawing.Point(167, 44);
            this.bedragExclLabel.Name = "bedragExclLabel";
            this.bedragExclLabel.Size = new System.Drawing.Size(178, 21);
            this.bedragExclLabel.TabIndex = 3;
            this.bedragExclLabel.Text = "€0,00";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(167, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "21%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "BTW percentage:";
            // 
            // bedragInclLabel
            // 
            this.bedragInclLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bedragInclLabel.Location = new System.Drawing.Point(167, 115);
            this.bedragInclLabel.Name = "bedragInclLabel";
            this.bedragInclLabel.Size = new System.Drawing.Size(178, 21);
            this.bedragInclLabel.TabIndex = 7;
            this.bedragInclLabel.Text = "€0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bedrag incl. BTW:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bestandslokatie:";
            // 
            // bestandslokatieRichTextBox
            // 
            this.bestandslokatieRichTextBox.Location = new System.Drawing.Point(167, 148);
            this.bestandslokatieRichTextBox.Multiline = false;
            this.bestandslokatieRichTextBox.Name = "bestandslokatieRichTextBox";
            this.bestandslokatieRichTextBox.ReadOnly = true;
            this.bestandslokatieRichTextBox.Size = new System.Drawing.Size(178, 23);
            this.bestandslokatieRichTextBox.TabIndex = 9;
            this.bestandslokatieRichTextBox.Text = "";
            // 
            // verwijderButton
            // 
            this.verwijderButton.Enabled = false;
            this.verwijderButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verxijderen_16;
            this.verwijderButton.Location = new System.Drawing.Point(192, 241);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(153, 26);
            this.verwijderButton.TabIndex = 12;
            this.verwijderButton.Text = "Verwijderen";
            this.verwijderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // bekijkButton
            // 
            this.bekijkButton.Enabled = false;
            this.bekijkButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bekijken16;
            this.bekijkButton.Location = new System.Drawing.Point(192, 209);
            this.bekijkButton.Name = "bekijkButton";
            this.bekijkButton.Size = new System.Drawing.Size(153, 26);
            this.bekijkButton.TabIndex = 11;
            this.bekijkButton.Text = "Bekijken";
            this.bekijkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bekijkButton.UseVisualStyleBackColor = true;
            this.bekijkButton.Click += new System.EventHandler(this.bekijkButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Upload16;
            this.openFileButton.Location = new System.Drawing.Point(192, 177);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(153, 26);
            this.openFileButton.TabIndex = 10;
            this.openFileButton.Text = "Uploaden";
            this.openFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // bestandlsokatieOpenFileDialog
            // 
            this.bestandlsokatieOpenFileDialog.FileName = "Zoek factuur";
            // 
            // FactuurUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verwijderButton);
            this.Controls.Add(this.bekijkButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.bestandslokatieRichTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bedragInclLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bedragExclLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.factuurNummerLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FactuurUserControl";
            this.Size = new System.Drawing.Size(357, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label factuurNummerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bedragExclLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bedragInclLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox bestandslokatieRichTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button bekijkButton;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.OpenFileDialog bestandlsokatieOpenFileDialog;
    }
}
