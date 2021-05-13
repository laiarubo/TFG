
namespace Biofeedback
{
    partial class Form_FinalitzaEstudi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FinalitzaEstudi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colaborar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botoAccepta = new System.Windows.Forms.Button();
            this.botoCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biofeedback.Properties.Resources.Check_green_icon_petita;
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Les dades de la sessió s\'han desat correctament.";
            // 
            // colaborar
            // 
            this.colaborar.AutoSize = true;
            this.colaborar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaborar.ForeColor = System.Drawing.Color.Black;
            this.colaborar.Location = new System.Drawing.Point(29, 273);
            this.colaborar.Name = "colaborar";
            this.colaborar.Size = new System.Drawing.Size(125, 19);
            this.colaborar.TabIndex = 3;
            this.colaborar.Text = "Sí, vull col·laborar.";
            this.colaborar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 138);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // botoAccepta
            // 
            this.botoAccepta.Location = new System.Drawing.Point(215, 332);
            this.botoAccepta.Name = "botoAccepta";
            this.botoAccepta.Size = new System.Drawing.Size(75, 23);
            this.botoAccepta.TabIndex = 41;
            this.botoAccepta.Text = "Acceptar";
            this.botoAccepta.UseVisualStyleBackColor = true;
            this.botoAccepta.Click += new System.EventHandler(this.botoAccepta_Click);
            // 
            // botoCancelar
            // 
            this.botoCancelar.Location = new System.Drawing.Point(311, 332);
            this.botoCancelar.Name = "botoCancelar";
            this.botoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botoCancelar.TabIndex = 42;
            this.botoCancelar.Text = "Cancel·lar";
            this.botoCancelar.UseVisualStyleBackColor = true;
            this.botoCancelar.Click += new System.EventHandler(this.botoCancelar_Click);
            // 
            // Form_FinalitzaEstudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(602, 393);
            this.Controls.Add(this.botoCancelar);
            this.Controls.Add(this.botoAccepta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colaborar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_FinalitzaEstudi";
            this.Load += new System.EventHandler(this.Form_FinalitzaEstudi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox colaborar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botoAccepta;
        private System.Windows.Forms.Button botoCancelar;
    }
}