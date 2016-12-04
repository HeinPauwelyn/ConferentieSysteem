namespace ConferentieSysteemWinApp
{
    partial class NieuwWachtwoordForm
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
            this.codeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.wachtwoordPasswoordTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HerhaalPasswoordTextBox = new ConferentieSysteemWinApp.UserControls.PasswoordTextBox();
            this.volgendeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gebruikersnaamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // codeNumericUpDown
            // 
            this.codeNumericUpDown.Location = new System.Drawing.Point(175, 26);
            this.codeNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.codeNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.codeNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.codeNumericUpDown.Name = "codeNumericUpDown";
            this.codeNumericUpDown.Size = new System.Drawing.Size(160, 23);
            this.codeNumericUpDown.TabIndex = 0;
            this.codeNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            // 
            // wachtwoordPasswoordTextBox
            // 
            this.wachtwoordPasswoordTextBox.Location = new System.Drawing.Point(175, 57);
            this.wachtwoordPasswoordTextBox.MaxLength = 50;
            this.wachtwoordPasswoordTextBox.Name = "wachtwoordPasswoordTextBox";
            this.wachtwoordPasswoordTextBox.Size = new System.Drawing.Size(160, 23);
            this.wachtwoordPasswoordTextBox.TabIndex = 2;
            this.wachtwoordPasswoordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nieuw wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Herhaal wachtwoord:";
            // 
            // HerhaalPasswoordTextBox
            // 
            this.HerhaalPasswoordTextBox.Location = new System.Drawing.Point(175, 86);
            this.HerhaalPasswoordTextBox.MaxLength = 50;
            this.HerhaalPasswoordTextBox.Name = "HerhaalPasswoordTextBox";
            this.HerhaalPasswoordTextBox.Size = new System.Drawing.Size(160, 23);
            this.HerhaalPasswoordTextBox.TabIndex = 4;
            this.HerhaalPasswoordTextBox.UseSystemPasswordChar = true;
            // 
            // volgendeButton
            // 
            this.volgendeButton.Location = new System.Drawing.Point(232, 152);
            this.volgendeButton.Name = "volgendeButton";
            this.volgendeButton.Size = new System.Drawing.Size(103, 26);
            this.volgendeButton.TabIndex = 6;
            this.volgendeButton.Text = "Volgende";
            this.volgendeButton.UseVisualStyleBackColor = true;
            this.volgendeButton.Click += new System.EventHandler(this.WijzigWachtwoord);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gebruikersnaam:";
            // 
            // gebruikersnaamLimietTextBox
            // 
            this.gebruikersnaamLimietTextBox.Location = new System.Drawing.Point(175, 121);
            this.gebruikersnaamLimietTextBox.MaxLength = 50;
            this.gebruikersnaamLimietTextBox.Name = "gebruikersnaamLimietTextBox";
            this.gebruikersnaamLimietTextBox.Size = new System.Drawing.Size(160, 23);
            this.gebruikersnaamLimietTextBox.TabIndex = 8;
            // 
            // NieuwWachtwoordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(354, 196);
            this.Controls.Add(this.gebruikersnaamLimietTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volgendeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HerhaalPasswoordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wachtwoordPasswoordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeNumericUpDown);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NieuwWachtwoordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nieuw wachtwoord (stap 2)";
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown codeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private UserControls.PasswoordTextBox wachtwoordPasswoordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControls.PasswoordTextBox HerhaalPasswoordTextBox;
        private System.Windows.Forms.Button volgendeButton;
        private System.Windows.Forms.Label label4;
        private UserControls.LimietTextBox gebruikersnaamLimietTextBox;
    }
}