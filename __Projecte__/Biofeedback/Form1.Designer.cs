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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NotesTerapeuta = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rutaFitxer = new System.Windows.Forms.TextBox();
            this.botoCercaVideo = new System.Windows.Forms.Button();
            this.botoPlayVideo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.botoAturaVideo = new System.Windows.Forms.Button();
            this.QuadernBitacoles_richTextBox = new System.Windows.Forms.RichTextBox();
            this.BotoEnvia = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.minutsSessio = new System.Windows.Forms.Label();
            this.simbolTempsSessio = new System.Windows.Forms.Label();
            this.segonsSessio = new System.Windows.Forms.Label();
            this.duradaSessioTitol = new System.Windows.Forms.Label();
            this.timer_sessio = new System.Windows.Forms.Timer(this.components);
            this.timer_estimul = new System.Windows.Forms.Timer(this.components);
            this.grafiques_UserControl1 = new Biofeedback.UserControl_Grafiques();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NotesTerapeuta
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(1001, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1001, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Comprovar connexió";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            this.botoCercaVideo.BackColor = System.Drawing.Color.GhostWhite;
            this.botoCercaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoCercaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoCercaVideo.ForeColor = System.Drawing.Color.HotPink;
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
            this.botoPlayVideo.BackColor = System.Drawing.Color.GhostWhite;
            this.botoPlayVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoPlayVideo.ForeColor = System.Drawing.Color.HotPink;
            this.botoPlayVideo.Location = new System.Drawing.Point(800, 899);
            this.botoPlayVideo.Name = "botoPlayVideo";
            this.botoPlayVideo.Size = new System.Drawing.Size(50, 34);
            this.botoPlayVideo.TabIndex = 11;
            this.botoPlayVideo.Text = "▶";
            this.botoPlayVideo.UseVisualStyleBackColor = false;
            this.botoPlayVideo.Click += new System.EventHandler(this.botoPlayVideo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // botoAturaVideo
            // 
            this.botoAturaVideo.BackColor = System.Drawing.Color.GhostWhite;
            this.botoAturaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoAturaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoAturaVideo.ForeColor = System.Drawing.Color.HotPink;
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
            this.BotoEnvia.BackColor = System.Drawing.Color.GhostWhite;
            this.BotoEnvia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BotoEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotoEnvia.ForeColor = System.Drawing.Color.HotPink;
            this.BotoEnvia.Location = new System.Drawing.Point(547, 904);
            this.BotoEnvia.Name = "BotoEnvia";
            this.BotoEnvia.Size = new System.Drawing.Size(53, 23);
            this.BotoEnvia.TabIndex = 14;
            this.BotoEnvia.Text = "Envia";
            this.BotoEnvia.UseVisualStyleBackColor = false;
            this.BotoEnvia.Click += new System.EventHandler(this.BotoEnvia_Click);
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
            // minutsSessio
            // 
            this.minutsSessio.ForeColor = System.Drawing.Color.HotPink;
            this.minutsSessio.Location = new System.Drawing.Point(1079, 918);
            this.minutsSessio.Name = "minutsSessio";
            this.minutsSessio.Size = new System.Drawing.Size(22, 28);
            this.minutsSessio.TabIndex = 22;
            this.minutsSessio.Text = "00";
            // 
            // simbolTempsSessio
            // 
            this.simbolTempsSessio.ForeColor = System.Drawing.Color.HotPink;
            this.simbolTempsSessio.Location = new System.Drawing.Point(1096, 917);
            this.simbolTempsSessio.Name = "simbolTempsSessio";
            this.simbolTempsSessio.Size = new System.Drawing.Size(22, 28);
            this.simbolTempsSessio.TabIndex = 23;
            this.simbolTempsSessio.Text = ":";
            // 
            // segonsSessio
            // 
            this.segonsSessio.ForeColor = System.Drawing.Color.HotPink;
            this.segonsSessio.Location = new System.Drawing.Point(1105, 918);
            this.segonsSessio.Name = "segonsSessio";
            this.segonsSessio.Size = new System.Drawing.Size(22, 28);
            this.segonsSessio.TabIndex = 24;
            this.segonsSessio.Text = "00";
            // 
            // duradaSessioTitol
            // 
            this.duradaSessioTitol.AutoSize = true;
            this.duradaSessioTitol.ForeColor = System.Drawing.Color.HotPink;
            this.duradaSessioTitol.Location = new System.Drawing.Point(970, 919);
            this.duradaSessioTitol.Name = "duradaSessioTitol";
            this.duradaSessioTitol.Size = new System.Drawing.Size(98, 13);
            this.duradaSessioTitol.TabIndex = 25;
            this.duradaSessioTitol.Text = "DURADA SESSIÓ:";
            this.duradaSessioTitol.Click += new System.EventHandler(this.duradaSessioTitol_Click);
            // 
            // timer_sessio
            // 
            this.timer_sessio.Tick += new System.EventHandler(this.timer_sessio_Tick);
            // 
            // timer_estimul
            // 
            this.timer_estimul.Tick += new System.EventHandler(this.timer_estimul_Tick);
            // 
            // grafiques_UserControl1
            // 
            this.grafiques_UserControl1.Location = new System.Drawing.Point(45, 56);
            this.grafiques_UserControl1.Name = "grafiques_UserControl1";
            this.grafiques_UserControl1._R = null;
            this.grafiques_UserControl1.Size = new System.Drawing.Size(1144, 533);
            this.grafiques_UserControl1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 952);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox NotesTerapeuta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
        private System.Windows.Forms.TextBox rutaFitxer;
        private System.Windows.Forms.Button botoCercaVideo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox QuadernBitacoles_richTextBox;
        public System.Windows.Forms.Button botoPlayVideo;
        private System.Windows.Forms.Button BotoEnvia;
        public System.Windows.Forms.Button botoAturaVideo;
        private UserControl_Grafiques grafiques_UserControl1;
        private System.Windows.Forms.Label minutsSessio;
        private System.Windows.Forms.Label simbolTempsSessio;
        private System.Windows.Forms.Label segonsSessio;
        private System.Windows.Forms.Label duradaSessioTitol;
        private System.Windows.Forms.Timer timer_sessio;
        private System.Windows.Forms.Timer timer_estimul;
    }
}

