
namespace Biofeedback
{
    partial class Form_CalEstudiIniciatAbansReproduccio
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
            this.botoAcceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botoAcceptar
            // 
            this.botoAcceptar.Location = new System.Drawing.Point(206, 98);
            this.botoAcceptar.Name = "botoAcceptar";
            this.botoAcceptar.Size = new System.Drawing.Size(75, 23);
            this.botoAcceptar.TabIndex = 5;
            this.botoAcceptar.Text = "Acceptar";
            this.botoAcceptar.UseVisualStyleBackColor = true;
            this.botoAcceptar.Click += new System.EventHandler(this.botoAcceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biofeedback.Properties.Resources.error_ezgif_petita1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cal que s\'iniciï l\'estudi per poder reproduir l\'estímul";
            // 
            // Form_CalEstudiIniciatAbansReproduccio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 160);
            this.Controls.Add(this.botoAcceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_CalEstudiIniciatAbansReproduccio";
            this.Text = "Form_CalEstudiIniciatAbansReproduccio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoAcceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}