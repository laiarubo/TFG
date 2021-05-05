using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;




namespace ContingutBD
{
    public class SqliteDataAccess
    {
        public static void desaValorsCardiograma_BD(int min, int max, float x, float sd) 
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Cardiograma_BD(minim,maxim,mitjana,sd) VALUES({min},{max},{x},{sd})", conn);
                //SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Cardiograma_BD(minim,maxim) VALUES(" + min.ToString() + "," + max.ToString() + ")", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }   
        }

        public static void desaValorsMiograma_BD(int min, int max, float x, float sd) 
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Miograma_BD(minim,maxim,mitjana,sd) VALUES({min},{max},{x},{sd})", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void desaValorsRG_BD(int min, int max, float x, float sd) 
        {
            using (SQLiteConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO RespostaGalvanica_BD(minim,maxim,mitjana,sd) VALUES({min},{max},{x},{sd})", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<QuadernModel> LoadQuadern()
        {            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // garanteix que el tancament sempre farà correctament la desconnexió amb la BD
            {
                var output = cnn.Query<QuadernModel>("SELECT * FROM Quadern", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void DesaQuadern(QuadernModel q)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // @Missatge correspon a la public string de QuadernModel.cs
                cnn.Execute("INSERT INTO Quadern (Missatge) VALUES (@Missatge)", q);
            }
        }

        public static void DesaApunts(Apunts a)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // @text correspon a la public string de Apunts.cs
                cnn.Execute("INSERT INTO Apunts (text) VALUES (@text)", a);
            }
        }

        public static void DesaLecturesMio(LecturesMio valor)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO LecturesMio (valor) VALUES (@valor)", valor);
            }
        }

        //public static List<LecturesMio> getMaximLecturesMio()
        //{
        //    //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    //{
        //    //    var output = cnn.Query<LecturesMio>("SELECT MAX (valor) FROM LecturesMio", new DynamicParameters());
        //    //}
        //    //return output;
        //}


        private static string LoadConnectionString(string id = "Default")
        {
            // Això va a l'App.config de Biofeedback i mira els paràmetres de "connectionStrings". Llavors retorna tot allò que conté la connectionString (la ruta relativa de la bd)
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
