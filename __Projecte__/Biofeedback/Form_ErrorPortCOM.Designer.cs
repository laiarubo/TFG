
namespace Biofeedback
{
    partial class Form_ErrorPortCOM
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
            this.MissatgeError = new System.Windows.Forms.Label();
            this.botoAcceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MissatgeError
            // 
            this.MissatgeError.AutoSize = true;
            this.MissatgeError.Location = new System.Drawing.Point(66, 63);
            this.MissatgeError.Name = "MissatgeError";
            this.MissatgeError.Size = new System.Drawing.Size(220, 13);
            this.MissatgeError.TabIndex = 0;
            this.MissatgeError.Text = "Si us plau, connecti el dispositiu a l\'ordinador.";
            this.MissatgeError.Click += new System.EventHandler(this.MissatgeError_Click);
            // 
            // botoAcceptar
            // 
            this.botoAcceptar.Location = new System.Drawing.Point(133, 103);
            this.botoAcceptar.Name = "botoAcceptar";
            this.botoAcceptar.Size = new System.Drawing.Size(75, 23);
            this.botoAcceptar.TabIndex = 1;
            this.botoAcceptar.Text = "Acceptar";
            this.botoAcceptar.UseVisualStyleBackColor = true;
            this.botoAcceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biofeedback.Properties.Resources.error_ezgif_petita;
            this.pictureBox1.Location = new System.Drawing.Point(15, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ErrorPortCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 154);
            this.Controls.Add(this.MissatgeError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botoAcceptar);
            this.Name = "Form_ErrorPortCOM";
            this.Text = "Form_ErrorPortCOM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MissatgeError;
        private System.Windows.Forms.Button botoAcceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}