namespace ConferentieSysteemWinApp.UserControls
{
    partial class SessieUserControl
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
            this.eindMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.beginMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expertComboBox = new System.Windows.Forms.ComboBox();
            this.expertiseComboBox = new System.Windows.Forms.ComboBox();
            this.verplaatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eindMaskedTextBox
            // 
            this.eindMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.eindMaskedTextBox.Location = new System.Drawing.Point(54, 82);
            this.eindMaskedTextBox.Mask = "00:00";
            this.eindMaskedTextBox.Name = "eindMaskedTextBox";
            this.eindMaskedTextBox.PromptChar = '-';
            this.eindMaskedTextBox.Size = new System.Drawing.Size(49, 23);
            this.eindMaskedTextBox.TabIndex = 7;
            // 
            // beginMaskedTextBox
            // 
            this.beginMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.beginMaskedTextBox.Location = new System.Drawing.Point(54, 57);
            this.beginMaskedTextBox.Mask = "00:00";
            this.beginMaskedTextBox.Name = "beginMaskedTextBox";
            this.beginMaskedTextBox.PromptChar = '-';
            this.beginMaskedTextBox.Size = new System.Drawing.Size(49, 23);
            this.beginMaskedTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eind:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Begin:";
            // 
            // expertComboBox
            // 
            this.expertComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertComboBox.FormattingEnabled = true;
            this.expertComboBox.Location = new System.Drawing.Point(6, 29);
            this.expertComboBox.Name = "expertComboBox";
            this.expertComboBox.Size = new System.Drawing.Size(149, 24);
            this.expertComboBox.TabIndex = 3;
            // 
            // expertiseComboBox
            // 
            this.expertiseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expertiseComboBox.FormattingEnabled = true;
            this.expertiseComboBox.Location = new System.Drawing.Point(6, 3);
            this.expertiseComboBox.Name = "expertiseComboBox";
            this.expertiseComboBox.Size = new System.Drawing.Size(149, 24);
            this.expertiseComboBox.TabIndex = 8;
            // 
            // verplaatsButton
            // 
            this.verplaatsButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verplaatsen32;
            this.verplaatsButton.Location = new System.Drawing.Point(110, 57);
            this.verplaatsButton.Name = "verplaatsButton";
            this.verplaatsButton.Size = new System.Drawing.Size(45, 48);
            this.verplaatsButton.TabIndex = 9;
            this.verplaatsButton.UseVisualStyleBackColor = true;
            // 
            // SessieUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.verplaatsButton);
            this.Controls.Add(this.expertiseComboBox);
            this.Controls.Add(this.eindMaskedTextBox);
            this.Controls.Add(this.beginMaskedTextBox);
            this.Controls.Add(this.expertComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SessieUserControl";
            this.Size = new System.Drawing.Size(162, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox eindMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox beginMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expertComboBox;
        private System.Windows.Forms.ComboBox expertiseComboBox;
        private System.Windows.Forms.Button verplaatsButton;

    }
}
