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
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.rutaFitxer = new System.Windows.Forms.TextBox();
            this.botoCercaVideo = new System.Windows.Forms.Button();
            this.botoPlayVideo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.botoAturaVideo = new System.Windows.Forms.Button();
            this.QuadernBitacoles_richTextBox = new System.Windows.Forms.RichTextBox();
            this.BotoEnvia = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(27, 13);
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
            this.label2.Location = new System.Drawing.Point(27, 39);
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
            this.NotesTerapeuta.Location = new System.Drawing.Point(49, 591);
            this.NotesTerapeuta.Name = "NotesTerapeuta";
            this.NotesTerapeuta.Size = new System.Drawing.Size(464, 20);
            this.NotesTerapeuta.TabIndex = 3;
            this.NotesTerapeuta.TextChanged += new System.EventHandler(this.NotesTerapeuta_TextChanged);
            this.NotesTerapeuta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesTerapeuta_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "LEDtemp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(604, 341);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(439, 236);
            this.WindowsMediaPlayer1.TabIndex = 8;
            this.WindowsMediaPlayer1.Enter += new System.EventHandler(this.WindowsMediaPlayer1_Enter);
            // 
            // rutaFitxer
            // 
            this.rutaFitxer.BackColor = System.Drawing.Color.White;
            this.rutaFitxer.Location = new System.Drawing.Point(685, 315);
            this.rutaFitxer.Name = "rutaFitxer";
            this.rutaFitxer.ReadOnly = true;
            this.rutaFitxer.Size = new System.Drawing.Size(358, 20);
            this.rutaFitxer.TabIndex = 9;
            this.rutaFitxer.TextChanged += new System.EventHandler(this.rutaFitxer_TextChanged);
            // 
            // botoCercaVideo
            // 
            this.botoCercaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoCercaVideo.ForeColor = System.Drawing.Color.DeepPink;
            this.botoCercaVideo.Location = new System.Drawing.Point(604, 312);
            this.botoCercaVideo.Name = "botoCercaVideo";
            this.botoCercaVideo.Size = new System.Drawing.Size(75, 23);
            this.botoCercaVideo.TabIndex = 10;
            this.botoCercaVideo.Text = "Navega...";
            this.botoCercaVideo.UseVisualStyleBackColor = true;
            this.botoCercaVideo.Click += new System.EventHandler(this.botoCercaVideo_Click);
            // 
            // botoPlayVideo
            // 
            this.botoPlayVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoPlayVideo.ForeColor = System.Drawing.Color.HotPink;
            this.botoPlayVideo.Location = new System.Drawing.Point(772, 583);
            this.botoPlayVideo.Name = "botoPlayVideo";
            this.botoPlayVideo.Size = new System.Drawing.Size(50, 34);
            this.botoPlayVideo.TabIndex = 11;
            this.botoPlayVideo.Text = "▶";
            this.botoPlayVideo.UseVisualStyleBackColor = true;
            this.botoPlayVideo.Click += new System.EventHandler(this.botoPlayVideo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // botoAturaVideo
            // 
            this.botoAturaVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoAturaVideo.ForeColor = System.Drawing.Color.HotPink;
            this.botoAturaVideo.Location = new System.Drawing.Point(828, 583);
            this.botoAturaVideo.Name = "botoAturaVideo";
            this.botoAturaVideo.Size = new System.Drawing.Size(50, 34);
            this.botoAturaVideo.TabIndex = 12;
            this.botoAturaVideo.Text = "█";
            this.botoAturaVideo.UseVisualStyleBackColor = true;
            this.botoAturaVideo.Click += new System.EventHandler(this.botoAturaVideo_Click);
            // 
            // QuadernBitacoles_richTextBox
            // 
            this.QuadernBitacoles_richTextBox.BackColor = System.Drawing.Color.White;
            this.QuadernBitacoles_richTextBox.Location = new System.Drawing.Point(49, 315);
            this.QuadernBitacoles_richTextBox.Name = "QuadernBitacoles_richTextBox";
            this.QuadernBitacoles_richTextBox.ReadOnly = true;
            this.QuadernBitacoles_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QuadernBitacoles_richTextBox.Size = new System.Drawing.Size(512, 262);
            this.QuadernBitacoles_richTextBox.TabIndex = 13;
            this.QuadernBitacoles_richTextBox.Text = "";
            this.QuadernBitacoles_richTextBox.TextChanged += new System.EventHandler(this.QuadernBitacoles_richTextBox_TextChanged);
            // 
            // BotoEnvia
            // 
            this.BotoEnvia.BackColor = System.Drawing.Color.Transparent;
            this.BotoEnvia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BotoEnvia.ForeColor = System.Drawing.Color.DeepPink;
            this.BotoEnvia.Location = new System.Drawing.Point(519, 588);
            this.BotoEnvia.Name = "BotoEnvia";
            this.BotoEnvia.Size = new System.Drawing.Size(42, 23);
            this.BotoEnvia.TabIndex = 14;
            this.BotoEnvia.Text = "Envia";
            this.BotoEnvia.UseVisualStyleBackColor = false;
            this.BotoEnvia.Click += new System.EventHandler(this.BotoEnvia_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(604, 167);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 17;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 637);
            this.Controls.Add(this.elementHost1);
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
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

