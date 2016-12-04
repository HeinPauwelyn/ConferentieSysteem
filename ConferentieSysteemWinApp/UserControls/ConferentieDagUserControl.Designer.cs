namespace ConferentieSysteemWinApp.UserControls
{
    partial class ConferentieDagUserControl
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
            this.sessiesPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sessiesPanel
            // 
            this.sessiesPanel.AllowDrop = true;
            this.sessiesPanel.AutoScroll = true;
            this.sessiesPanel.Location = new System.Drawing.Point(-1, 27);
            this.sessiesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sessiesPanel.Name = "sessiesPanel";
            this.sessiesPanel.Size = new System.Drawing.Size(200, 330);
            this.sessiesPanel.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, -1);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.toevoegenButton.Location = new System.Drawing.Point(166, 363);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(33, 24);
            this.toevoegenButton.TabIndex = 2;
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButtonClick);
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Minus16;
            this.verwijderenButton.Location = new System.Drawing.Point(127, 363);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(33, 24);
            this.verwijderenButton.TabIndex = 3;
            this.verwijderenButton.Text = "\r\n";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            this.verwijderenButton.Click += new System.EventHandler(this.VerwijderenButtonClick);
            // 
            // ConferentieDagUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sessiesPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConferentieDagUserControl";
            this.Size = new System.Drawing.Size(200, 390);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sessiesPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Button verwijderenButton;
    }
}
