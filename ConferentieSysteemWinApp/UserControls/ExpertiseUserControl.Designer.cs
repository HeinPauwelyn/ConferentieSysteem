namespace ConferentieSysteemWinApp.UserControls
{
    partial class ExpertiseUserControl
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
            this.expertiseComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.domeinenListBox = new System.Windows.Forms.ListBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.domeinenComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expertiseComboBox
            // 
            this.expertiseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertiseComboBox.FormattingEnabled = true;
            this.expertiseComboBox.Location = new System.Drawing.Point(90, 0);
            this.expertiseComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.expertiseComboBox.Name = "expertiseComboBox";
            this.expertiseComboBox.Size = new System.Drawing.Size(230, 24);
            this.expertiseComboBox.TabIndex = 59;
            this.expertiseComboBox.SelectedIndexChanged += new System.EventHandler(this.AanvullenDomeinen);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Experise:";
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Enabled = false;
            this.verwijderenButton.Location = new System.Drawing.Point(544, 36);
            this.verwijderenButton.Margin = new System.Windows.Forms.Padding(4);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(41, 24);
            this.verwijderenButton.TabIndex = 56;
            this.verwijderenButton.Text = "-->";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            this.verwijderenButton.Click += new System.EventHandler(this.VerwijderenUitLijst);
            // 
            // domeinenListBox
            // 
            this.domeinenListBox.FormattingEnabled = true;
            this.domeinenListBox.IntegralHeight = false;
            this.domeinenListBox.ItemHeight = 16;
            this.domeinenListBox.Location = new System.Drawing.Point(377, 36);
            this.domeinenListBox.Margin = new System.Windows.Forms.Padding(4);
            this.domeinenListBox.Name = "domeinenListBox";
            this.domeinenListBox.Size = new System.Drawing.Size(159, 143);
            this.domeinenListBox.Sorted = true;
            this.domeinenListBox.TabIndex = 55;
            this.domeinenListBox.SelectedIndexChanged += new System.EventHandler(this.domeinenListBox_SelectedIndexChanged);
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Enabled = false;
            this.toevoegenButton.Location = new System.Drawing.Point(328, 36);
            this.toevoegenButton.Margin = new System.Windows.Forms.Padding(4);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(41, 24);
            this.toevoegenButton.TabIndex = 54;
            this.toevoegenButton.Text = "-->";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenAanLijst);
            // 
            // domeinenComboBox
            // 
            this.domeinenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.domeinenComboBox.FormattingEnabled = true;
            this.domeinenComboBox.Location = new System.Drawing.Point(90, 36);
            this.domeinenComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.domeinenComboBox.Name = "domeinenComboBox";
            this.domeinenComboBox.Size = new System.Drawing.Size(230, 24);
            this.domeinenComboBox.TabIndex = 53;
            this.domeinenComboBox.SelectedIndexChanged += new System.EventHandler(this.domeinenComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Domeinen:";
            // 
            // ExpertiseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expertiseComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.domeinenListBox);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.domeinenComboBox);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpertiseUserControl";
            this.Size = new System.Drawing.Size(588, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox expertiseComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button verwijderenButton;
        private System.Windows.Forms.ListBox domeinenListBox;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.ComboBox domeinenComboBox;
        private System.Windows.Forms.Label label4;
    }
}
