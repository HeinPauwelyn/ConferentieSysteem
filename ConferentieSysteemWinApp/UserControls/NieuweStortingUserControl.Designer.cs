namespace ConferentieSysteemWinApp.UserControls
{
    partial class NieuweStortingUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.facturenComboBox = new System.Windows.Forms.ComboBox();
            this.totaalBedragLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stortingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.bestemmingLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hoeveelsteStortingLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reedsGestortLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.anulerenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stortingNumericUpDown)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factuur nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Totaal bedrag:";
            // 
            // facturenComboBox
            // 
            this.facturenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facturenComboBox.FormattingEnabled = true;
            this.facturenComboBox.Location = new System.Drawing.Point(156, 3);
            this.facturenComboBox.Name = "facturenComboBox";
            this.facturenComboBox.Size = new System.Drawing.Size(171, 24);
            this.facturenComboBox.TabIndex = 2;
            this.facturenComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedFacturenComboBox);
            // 
            // totaalBedragLabel
            // 
            this.totaalBedragLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totaalBedragLabel.Location = new System.Drawing.Point(146, 37);
            this.totaalBedragLabel.Name = "totaalBedragLabel";
            this.totaalBedragLabel.Size = new System.Drawing.Size(171, 22);
            this.totaalBedragLabel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gestort bedrag:";
            // 
            // stortingNumericUpDown
            // 
            this.stortingNumericUpDown.DecimalPlaces = 2;
            this.stortingNumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.stortingNumericUpDown.Location = new System.Drawing.Point(160, 130);
            this.stortingNumericUpDown.Name = "stortingNumericUpDown";
            this.stortingNumericUpDown.Size = new System.Drawing.Size(157, 23);
            this.stortingNumericUpDown.TabIndex = 5;
            this.stortingNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedStortingNummericUpDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "€";
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.opslaanButton.Location = new System.Drawing.Point(221, 205);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(106, 26);
            this.opslaanButton.TabIndex = 7;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.ClickOpslaanButton);
            // 
            // bestemmingLabel
            // 
            this.bestemmingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bestemmingLabel.Location = new System.Drawing.Point(146, 2);
            this.bestemmingLabel.Name = "bestemmingLabel";
            this.bestemmingLabel.Size = new System.Drawing.Size(171, 22);
            this.bestemmingLabel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bestemming:";
            // 
            // hoeveelsteStortingLabel
            // 
            this.hoeveelsteStortingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hoeveelsteStortingLabel.Location = new System.Drawing.Point(146, 70);
            this.hoeveelsteStortingLabel.Name = "hoeveelsteStortingLabel";
            this.hoeveelsteStortingLabel.Size = new System.Drawing.Size(171, 22);
            this.hoeveelsteStortingLabel.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hoeveelste storting:";
            // 
            // reedsGestortLabel
            // 
            this.reedsGestortLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reedsGestortLabel.Location = new System.Drawing.Point(146, 100);
            this.reedsGestortLabel.Name = "reedsGestortLabel";
            this.reedsGestortLabel.Size = new System.Drawing.Size(171, 22);
            this.reedsGestortLabel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reeds gestort:";
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.reedsGestortLabel);
            this.detailPanel.Controls.Add(this.label6);
            this.detailPanel.Controls.Add(this.hoeveelsteStortingLabel);
            this.detailPanel.Controls.Add(this.label9);
            this.detailPanel.Controls.Add(this.bestemmingLabel);
            this.detailPanel.Controls.Add(this.label7);
            this.detailPanel.Controls.Add(this.label5);
            this.detailPanel.Controls.Add(this.stortingNumericUpDown);
            this.detailPanel.Controls.Add(this.label4);
            this.detailPanel.Controls.Add(this.totaalBedragLabel);
            this.detailPanel.Controls.Add(this.label2);
            this.detailPanel.Location = new System.Drawing.Point(10, 34);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(326, 159);
            this.detailPanel.TabIndex = 14;
            // 
            // anulerenButton
            // 
            this.anulerenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.anulerenButton.Location = new System.Drawing.Point(109, 205);
            this.anulerenButton.Name = "anulerenButton";
            this.anulerenButton.Size = new System.Drawing.Size(106, 26);
            this.anulerenButton.TabIndex = 15;
            this.anulerenButton.Text = "Anuleren";
            this.anulerenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anulerenButton.UseVisualStyleBackColor = true;
            this.anulerenButton.Click += new System.EventHandler(this.ClickAnulerenButton);
            // 
            // NieuweStortingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.anulerenButton);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.facturenComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NieuweStortingUserControl";
            this.Size = new System.Drawing.Size(344, 236);
            ((System.ComponentModel.ISupportInitialize)(this.stortingNumericUpDown)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox facturenComboBox;
        private System.Windows.Forms.Label totaalBedragLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown stortingNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Label bestemmingLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hoeveelsteStortingLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label reedsGestortLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Button anulerenButton;
    }
}
