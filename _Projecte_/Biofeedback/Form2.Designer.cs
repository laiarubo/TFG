namespace Biofeedback
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.WindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsMediaPlayer2
            // 
            this.WindowsMediaPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer2.Enabled = true;
            this.WindowsMediaPlayer2.Location = new System.Drawing.Point(0, 0);
            this.WindowsMediaPlayer2.Name = "WindowsMediaPlayer2";
            this.WindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer2.OcxState")));
            this.WindowsMediaPlayer2.Size = new System.Drawing.Size(904, 541);
            this.WindowsMediaPlayer2.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 541);
            this.Controls.Add(this.WindowsMediaPlayer2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer2;
    }
}