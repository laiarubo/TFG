using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using ContingutBD;

namespace Biofeedback
{
    public partial class Grafiques_UserControl : UserControl
    {
        // Per a la comunicació amb la BD
        List<LecturesMio> LECTURESMIO = new List<LecturesMio>();

        private ChartValues<Cardiograma> dadesCardiograma { get; set; }
        private Timer Timer { get; set; }
        public Random R { get; set; }
        private ChartValues<Miograma> dadesMiograma { get; set; }
        private ChartValues<RespostaGalvanica> dadesRG { get; set; }

        float maxim_mio_actual = 0;
        float maxim_rg_actual = 0;

        float minim_mio_actual = 9999;
        float minim_rg_actual = 9999;

        List<float> lectures_mio = new List<float>();
        List<float> lectures_rg = new List<float>();


        public Grafiques_UserControl()
        {
            InitializeComponent();

            construirCardiograma();

            construirMiograma();

            construirRespostaGalvanica();

            // S'enllaça l'event de Connexio_Singleton amb LivaCharts_UserControl
            // S'ha de recollir l'event riseDada
           // Connexio_Singleton.getInstance().nouEventMiograma += mostraValorsArduino;

        }

        private void construirCardiograma()
        {
            var mapper = Mappers.Xy<Cardiograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Cardiograma>(mapper);

            //the dadesCardiograma property will store our values array
            dadesCardiograma = new ChartValues<Cardiograma>();
            cardiograma.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = dadesCardiograma,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            cardiograma.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);

            //The next code simulates data changes every 500 ms
            Timer = new Timer
            {
                Interval = 1000
            };
            Timer.Tick += TimerOnTick;
            R = new Random();
            Timer.Start();
        }

