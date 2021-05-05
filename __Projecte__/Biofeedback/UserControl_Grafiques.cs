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
    public partial class UserControl_Grafiques : UserControl
    {
        // Per a la comunicació amb la BD
        List<Cardiograma_BD> _CARDIOGRAMA_BD = new List<Cardiograma_BD>();

        private ChartValues<Cardiograma> _dadesCardiograma { get; set; }
        private Timer _Timer { get; set; }
        public Random _R { get; set; }
        private ChartValues<Miograma> _dadesMiograma { get; set; }
        private ChartValues<RespostaGalvanica> _dadesRG { get; set; }

        float _minim_cardio_actual = 9999;
        float _minim_mio_actual = 9999;
        float _minim_rg_actual = 9999;

        float _maxim_cardio_actual = 0;
        float _maxim_mio_actual = 0;
        float _maxim_rg_actual = 0;

        float _mitjana_cardio = 0;
        float _mitjana_mio = 0;
        float _mitjana_rg = 0;

        float _sd_cardio = 0;
        float _sd_mio = 0;
        float _sd_rg = 0;

        List<float> _lectures_cardio = new List<float>();
        List<float> _lectures_mio = new List<float>();
        List<float> _lectures_rg = new List<float>();

        public UserControl_Grafiques()
        {
            InitializeComponent();

            ocultaValors();

            construirCardiograma();
            construirMiograma();
            construirRespostaGalvanica();
        }

        private void ocultaValors()
        {
            maxCardio.Text = "-";
            minCardio.Text = "-";
            mitjanaCardio.Text = "-";
            sdCardio.Text = "-";

            maxMio.Text = "-";
            minMio.Text = "-";
            mitjanaMio.Text = "-";
            sdMio.Text = "-";

            maxRG.Text = "-";
            minRG.Text = "-";
            mitjanaRG.Text = "-";
            sdRG.Text = "-";
        }

        private void construirCardiograma_tmp()
        {


            var mapper = Mappers.Xy<Cardiograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Cardiograma>(mapper);

            //the dadesCardiograma property will store our values array
            _dadesCardiograma = new ChartValues<Cardiograma>();
            cardiograma.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = _dadesCardiograma,
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
            _Timer = new Timer
            {
                Interval = 1000
            };
            _Timer.Tick += TimerOnTick;
            _R = new Random();
            _Timer.Start();
        }

        private void construirCardiograma()
        {
            lecturaCardio.Text = "-";

            var mapper = Mappers.Xy<Cardiograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Cardiograma>(mapper);

            //the dadesMiograma property will store our values array
            _dadesCardiograma = new ChartValues<Cardiograma>();
            cardiograma.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = _dadesCardiograma,
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
            Connexio_Singleton.getInstance().nouEventCardiograma += mostraLecturesArduinoCardio;
        }

        private void construirMiograma()
        {
            var mapper = Mappers.Xy<Miograma>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Miograma>(mapper);

            //the dadesMiograma property will store our values array
            _dadesMiograma = new ChartValues<Miograma>();
            miograma.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = _dadesMiograma,
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
            Connexio_Singleton.getInstance().nouEventMiograma += mostraLecturesArduinoMio;
        }

        private void construirRespostaGalvanica()
        {
            var mapper = Mappers.Xy<RespostaGalvanica>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<RespostaGalvanica>(mapper);

            //the dadesRG property will store our values array
            _dadesRG = new ChartValues<RespostaGalvanica>();
            respostaGalvanica.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = _dadesRG,
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
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += mostraLecturesArduinoRG;
        }

        private void mostraLecturesArduinoCardio(string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            _dadesCardiograma.Add(new Cardiograma
            {
                DateTime = now,
                Value = conversio
            });

            // S'elimina el que ja no es veu a la gràfica perquè no s'acumulin dades innecessàries
            if (_dadesCardiograma.Count > 20) _dadesCardiograma.RemoveAt(0);

            lecturaCardio.Invoke((MethodInvoker)(() => lecturaCardio.Text = s)); // Aquest MothodInvoker evita que la interfície sigui cridada per un thread 

            SetAxisLimitsCardio(System.DateTime.Now);


            maxCardio.Invoke((MethodInvoker)(() => maxCardio.Text = "-"));
            minCardio.Invoke((MethodInvoker)(() => minCardio.Text = "-"));
            mitjanaCardio.Invoke((MethodInvoker)(() => mitjanaCardio.Text = "-"));
            sdCardio.Invoke((MethodInvoker)(() => sdCardio.Text = "-"));
        }

        private void mostraValorsArduinoCardio(string s)
        {
            double conversio;
            double.TryParse(s, out conversio);

            float max = getMaximCardio((float)conversio);
            maxCardio.Invoke((MethodInvoker)(() => maxCardio.Text = max.ToString()));

            float min = getMinimCardio((float)conversio);
            minCardio.Invoke((MethodInvoker)(() => minCardio.Text = min.ToString()));

            float mitjana = getMitjanaCardio((float)conversio);
            mitjanaCardio.Invoke((MethodInvoker)(() => mitjanaCardio.Text = mitjana.ToString()));
            _mitjana_cardio = mitjana;

            float sd = getDesviacioEstandardCardio((float)conversio);
            sdCardio.Invoke((MethodInvoker)(() => sdCardio.Text = sd.ToString()));
            _sd_cardio = sd;
        }

        private void mostraLecturesArduinoMio (string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            _dadesMiograma.Add(new Miograma
            {
                DateTime = now,
                Value = conversio
            });

            // S'elimina el que ja no es veu a la gràfica perquè no s'acumulin dades innecessàries
            if (_dadesMiograma.Count > 20) _dadesMiograma.RemoveAt(0);

            lecturaMio.Invoke((MethodInvoker)(() => lecturaMio.Text = s)); // Aquest MothodInvoker evita que la interfície sigui cridada per un thread 

            SetAxisLimitsMiograma(System.DateTime.Now);

            maxMio.Invoke((MethodInvoker)(() => maxMio.Text = "-"));
            minMio.Invoke((MethodInvoker)(() => minMio.Text = "-"));
            mitjanaMio.Invoke((MethodInvoker)(() => mitjanaMio.Text = "-"));
            sdMio.Invoke((MethodInvoker)(() => sdMio.Text = "-"));
        }

        private void mostraValorsArduinoMio(string s)
        {
            double conversio;
            double.TryParse(s, out conversio);

            float max = getMaximMio((float)conversio);
            maxMio.Invoke((MethodInvoker)(() => maxMio.Text = max.ToString()));

            float min = getMinimMio((float)conversio);
            minMio.Invoke((MethodInvoker)(() => minMio.Text = min.ToString()));

            float mitjana = getMitjanaMio((float)conversio);
            mitjanaMio.Invoke((MethodInvoker)(() => mitjanaMio.Text = mitjana.ToString()));
            _mitjana_mio = mitjana;

            float sd = getDesviacioEstandardMio((float)conversio);
            sdMio.Invoke((MethodInvoker)(() => sdMio.Text = sd.ToString()));
            _sd_mio = sd;
        }

        private void mostraLecturesArduinoRG(string s)
        {
            var now = System.DateTime.Now;
            double conversio;
            double.TryParse(s, out conversio);

            _dadesRG.Add(new RespostaGalvanica
            {
                DateTime = now,
                Value = conversio
            });

            // S'elimina el que ja no es veu a la gràfica perquè no s'acumulin dades innecessàries
            if (_dadesRG.Count > 40) _dadesRG.RemoveAt(0);

            lecturaRG.Invoke((MethodInvoker)(() => lecturaRG.Text = s));

            SetAxisLimitsRG(System.DateTime.Now);

            maxRG.Invoke((MethodInvoker)(() => maxRG.Text = "-"));
            minRG.Invoke((MethodInvoker)(() => minRG.Text = "-"));
            mitjanaRG.Invoke((MethodInvoker)(() => mitjanaRG.Text = "-"));
            sdRG.Invoke((MethodInvoker)(() => sdRG.Text = "-"));
        }

        private void mostraValorsArduinoRG(string s)
        {
            double conversio;
            double.TryParse(s, out conversio);

            float max = getMaximRG((float)conversio);
            maxRG.Invoke((MethodInvoker)(() => maxRG.Text = max.ToString()));

            float min = getMinimRG((float)conversio);
            minRG.Invoke((MethodInvoker)(() => minRG.Text = min.ToString()));

            float mitjana = getMitjanaRG((float)conversio);
            mitjanaRG.Invoke((MethodInvoker)(() => mitjanaRG.Text = mitjana.ToString()));
            _mitjana_rg = mitjana;

            float sd = getDesviacioEstandardRG((float)conversio);
            sdRG.Invoke((MethodInvoker)(() => sdRG.Text = sd.ToString()));
            _sd_rg = sd;
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
            int random = _R.Next(0, 10);

            _dadesCardiograma.Add(new Cardiograma
            {
                DateTime = now,
                Value = random
            });

            SetAxisLimits(now);

            //lets only use the last 15 values
            if (_dadesCardiograma.Count > 15) _dadesCardiograma.RemoveAt(0);

            lecturaCardio.Text = random.ToString();
        }

        private void lectures_Click(object sender, EventArgs e)
        {

        }

        private float getMaximCardio(float value)
        {
            if (value > _maxim_cardio_actual)
                _maxim_cardio_actual = value;
            return _maxim_cardio_actual;
        }

        private float getMaximMio(float value)
        {
            if (value > _maxim_mio_actual)
                _maxim_mio_actual = value;
            return _maxim_mio_actual;
        }

        private float getMaximRG(float value)
        {
            if (value > _maxim_rg_actual)
                _maxim_rg_actual = value;
            return _maxim_rg_actual;
        }

        private float getMinimCardio(float value)
        {
            if (value < _minim_cardio_actual)
                _minim_cardio_actual = value;
            return _minim_cardio_actual;
        }

        private float getMinimMio(float value)
        {
            if (value < _minim_mio_actual)
                _minim_mio_actual = value;
            return _minim_mio_actual;
        }

        private float getMinimRG(float value)
        {
            if (value < _minim_rg_actual)
                _minim_rg_actual = value;
            return _minim_rg_actual;
        }

        private float getMitjanaCardio(float valor)
        {
            _lectures_cardio.Add(valor);
            float suma = 0;
            foreach (float lectura in _lectures_cardio)
                suma += lectura;
            return (float)Math.Round(suma / _lectures_cardio.Count, 2);
        }

        private float getMitjanaMio(float valor)
        {
            _lectures_mio.Add(valor);
            float suma = 0;
            foreach (float lectura in _lectures_mio)
                suma += lectura;
            return (float)Math.Round(suma / _lectures_mio.Count, 2);
        }

        private float getMitjanaRG(float valor)
        {
            _lectures_rg.Add(valor);
            float suma = 0;
            foreach (float lectura in _lectures_rg)
                suma += lectura;
            return (float)Math.Round(suma / _lectures_rg.Count, 2);
        }

        private float getDesviacioEstandardCardio(float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaCardio(valor), 2);
            float divisor = _lectures_cardio.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float)Math.Round(resultat, 2);
        }

        private float getDesviacioEstandardMio (float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaMio(valor), 2);
            float divisor = _lectures_mio.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float)Math.Round(resultat, 2);
        }

        private float getDesviacioEstandardRG(float valor)
        {
            float divident = (float)Math.Pow(valor - getMitjanaRG(valor), 2);
            float divisor = _lectures_rg.Count - 1;
            float resultat = (float)Math.Sqrt(divident / divisor);
            return (float) Math.Round(resultat, 2);
        }

        private void botoInicia_Click(object sender, EventArgs e)
        {
            Connexio_Singleton.getInstance().nouEventCardiograma += mostraValorsArduinoCardio;
            Connexio_Singleton.getInstance().nouEventMiograma += mostraValorsArduinoMio;
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += mostraValorsArduinoRG;          
        }

        private void botoFinalitza_Click(object sender, EventArgs e)
        {
            // Carregar el resum estadístic a la BD
            SqliteDataAccess.desaValorsCardiograma_BD((int)_minim_cardio_actual, (int)_maxim_cardio_actual, _mitjana_cardio, _sd_cardio);
            SqliteDataAccess.desaValorsMiograma_BD((int)_minim_mio_actual, (int)_maxim_mio_actual, _mitjana_mio, _sd_mio);
            SqliteDataAccess.desaValorsRG_BD((int)_minim_rg_actual, (int)_maxim_rg_actual, _mitjana_rg, _sd_rg);

            // S'escriu "-" al resum estadístic de cada sensor instantàniament
            ocultaValors();            

            // Es manté el valor "-" per molt que l'Arduino enviï més dades
            Connexio_Singleton.getInstance().nouEventCardiograma += mostraLecturesArduinoCardio;
            Connexio_Singleton.getInstance().nouEventMiograma += mostraLecturesArduinoMio;
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += mostraLecturesArduinoRG;
        }

        private void botoAnula_Click(object sender, EventArgs e)
        {
            // S'escriu "-" al resum estadístic de cada sensor instantàniament
            ocultaValors();

            // Es manté el valor "-" per molt que l'Arduino enviï més dades
            Connexio_Singleton.getInstance().nouEventCardiograma += mostraLecturesArduinoCardio;
            Connexio_Singleton.getInstance().nouEventMiograma += mostraLecturesArduinoMio;
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += mostraLecturesArduinoRG;
        }

        private void minRG_Click(object sender, EventArgs e)
        {

        }
    }
}

