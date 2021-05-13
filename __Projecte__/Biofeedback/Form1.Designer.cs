namespace Biofeedback
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer_sessio = new System.Windows.Forms.Timer(this.components);
            this.timer_estimul = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NotesTerapeuta = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.rutaFitxer = new System.Windows.Forms.TextBox();
            this.botoCercaVideo = new System.Windows.Forms.Button();
            this.botoPlayVideo = new System.Windows.Forms.Button();
            this.botoAturaVideo = new System.Windows.Forms.Button();
            this.QuadernBitacoles_richTextBox = new System.Windows.Forms.RichTextBox();
            this.BotoEnvia = new System.Windows.Forms.Button();
            this.minutsSessio = new System.Windows.Forms.Label();
            this.simbolTempsSessio = new System.Windows.Forms.Label();
            this.segonsSessio = new System.Windows.Forms.Label();
            this.duradaSessioTitol = new System.Windows.Forms.Label();
            this.grafiques_UserControl1 = new Biofeedback.UserControl_Grafiques();
            this.boto_CanviarMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer_sessio
            // 
            this.timer_sessio.Tick += new System.EventHandler(this.timer_sessio_Tick);
            // 
            // timer_estimul
            // 
            this.timer_estimul.Tick += new System.EventHandler(this.timer_estimul_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // NotesTerapeuta
            // 
            this.NotesTerapeuta.BackColor = System.Drawing.Color.White;
            this.NotesTerapeuta.Location = new System.Drawing.Point(77, 907);
            this.NotesTerapeuta.Name = "NotesTerapeuta";
            this.NotesTerapeuta.Size = new System.Drawing.Size(464, 20);
            this.NotesTerapeuta.TabIndex = 3;
            this.NotesTerapeuta.TextChanged += new System.EventHandler(this.NotesTerapeuta_TextChanged);
            this.NotesTerapeuta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesTerapeuta_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1071, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.Location = new System.Drawing.Point(1071, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Comprovar connexió";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(632, 657);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(439, 236);
            this.WindowsMediaPlayer1.TabIndex = 8;
            this.WindowsMediaPlayer1.Enter += new System.EventHandler(this.WindowsMediaPlayer1_Enter);
            // 
            // rutaFitxer
            // 
            this.rutaFitxer.BackColor = System.Drawing.Color.White;
            this.rutaFitxer.Location = new System.Drawing.Point(713, 631);
            this.rutaFitxer.Name = "rutaFitxer";
            this.rutaFitxer.ReadOnly = true;
            this.rutaFitxer.Size = new System.Drawing.Size(358, 20);
            this.rutaFitxer.TabIndex = 9;
            this.rutaFitxer.TextChanged += new System.EventHandler(this.rutaFitxer_TextChanged);
            // 
            // botoCercaVideo
            // 
            this.botoCercaVideo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoCercaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoCercaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoCercaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoCercaVideo.ForeColor = System.Drawing.Color.White;
            this.botoCercaVideo.Location = new System.Drawing.Point(632, 628);
            this.botoCercaVideo.Name = "botoCercaVideo";
            this.botoCercaVideo.Size = new System.Drawing.Size(75, 23);
            this.botoCercaVideo.TabIndex = 10;
            this.botoCercaVideo.Text = "Navega...";
            this.botoCercaVideo.UseVisualStyleBackColor = false;
            this.botoCercaVideo.Click += new System.EventHandler(this.botoCercaVideo_Click);
            // 
            // botoPlayVideo
            // 
            this.botoPlayVideo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoPlayVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoPlayVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoPlayVideo.ForeColor = System.Drawing.Color.White;
            this.botoPlayVideo.Location = new System.Drawing.Point(800, 899);
            this.botoPlayVideo.Name = "botoPlayVideo";
            this.botoPlayVideo.Size = new System.Drawing.Size(50, 34);
            this.botoPlayVideo.TabIndex = 11;
            this.botoPlayVideo.Text = "▶";
            this.botoPlayVideo.UseVisualStyleBackColor = false;
            this.botoPlayVideo.Click += new System.EventHandler(this.botoPlayVideo_Click);
            // 
            // botoAturaVideo
            // 
            this.botoAturaVideo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoAturaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoAturaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoAturaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoAturaVideo.ForeColor = System.Drawing.Color.White;
            this.botoAturaVideo.Location = new System.Drawing.Point(856, 899);
            this.botoAturaVideo.Name = "botoAturaVideo";
            this.botoAturaVideo.Size = new System.Drawing.Size(50, 34);
            this.botoAturaVideo.TabIndex = 12;
            this.botoAturaVideo.Text = "█";
            this.botoAturaVideo.UseVisualStyleBackColor = false;
            this.botoAturaVideo.Click += new System.EventHandler(this.botoAturaVideo_Click);
            // 
            // QuadernBitacoles_richTextBox
            // 
            this.QuadernBitacoles_richTextBox.BackColor = System.Drawing.Color.White;
            this.QuadernBitacoles_richTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuadernBitacoles_richTextBox.Location = new System.Drawing.Point(77, 631);
            this.QuadernBitacoles_richTextBox.Name = "QuadernBitacoles_richTextBox";
            this.QuadernBitacoles_richTextBox.ReadOnly = true;
            this.QuadernBitacoles_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QuadernBitacoles_richTextBox.Size = new System.Drawing.Size(523, 262);
            this.QuadernBitacoles_richTextBox.TabIndex = 13;
            this.QuadernBitacoles_richTextBox.Text = "";
            this.QuadernBitacoles_richTextBox.TextChanged += new System.EventHandler(this.QuadernBitacoles_richTextBox_TextChanged);
            // 
            // BotoEnvia
            // 
            this.BotoEnvia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BotoEnvia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BotoEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotoEnvia.ForeColor = System.Drawing.Color.White;
            this.BotoEnvia.Location = new System.Drawing.Point(547, 904);
            this.BotoEnvia.Name = "BotoEnvia";
            this.BotoEnvia.Size = new System.Drawing.Size(53, 23);
            this.BotoEnvia.TabIndex = 14;
            this.BotoEnvia.Text = "Envia";
            this.BotoEnvia.UseVisualStyleBackColor = false;
            this.BotoEnvia.Click += new System.EventHandler(this.BotoEnvia_Click);
            // 
            // minutsSessio
            // 
            this.minutsSessio.ForeColor = System.Drawing.Color.SteelBlue;
            this.minutsSessio.Location = new System.Drawing.Point(1141, 920);
            this.minutsSessio.Name = "minutsSessio";
            this.minutsSessio.Size = new System.Drawing.Size(22, 28);
            this.minutsSessio.TabIndex = 22;
            this.minutsSessio.Text = "00";
            // 
            // simbolTempsSessio
            // 
            this.simbolTempsSessio.ForeColor = System.Drawing.Color.SteelBlue;
            this.simbolTempsSessio.Location = new System.Drawing.Point(1158, 919);
            this.simbolTempsSessio.Name = "simbolTempsSessio";
            this.simbolTempsSessio.Size = new System.Drawing.Size(22, 28);
            this.simbolTempsSessio.TabIndex = 23;
            this.simbolTempsSessio.Text = ":";
            // 
            // segonsSessio
            // 
            this.segonsSessio.ForeColor = System.Drawing.Color.SteelBlue;
            this.segonsSessio.Location = new System.Drawing.Point(1167, 920);
            this.segonsSessio.Name = "segonsSessio";
            this.segonsSessio.Size = new System.Drawing.Size(22, 28);
            this.segonsSessio.TabIndex = 24;
            this.segonsSessio.Text = "00";
            // 
            // duradaSessioTitol
            // 
            this.duradaSessioTitol.AutoSize = true;
            this.duradaSessioTitol.ForeColor = System.Drawing.Color.SteelBlue;
            this.duradaSessioTitol.Location = new System.Drawing.Point(1036, 920);
            this.duradaSessioTitol.Name = "duradaSessioTitol";
            this.duradaSessioTitol.Size = new System.Drawing.Size(98, 13);
            this.duradaSessioTitol.TabIndex = 25;
            this.duradaSessioTitol.Text = "DURADA SESSIÓ:";
            this.duradaSessioTitol.Click += new System.EventHandler(this.duradaSessioTitol_Click);
            // 
            // grafiques_UserControl1
            // 
            this.grafiques_UserControl1._R = null;
            this.grafiques_UserControl1.Location = new System.Drawing.Point(41, 56);
            this.grafiques_UserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafiques_UserControl1.Name = "grafiques_UserControl1";
            this.grafiques_UserControl1.Size = new System.Drawing.Size(1140, 566);
            this.grafiques_UserControl1.TabIndex = 15;
            this.grafiques_UserControl1.Load += new System.EventHandler(this.grafiques_UserControl1_Load);
            // 
            // boto_CanviarMode
            // 
            this.boto_CanviarMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.boto_CanviarMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.boto_CanviarMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boto_CanviarMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boto_CanviarMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.boto_CanviarMode.Image = global::Biofeedback.Properties.Resources.lluna_dibuix2_petita;
            this.boto_CanviarMode.Location = new System.Drawing.Point(1144, 0);
            this.boto_CanviarMode.Name = "boto_CanviarMode";
            this.boto_CanviarMode.Size = new System.Drawing.Size(42, 40);
            this.boto_CanviarMode.TabIndex = 27;
            this.boto_CanviarMode.Text = " ";
            this.boto_CanviarMode.UseVisualStyleBackColor = false;
            this.boto_CanviarMode.Click += new System.EventHandler(this.boto_CanviarMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1205, 857);
            this.Controls.Add(this.boto_CanviarMode);
            this.Controls.Add(this.duradaSessioTitol);
            this.Controls.Add(this.segonsSessio);
            this.Controls.Add(this.simbolTempsSessio);
            this.Controls.Add(this.minutsSessio);
            this.Controls.Add(this.grafiques_UserControl1);
            this.Controls.Add(this.BotoEnvia);
            this.Controls.Add(this.QuadernBitacoles_richTextBox);
            this.Controls.Add(this.botoAturaVideo);
            this.Controls.Add(this.botoPlayVideo);
            this.Controls.Add(this.botoCercaVideo);
            this.Controls.Add(this.rutaFitxer);
            this.Controls.Add(this.WindowsMediaPlayer1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NotesTerapeuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer_sessio;
        private System.Windows.Forms.Timer timer_estimul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NotesTerapeuta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
        private System.Windows.Forms.TextBox rutaFitxer;
        private System.Windows.Forms.Button botoCercaVideo;
        public System.Windows.Forms.Button botoPlayVideo;
        public System.Windows.Forms.Button botoAturaVideo;
        private System.Windows.Forms.RichTextBox QuadernBitacoles_richTextBox;
        private System.Windows.Forms.Button BotoEnvia;
        private UserControl_Grafiques grafiques_UserControl1;
        private System.Windows.Forms.Label minutsSessio;
        private System.Windows.Forms.Label simbolTempsSessio;
        private System.Windows.Forms.Label segonsSessio;
        private System.Windows.Forms.Label duradaSessioTitol;
        public System.Windows.Forms.Button boto_CanviarMode;
    }
}

