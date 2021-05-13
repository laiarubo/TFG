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
            this.lecturaCardio = new System.Windows.Forms.Label();
            this.lecturaMio = new System.Windows.Forms.Label();
            this.lecturaRG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_cor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsMediaPlayer2
            // 
            this.WindowsMediaPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowsMediaPlayer2.Enabled = true;
            this.WindowsMediaPlayer2.Location = new System.Drawing.Point(3, 2);
            this.WindowsMediaPlayer2.Name = "WindowsMediaPlayer2";
            this.WindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer2.OcxState")));
            this.WindowsMediaPlayer2.Size = new System.Drawing.Size(999, 563);
            this.WindowsMediaPlayer2.TabIndex = 9;
            this.WindowsMediaPlayer2.Enter += new System.EventHandler(this.WindowsMediaPlayer2_Enter);
            // 
            // lecturaCardio
            // 
            this.lecturaCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaCardio.ForeColor = System.Drawing.Color.White;
            this.lecturaCardio.Location = new System.Drawing.Point(259, 628);
            this.lecturaCardio.Name = "lecturaCardio";
            this.lecturaCardio.Size = new System.Drawing.Size(162, 35);
            this.lecturaCardio.TabIndex = 21;
            this.lecturaCardio.Text = "lecturaCardio";
            this.lecturaCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturaMio
            // 
            this.lecturaMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaMio.ForeColor = System.Drawing.Color.White;
            this.lecturaMio.Location = new System.Drawing.Point(427, 629);
            this.lecturaMio.Name = "lecturaMio";
            this.lecturaMio.Size = new System.Drawing.Size(144, 35);
            this.lecturaMio.TabIndex = 22;
            this.lecturaMio.Text = "lecturaMio";
            this.lecturaMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturaRG
            // 
            this.lecturaRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaRG.ForeColor = System.Drawing.Color.White;
            this.lecturaRG.Location = new System.Drawing.Point(586, 629);
            this.lecturaRG.Name = "lecturaRG";
            this.lecturaRG.Size = new System.Drawing.Size(144, 35);
            this.lecturaRG.TabIndex = 23;
            this.lecturaRG.Text = "lecturaRG";
            this.lecturaRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = global::Biofeedback.Properties.Resources.sudoracio;
            this.label2.Location = new System.Drawing.Point(618, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 63);
            this.label2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Image = global::Biofeedback.Properties.Resources.tensioMuscular;
            this.label1.Location = new System.Drawing.Point(465, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 57);
            this.label1.TabIndex = 25;
            // 
            // img_cor
            // 
            this.img_cor.Image = global::Biofeedback.Properties.Resources.corVermell;
            this.img_cor.Location = new System.Drawing.Point(287, 565);
            this.img_cor.Name = "img_cor";
            this.img_cor.Size = new System.Drawing.Size(96, 63);
            this.img_cor.TabIndex = 24;
            this.img_cor.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1003, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_cor);
            this.Controls.Add(this.lecturaRG);
            this.Controls.Add(this.lecturaMio);
            this.Controls.Add(this.lecturaCardio);
            this.Controls.Add(this.WindowsMediaPlayer2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer2;
        private System.Windows.Forms.Label lecturaCardio;
        private System.Windows.Forms.Label lecturaMio;
        private System.Windows.Forms.Label lecturaRG;
        private System.Windows.Forms.Label img_cor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}