        private void construirMiograma()
        {
            var mapper = Mappers.Xy<Miograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Miograma>(mapper);

            //the dadesMiograma property will store our values array
            dadesMiograma = new ChartValues<Miograma>();
            miograma.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = dadesMiograma,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            miograma.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)Math.Abs(value)).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            //SetAxisLimitsMiograma(System.DateTime.Now);

            // S'enllaça l'event de Connexio_Singleton amb LivaCharts_UserControl. S'ha de recollir l'event riseDada
            Connexio_Singleton.getInstance().nouEventMiograma += mostraValorsArduinoMiograma;



        }

        private void construirRespostaGalvanica()
        {
            var mapper = Mappers.Xy<RespostaGalvanica>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<RespostaGalvanica>(mapper);

            //the dadesRG property will store our values array
            dadesRG = new ChartValues<RespostaGalvanica>();
            respostaGalvanica.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = dadesRG,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            respostaGalvanica.AxisX.Add(new Axis
            {
                
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)Math.Abs(value)).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });


            // S'enllaça l'event de Connexio_Singleton amb LivaCharts_UserControl. S'ha de recollir l'event riseDada
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += mostraValorsArduinoRG;
        }

        private void mostraValorsArduinoMiograma(string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            dadesMiograma.Add(new Miograma
            {
                DateTime = now,
                Value = conversio
            });

            // Perquè surtin 8 puntets al miograma (no fa res!)
            //if (dadesMiograma.Count > 8) dadesMiograma.RemoveAt(0);

            lecturaMio.Invoke((MethodInvoker)(() => lecturaMio.Text = s)); // Aquest MothodInvoker evita que la interfície sigui cridada per un thread 

            SetAxisLimitsMiograma(System.DateTime.Now);

            // Desar les lectures a la BD
            //LecturesMio valor = new LecturesMio();
            //valor.valor = (float)conversio;
            //SqliteDataAccess.DesaLecturesMio(valor);

            float max = getMaximMio((float)conversio);
            lecturaMio.Invoke((MethodInvoker)(() => maxMio.Text = max.ToString()));

            float min = getMinimMio((float)conversio);
            lecturaMio.Invoke((MethodInvoker)(() => minMio.Text = min.ToString()));

            float mitjana = getMitjanaMio((float)conversio);
            lecturaMio.Invoke((MethodInvoker)(() => mitjanaMio.Text = mitjana.ToString()));

            //float max = SqliteDataAccess.getMaximLecturesMio();

            //maxMio.Invoke((MethodInvoker)(() => maxMio.Text = max.ToString()));
        }

        private void mostraValorsArduinoRG(string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            dadesRG.Add(new RespostaGalvanica
            {
                DateTime = now,
                Value = conversio
            });

            // Perquè surtin 8 puntets a la resposta galvànica
            //if (dadesRG.Count > 8) dadesRG.RemoveAt(0);

            lecturaRG.Invoke((MethodInvoker)(() => lecturaRG.Text = s));

            SetAxisLimitsRG(System.DateTime.Now);

            float max = getMaximRG((float)conversio);
            lecturaRG.Invoke((MethodInvoker)(() => maxRG.Text = max.ToString()));

            float min = getMinimRG((float)conversio);
            lecturaMio.Invoke((MethodInvoker)(() => minRG.Text = min.ToString()));

            float mitjana = getMitjanaRG((float)conversio);
            lecturaMio.Invoke((MethodInvoker)(() => mitjanaRG.Text = mitjana.ToString()));
        }

        private void SetAxisLimits(System.DateTime now)
        {
            cardiograma.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead. AQUEST NO M'INTERESSA PERQUÈ M'AGRADA QUE LA LÍNIA BLAVA OCUPI TOT L'ESPAI HORITZONTAL DE LA GRÀFICA
            cardiograma.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void SetAxisLimitsMiograma(System.DateTime now)
        {
          //  miograma.Invoke((MethodInvoker)(() => miograma.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks)); // lets force the axis to be 100ms ahead
            miograma.Invoke((MethodInvoker)(() => miograma.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(7).Ticks)); //we only care about the last 8 seconds
        }

        private void SetAxisLimitsRG(System.DateTime now)
        {
            //  miograma.Invoke((MethodInvoker)(() => miograma.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks)); // lets force the axis to be 100ms ahead
            respostaGalvanica.Invoke((MethodInvoker)(() => respostaGalvanica.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(14).Ticks)); //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = System.DateTime.Now;
            int random = R.Next(0, 10);

            dadesCardiograma.Add(new Cardiograma
            {
                DateTime = now,
                Value = random
            });

            SetAxisLimits(now);

            //lets only use the last 15 values
            if (dadesCardiograma.Count > 15) dadesCardiograma.RemoveAt(0);

            lecturaCardio.Text = random.ToString();
        }

        private void lectures_Click(object sender, EventArgs e)
        {

        }

        private float getMaximMio(float value)
        {
            if (value > maxim_mio_actual)
                maxim_mio_actual = value;
            return maxim_mio_actual;
        }

        private float getMaximRG(float value)
        {
            if (value > maxim_rg_actual)
                maxim_rg_actual = value;
            return maxim_rg_actual;
        }

        private float getMinimMio(float value)
        {
            if (value < minim_mio_actual)
                minim_mio_actual = value;
            return minim_mio_actual;
        }

        private float getMinimRG(float value)
        {
            if (value < minim_rg_actual)
                minim_rg_actual = value;
            return minim_rg_actual;
        }

        private float getMitjanaMio(float valor)
        {
            lectures_mio.Add(valor);
            float suma = 0;
            foreach (float lectura in lectures_mio)
                suma += lectura;
            return (float)Math.Round(suma / lectures_mio.Count, 2);
        }

        private float getMitjanaRG(float valor)
        {
            lectures_rg.Add(valor);
            float suma = 0;
            foreach (float lectura in lectures_rg)
                suma += lectura;
            return (float)Math.Round(suma / lectures_rg.Count, 2);
        }
    }
}

