namespace ConferentieSysteemWinApp.UserControls
{
    partial class ControleUserControl
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
            this.checkPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkPictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Kruis;
            this.checkPictureBox.Location = new System.Drawing.Point(0, 0);
            this.checkPictureBox.Name = "checkPictureBox";
            this.checkPictureBox.Size = new System.Drawing.Size(35, 32);
            this.checkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPictureBox.TabIndex = 0;
            this.checkPictureBox.TabStop = false;
            this.checkPictureBox.MouseLeave += new System.EventHandler(this.ControleUserControl_MouseLeave);
            this.checkPictureBox.MouseHover += new System.EventHandler(this.ControleUserControl_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseLeave += new System.EventHandler(this.ControleUserControl_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.ControleUserControl_MouseHover);
            // 
            // ControleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkPictureBox);
            this.Name = "ControleUserControl";
            this.Size = new System.Drawing.Size(165, 32);
            this.MouseLeave += new System.EventHandler(this.ControleUserControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ControleUserControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox checkPictureBox;
        private System.Windows.Forms.Label label1;
    }
}
