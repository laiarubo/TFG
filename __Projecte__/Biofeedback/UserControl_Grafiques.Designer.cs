
namespace Biofeedback
{
    partial class UserControl_Grafiques
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardiograma = new LiveCharts.WinForms.CartesianChart();
            this.respostaGalvanica = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.miograma = new LiveCharts.WinForms.CartesianChart();
            this.lectures = new System.Windows.Forms.Label();
            this.evolucio = new System.Windows.Forms.Label();
            this.maxim = new System.Windows.Forms.Label();
            this.minim = new System.Windows.Forms.Label();
            this.mitjana = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.lecturaCardio = new System.Windows.Forms.Label();
            this.lecturaMio = new System.Windows.Forms.Label();
            this.lecturaRG = new System.Windows.Forms.Label();
            this.maxCardio = new System.Windows.Forms.Label();
            this.maxMio = new System.Windows.Forms.Label();
            this.maxRG = new System.Windows.Forms.Label();
            this.minCardio = new System.Windows.Forms.Label();
            this.minMio = new System.Windows.Forms.Label();
            this.minRG = new System.Windows.Forms.Label();
            this.mitjanaCardio = new System.Windows.Forms.Label();
            this.mitjanaMio = new System.Windows.Forms.Label();
            this.mitjanaRG = new System.Windows.Forms.Label();
            this.sdCardio = new System.Windows.Forms.Label();
            this.sdMio = new System.Windows.Forms.Label();
            this.sdRG = new System.Windows.Forms.Label();
            this.botoFinalitza = new System.Windows.Forms.Button();
            this.botoInicia = new System.Windows.Forms.Button();
            this.botoAnula = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cardiograma, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.respostaGalvanica, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.miograma, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 465);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cardiograma (BPM)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resposta galvànica (GSR)";
            // 
            // cardiograma
            // 
            this.cardiograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardiograma.Location = new System.Drawing.Point(3, 23);
            this.cardiograma.Name = "cardiograma";
            this.cardiograma.Size = new System.Drawing.Size(498, 129);
            this.cardiograma.TabIndex = 6;
            this.cardiograma.Text = "cartesianChart1";
            // 
            // respostaGalvanica
            // 
            this.respostaGalvanica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.respostaGalvanica.Location = new System.Drawing.Point(3, 333);
            this.respostaGalvanica.Name = "respostaGalvanica";
            this.respostaGalvanica.Size = new System.Drawing.Size(498, 129);
            this.respostaGalvanica.TabIndex = 8;
            this.respostaGalvanica.Text = "cartesianChart3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Miograma (µV)";
            // 
            // miograma
            // 
            this.miograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miograma.Location = new System.Drawing.Point(3, 178);
            this.miograma.Name = "miograma";
            this.miograma.Size = new System.Drawing.Size(498, 129);
            this.miograma.TabIndex = 7;
            this.miograma.Text = "cartesianChart2";
            // 
            // lectures
            // 
            this.lectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectures.ForeColor = System.Drawing.Color.SteelBlue;
            this.lectures.Location = new System.Drawing.Point(525, 66);
            this.lectures.Name = "lectures";
            this.lectures.Size = new System.Drawing.Size(121, 38);
            this.lectures.TabIndex = 14;
            this.lectures.Text = "LECTURA";
            this.lectures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lectures.Click += new System.EventHandler(this.lectures_Click);
            // 
            // evolucio
            // 
            this.evolucio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evolucio.ForeColor = System.Drawing.Color.SteelBlue;
            this.evolucio.Location = new System.Drawing.Point(143, 67);
            this.evolucio.Name = "evolucio";
            this.evolucio.Size = new System.Drawing.Size(157, 38);
            this.evolucio.TabIndex = 15;
            this.evolucio.Text = "EVOLUCIÓ";
            this.evolucio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.evolucio.Click += new System.EventHandler(this.evolucio_Click);
            // 
            // maxim
            // 
            this.maxim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxim.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxim.Location = new System.Drawing.Point(752, 66);
            this.maxim.Name = "maxim";
            this.maxim.Size = new System.Drawing.Size(104, 38);
            this.maxim.TabIndex = 16;
            this.maxim.Text = "MÀXIM";
            this.maxim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minim
            // 
            this.minim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minim.ForeColor = System.Drawing.Color.SteelBlue;
            this.minim.Location = new System.Drawing.Point(662, 66);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(88, 38);
            this.minim.TabIndex = 17;
            this.minim.Text = "MÍNIM";
            this.minim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mitjana
            // 
            this.mitjana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitjana.ForeColor = System.Drawing.Color.SteelBlue;
            this.mitjana.Location = new System.Drawing.Point(861, 66);
            this.mitjana.Name = "mitjana";
            this.mitjana.Size = new System.Drawing.Size(128, 38);
            this.mitjana.TabIndex = 18;
            this.mitjana.Text = "MITJANA";
            this.mitjana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sd
            // 
            this.sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.ForeColor = System.Drawing.Color.SteelBlue;
            this.sd.Location = new System.Drawing.Point(973, 47);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(158, 77);
            this.sd.TabIndex = 19;
            this.sd.Text = "DESVIACIÓ ESTÀNDARD";
            this.sd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturaCardio
            // 
            this.lecturaCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaCardio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lecturaCardio.Location = new System.Drawing.Point(577, 163);
            this.lecturaCardio.Name = "lecturaCardio";
            this.lecturaCardio.Size = new System.Drawing.Size(69, 33);
            this.lecturaCardio.TabIndex = 20;
            this.lecturaCardio.Text = "lecturaCardio";
            this.lecturaCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturaMio
            // 
            this.lecturaMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaMio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lecturaMio.Location = new System.Drawing.Point(582, 304);
            this.lecturaMio.Name = "lecturaMio";
            this.lecturaMio.Size = new System.Drawing.Size(64, 33);
            this.lecturaMio.TabIndex = 21;
            this.lecturaMio.Text = "lecturaMio";
            this.lecturaMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecturaRG
            // 
            this.lecturaRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturaRG.ForeColor = System.Drawing.Color.SteelBlue;
            this.lecturaRG.Location = new System.Drawing.Point(553, 464);
            this.lecturaRG.Name = "lecturaRG";
            this.lecturaRG.Size = new System.Drawing.Size(111, 33);
            this.lecturaRG.TabIndex = 22;
            this.lecturaRG.Text = "lecturaRG";
            this.lecturaRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxCardio
            // 
            this.maxCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCardio.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxCardio.Location = new System.Drawing.Point(772, 163);
            this.maxCardio.Name = "maxCardio";
            this.maxCardio.Size = new System.Drawing.Size(76, 33);
            this.maxCardio.TabIndex = 23;
            this.maxCardio.Text = "maxCardio";
            this.maxCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxMio
            // 
            this.maxMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMio.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxMio.Location = new System.Drawing.Point(772, 304);
            this.maxMio.Name = "maxMio";
            this.maxMio.Size = new System.Drawing.Size(94, 33);
            this.maxMio.TabIndex = 24;
            this.maxMio.Text = "maxMio";
            this.maxMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxRG
            // 
            this.maxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxRG.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxRG.Location = new System.Drawing.Point(762, 464);
            this.maxRG.Name = "maxRG";
            this.maxRG.Size = new System.Drawing.Size(104, 33);
            this.maxRG.TabIndex = 25;
            this.maxRG.Text = "maxRG";
            this.maxRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minCardio
            // 
            this.minCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCardio.ForeColor = System.Drawing.Color.SteelBlue;
            this.minCardio.Location = new System.Drawing.Point(684, 163);
            this.minCardio.Name = "minCardio";
            this.minCardio.Size = new System.Drawing.Size(78, 33);
            this.minCardio.TabIndex = 26;
            this.minCardio.Text = "minCardio";
            this.minCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minMio
            // 
            this.minMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMio.ForeColor = System.Drawing.Color.SteelBlue;
            this.minMio.Location = new System.Drawing.Point(684, 304);
            this.minMio.Name = "minMio";
            this.minMio.Size = new System.Drawing.Size(78, 33);
            this.minMio.TabIndex = 27;
            this.minMio.Text = "minMio";
            this.minMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minRG
            // 
            this.minRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRG.ForeColor = System.Drawing.Color.SteelBlue;
            this.minRG.Location = new System.Drawing.Point(670, 464);
            this.minRG.Name = "minRG";
            this.minRG.Size = new System.Drawing.Size(92, 33);
            this.minRG.TabIndex = 28;
            this.minRG.Text = "minRG";
            this.minRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minRG.Click += new System.EventHandler(this.minRG_Click);
            // 
            // mitjanaCardio
            // 
            this.mitjanaCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitjanaCardio.ForeColor = System.Drawing.Color.SteelBlue;
            this.mitjanaCardio.Location = new System.Drawing.Point(872, 163);
            this.mitjanaCardio.Name = "mitjanaCardio";
            this.mitjanaCardio.Size = new System.Drawing.Size(116, 33);
            this.mitjanaCardio.TabIndex = 29;
            this.mitjanaCardio.Text = "mitjanaCardio";
            this.mitjanaCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mitjanaMio
            // 
            this.mitjanaMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitjanaMio.ForeColor = System.Drawing.Color.SteelBlue;
            this.mitjanaMio.Location = new System.Drawing.Point(872, 304);
            this.mitjanaMio.Name = "mitjanaMio";
            this.mitjanaMio.Size = new System.Drawing.Size(116, 33);
            this.mitjanaMio.TabIndex = 30;
            this.mitjanaMio.Text = "mitjanaMio";
            this.mitjanaMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mitjanaRG
            // 
            this.mitjanaRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitjanaRG.ForeColor = System.Drawing.Color.SteelBlue;
            this.mitjanaRG.Location = new System.Drawing.Point(860, 464);
            this.mitjanaRG.Name = "mitjanaRG";
            this.mitjanaRG.Size = new System.Drawing.Size(132, 33);
            this.mitjanaRG.TabIndex = 31;
            this.mitjanaRG.Text = "mitjanaRG";
            this.mitjanaRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdCardio
            // 
            this.sdCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdCardio.ForeColor = System.Drawing.Color.SteelBlue;
            this.sdCardio.Location = new System.Drawing.Point(1010, 163);
            this.sdCardio.Name = "sdCardio";
            this.sdCardio.Size = new System.Drawing.Size(78, 33);
            this.sdCardio.TabIndex = 32;
            this.sdCardio.Text = "sdCardio";
            this.sdCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdMio
            // 
            this.sdMio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdMio.ForeColor = System.Drawing.Color.SteelBlue;
            this.sdMio.Location = new System.Drawing.Point(1010, 304);
            this.sdMio.Name = "sdMio";
            this.sdMio.Size = new System.Drawing.Size(65, 33);
            this.sdMio.TabIndex = 33;
            this.sdMio.Text = "sdMio";
            this.sdMio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdRG
            // 
            this.sdRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdRG.ForeColor = System.Drawing.Color.SteelBlue;
            this.sdRG.Location = new System.Drawing.Point(1004, 464);
            this.sdRG.Name = "sdRG";
            this.sdRG.Size = new System.Drawing.Size(84, 33);
            this.sdRG.TabIndex = 34;
            this.sdRG.Text = "sdRG";
            this.sdRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botoFinalitza
            // 
            this.botoFinalitza.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoFinalitza.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoFinalitza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoFinalitza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoFinalitza.ForeColor = System.Drawing.Color.White;
            this.botoFinalitza.Location = new System.Drawing.Point(233, 0);
            this.botoFinalitza.Name = "botoFinalitza";
            this.botoFinalitza.Size = new System.Drawing.Size(152, 40);
            this.botoFinalitza.TabIndex = 39;
            this.botoFinalitza.Text = "Finalitza l\'estudi";
            this.botoFinalitza.UseVisualStyleBackColor = false;
            this.botoFinalitza.Click += new System.EventHandler(this.botoFinalitza_Click);
            // 
            // botoInicia
            // 
            this.botoInicia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoInicia.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoInicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoInicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoInicia.ForeColor = System.Drawing.Color.White;
            this.botoInicia.Location = new System.Drawing.Point(61, 0);
            this.botoInicia.Name = "botoInicia";
            this.botoInicia.Size = new System.Drawing.Size(152, 40);
            this.botoInicia.TabIndex = 38;
            this.botoInicia.Text = "Inicia l\'estudi";
            this.botoInicia.UseVisualStyleBackColor = false;
            this.botoInicia.Click += new System.EventHandler(this.botoInicia_Click);
            // 
            // botoAnula
            // 
            this.botoAnula.BackColor = System.Drawing.Color.LightSteelBlue;
            this.botoAnula.Cursor = System.Windows.Forms.Cursors.Default;
            this.botoAnula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoAnula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoAnula.ForeColor = System.Drawing.Color.White;
            this.botoAnula.Location = new System.Drawing.Point(752, 0);
            this.botoAnula.Name = "botoAnula";
            this.botoAnula.Size = new System.Drawing.Size(161, 40);
            this.botoAnula.TabIndex = 41;
            this.botoAnula.Text = "Cancel·la l\'estudi";
            this.botoAnula.UseVisualStyleBackColor = false;
            this.botoAnula.Click += new System.EventHandler(this.botoAnula_Click);
            // 
            // UserControl_Grafiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.botoAnula);
            this.Controls.Add(this.botoFinalitza);
            this.Controls.Add(this.botoInicia);
            this.Controls.Add(this.sdRG);
            this.Controls.Add(this.sdMio);
            this.Controls.Add(this.sdCardio);
            this.Controls.Add(this.mitjanaRG);
            this.Controls.Add(this.mitjanaMio);
            this.Controls.Add(this.mitjanaCardio);
            this.Controls.Add(this.minRG);
            this.Controls.Add(this.minMio);
            this.Controls.Add(this.minCardio);
            this.Controls.Add(this.maxRG);
            this.Controls.Add(this.maxMio);
            this.Controls.Add(this.maxCardio);
            this.Controls.Add(this.lecturaRG);
            this.Controls.Add(this.lecturaMio);
            this.Controls.Add(this.lecturaCardio);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.mitjana);
            this.Controls.Add(this.minim);
            this.Controls.Add(this.maxim);
            this.Controls.Add(this.evolucio);
            this.Controls.Add(this.lectures);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl_Grafiques";
            this.Size = new System.Drawing.Size(1134, 584);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart cardiograma;
        private LiveCharts.WinForms.CartesianChart respostaGalvanica;
        private LiveCharts.WinForms.CartesianChart miograma;
        public System.Windows.Forms.Label lectures;
        public System.Windows.Forms.Label evolucio;
        public System.Windows.Forms.Label maxim;
        public System.Windows.Forms.Label minim;
        public System.Windows.Forms.Label mitjana;
        public System.Windows.Forms.Label sd;
        public System.Windows.Forms.Label lecturaCardio;
        public System.Windows.Forms.Label lecturaMio;
        public System.Windows.Forms.Label lecturaRG;
        public System.Windows.Forms.Label maxCardio;
        public System.Windows.Forms.Label maxMio;
        public System.Windows.Forms.Label maxRG;
        public System.Windows.Forms.Label minCardio;
        public System.Windows.Forms.Label minMio;
        public System.Windows.Forms.Label minRG;
        public System.Windows.Forms.Label mitjanaCardio;
        public System.Windows.Forms.Label mitjanaMio;
        public System.Windows.Forms.Label mitjanaRG;
        public System.Windows.Forms.Label sdCardio;
        public System.Windows.Forms.Label sdMio;
        public System.Windows.Forms.Label sdRG;
        public System.Windows.Forms.Button botoFinalitza;
        public System.Windows.Forms.Button botoInicia;
        public System.Windows.Forms.Button botoAnula;
        public System.Windows.Forms.Label label2;
    }
}
