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

        float minim_cardio_actual = 9999;
        float minim_mio_actual = 9999;
        float minim_rg_actual = 9999;

        float maxim_cardio_actual = 0;
        float maxim_mio_actual = 0;
        float maxim_rg_actual = 0;

        List<float> lectures_cardio = new List<float>();
        List<float> lectures_mio = new List<float>();
        List<float> lectures_rg = new List<float>();

        public Grafiques_UserControl()
        {
            InitializeComponent();

            construirCardiograma();
            construirMiograma();
            construirRespostaGalvanica();
        }

        private void construirCardiograma_tmp()
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

            //The next code simulates data changes every 1 second
            Timer = new Timer
            {
                Interval = 1000
            };
            Timer.Tick += TimerOnTick;
            R = new Random();
            Timer.Start();
        }

        private void construirCardiograma()
        {
            var mapper = Mappers.Xy<Cardiograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Cardiograma>(mapper);

            //the dadesMiograma property will store our values array
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
                LabelFormatter = value => new System.DateTime((long)Math.Abs(value)).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            // S'enllaça l'event de Connexio_Singleton amb LivaCharts_UserControl. S'ha de recollir l'event riseDada
            Connexio_Singleton.getInstance().nouEventCardiograma += mostraValorsArduinoCardio;
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

            // S'enllaça l'event de Connexio_Singleton amb LivaCharts_UserControl. S'ha de recollir l'event riseDada
            Connexio_Singleton.getInstance().nouEventMiograma += mostraValorsArduinoMio;
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

        private void mostraValorsArduinoCardio(string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            dadesCardiograma.Add(new Cardiograma
            {
                DateTime = now,
                Value = conversio
            });

            // Perquè surtin 8 puntets al cardiograma (no fa res!)
            if (dadesCardiograma.Count > 20) dadesCardiograma.RemoveAt(0);

            lecturaCardio.Invoke((MethodInvoker)(() => lecturaCardio.Text = s)); // Aquest MothodInvoker evita que la interfície sigui cridada per un thread 

            SetAxisLimitsCardio(System.DateTime.Now);

            float max = getMaximCardio((float)conversio);
            maxCardio.Invoke((MethodInvoker)(() => maxCardio.Text = max.ToString()));

            float min = getMinimCardio((float)conversio);
            minCardio.Invoke((MethodInvoker)(() => minCardio.Text = min.ToString()));

            float mitjana = getMitjanaCardio((float)conversio);
            mitjanaCardio.Invoke((MethodInvoker)(() => mitjanaCardio.Text = mitjana.ToString()));

            float sd = getDesviacioEstandardCardio((float)conversio);
            sdCardio.Invoke((MethodInvoker)(() => sdCardio.Text = sd.ToString()));
        }

        private void mostraValorsArduinoMio(string s)
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
            if (dadesMiograma.Count > 20) dadesMiograma.RemoveAt(0);

            lecturaMio.Invoke((MethodInvoker)(() => lecturaMio.Text = s)); // Aquest MothodInvoker evita que la interfície sigui cridada per un thread 

            SetAxisLimitsMiograma(System.DateTime.Now);

            // Desar les lectures a la BD
            //LecturesMio valor = new LecturesMio();
            //valor.valor = (float)conversio;
            //SqliteDataAccess.DesaLecturesMio(valor);

            float max = getMaximMio((float)conversio);
            maxMio.Invoke((MethodInvoker)(() => maxMio.Text = max.ToString()));

            float min = getMinimMio((float)conversio);
            minMio.Invoke((MethodInvoker)(() => minMio.Text = min.ToString()));

            float mitjana = getMitjanaMio((float)conversio);
            mitjanaMio.Invoke((MethodInvoker)(() => mitjanaMio.Text = mitjana.ToString()));

            float sd = getDesviacioEstandardMio((float)conversio);
            sdMio.Invoke((MethodInvoker)(() => sdMio.Text = sd.ToString()));
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
            if (dadesRG.Count > 20) dadesRG.RemoveAt(0);

            lecturaRG.Invoke((MethodInvoker)(() => lecturaRG.Text = s));

            SetAxisLimitsRG(System.DateTime.Now);

            float max = getMaximRG((float)conversio);
            maxRG.Invoke((MethodInvoker)(() => maxRG.Text = max.ToString()));

            float min = getMinimRG((float)conversio);
            minRG.Invoke((MethodInvoker)(() => minRG.Text = min.ToString()));

            float mitjana = getMitjanaRG((float)conversio);
            mitjanaRG.Invoke((MethodInvoker)(() => mitjanaRG.Text = mitjana.ToString()));

            float sd = getDesviacioEstandardRG((float)conversio);
            sdRG.Invoke((MethodInvoker)(() => sdRG.Text = sd.ToString()));
        }

        private void SetAxisLimits(System.DateTime now)
        {
            cardiograma.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead. AQUEST NO M'INTERESSA PERQUÈ M'AGRADA QUE LA LÍNIA BLAVA OCUPI TOT L'ESPAI HORITZONTAL DE LA GRÀFICA
            cardiograma.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void SetAxisLimitsCardio(System.DateTime now)
        {
            //  cardiograma.Invoke((MethodInvoker)(() => cardiograma.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks)); // lets force the axis to be 100ms ahead
            cardiograma.Invoke((MethodInvoker)(() => cardiograma.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(7).Ticks)); //we only care about the last 8 seconds
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

        private float getMaximCardio(float value)
        {
            if (value > maxim_cardio_actual)
                maxim_cardio_actual = value;
            return maxim_cardio_actual;
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

        private float getMinimCardio(float value)
        {
            if (value < minim_cardio_actual)
                minim_cardio_actual = value;
            return minim_cardio_actual;
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

        private float getMitjanaCardio(float valor)
        {
            lectures_cardio.Add(valor);
            float suma = 0;
            foreach (float lectura in lectures_cardio)
                suma += lectura;
            return (float)Math.Round(suma / lectures_cardio.Count, 2);
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

        private float getDesviacioEstandardCardio(float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaCardio(valor), 2);
            float divisor = lectures_cardio.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float)Math.Round(resultat, 2);
        }

        private float getDesviacioEstandardMio (float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaMio(valor), 2);
            float divisor = lectures_mio.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float)Math.Round(resultat, 2);
        }

        private float getDesviacioEstandardRG(float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaRG(valor), 2);
            float divisor = lectures_rg.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float) Math.Round(resultat, 2);
        }
    }
}

