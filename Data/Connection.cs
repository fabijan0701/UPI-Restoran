using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UPI_Restoran.Data;
using UPI_Restoran.Data.Other;

namespace UPI_Restoran.Data
{

    /// <summary>
    /// Obavlja komunikaciju sa bazom podataka
    /// </summary>
    public static class Connection
    {
        //Backup link
        //private static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ante\\Desktop\\UPI Restoran\\UPI Restoran\\bin\\Debug\\DB.mdf\";Integrated Security=True;Connect Timeout=30";
        
        
        /// <summary>
        /// String preko kojega se spajamo na bazu
        /// </summary>
        private static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Environment.CurrentDirectory +  "\\DB.mdf\";Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Vraća sve rezervacije u odredenom vremenskom intervalu
        /// </summary>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        /// <returns></returns>
        public static List<Rezervacija> ŞQL_Rezervacije(DateTime pocetak, DateTime kraj)
        {
            List<Rezervacija> returnList = new List<Rezervacija>();

            string sqlPocetak = pocetak.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlKraj = kraj.ToString("yyyy - MM - dd HH: mm:ss.fff");

            string sql = String.Format(
                "SELECT " + 
                "G.BROJ_OSOBNE, G.IME, G.PREZIME, RG.KONTAKT, " + 
                "S.BROJ, P.NAZIV, K.NAZIV, " +
                "R.BROJ, R.POCETAK, R.KRAJ " +
            "FROM REZERVACIJA R INNER JOIN GOST G ON G.BROJ_OSOBNE = R.BROJ_OSOBNE " +
            "INNER JOIN STOL S ON R.STOL_ID = S.BROJ " +
            "INNER JOIN POZICIJA P ON P.ID = S.POZICIJA " +
            "INNER JOIN KLASA K ON K.ID = S.KLASA_ID " +
            "INNER JOIN REZERVACIJA_GOST RG ON G.BROJ_OSOBNE = RG.ID_GOST " +
            "WHERE R.POCETAK >= '{0}' AND R.KRAJ <= '{1}' ORDER BY R.POCETAK",
                sqlPocetak, sqlKraj);

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                int brOsob = r.GetInt32(0);
                string oIme = r.GetString(1);
                string oPrezime = r.GetString(2);
                string oKontakt = r.GetString(3);
                Gost g = new Gost(brOsob, oIme, oPrezime);
                g.Kontakti.Add(oKontakt);

                int brStol = r.GetInt32(4);
                string pozStol = r.GetString(5);
                string klasaStol = r.GetString(6);
                Stol s = new Stol(brStol, klasaStol, pozStol);

                int rezBr = r.GetInt32(7);
                DateTime rezPoc = r.GetDateTime(8);
                DateTime rezKraj = r.GetDateTime(9);

                Rezervacija rez = new Rezervacija(rezBr, g, s, rezPoc, rezKraj, oKontakt);
                returnList.Add(rez);
            }
            connection.Close();
    
            return returnList;
        }
    
        /// <summary>
        /// Vraca sve dostupne stolove koji nisu rezervirani u određenom vremenskom
        /// </summary>
        /// <param name="pocetak"></param>
        /// <param name="kraj"></param>
        /// <returns></returns>
        public static List<Stol> SQL_Stolovi(DateTime pocetak, DateTime kraj)
        {
            List<Stol> list = new List<Stol>();

            string sqlPocetak = pocetak.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlKraj = kraj.ToString("yyyy - MM - dd HH: mm:ss.fff");

            string SQL = String.Format(
                   "SELECT S.BROJ, K.NAZIV, P.NAZIV FROM STOL S " +
                   "INNER JOIN POZICIJA P ON S.POZICIJA = P.ID " +
                   "INNER JOIN KLASA K ON S.KLASA_ID = K.ID " +
                   "WHERE S.BROJ NOT IN( " +
                   "SELECT R.STOL_ID FROM REZERVACIJA R " +
                   "WHERE R.POCETAK >= '{0}' OR R.KRAJ <= '{1}')",
                    sqlPocetak, sqlKraj);

            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQL, connection);

            connection.Open();
            SqlDataReader r = command.ExecuteReader();
            while(r.Read())
            {
                int br = r.GetInt32(0);
                string klasa = r.GetString(1);
                string pozicija = r.GetString(2);

                Stol s = new Stol(br, klasa, pozicija);
                list.Add(s);
            }

            return list;
        }
   
        /// <summary>
        /// Vraca listu svih gostiju iz baze podataka
        /// </summary>
        /// <returns></returns>
        public static List<Gost> SQL_Gosti()
        {
            List<Gost> gosti = new List<Gost>();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string SQL = "SELECT * FROM GOST";
            SqlCommand command = new SqlCommand(SQL, connection);

            connection.Open();
            SqlDataReader r = command.ExecuteReader();
            while(r.Read())
            {
                int brojOsobne = r.GetInt32(0);
                string ime = r.GetString(1);
                string prezime = r.GetString(2);

                Gost g = new Gost(brojOsobne ,ime, prezime);
                gosti.Add(g);
            }
            connection.Close();
            return gosti;
        }
    
        /// <summary>
        /// Dodaje novog gosta u bazu podataka
        /// </summary>
        /// <param name="g"> reprezentira novog gosta koji se dodaje u bazu podataka</param>
        public static void SQL_DodajGosta(Gost g)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string SQL = String.Format("INSERT INTO GOST VALUES ({0}, '{1}', '{2}')",
                g.BrojOsobne, g.Ime, g.Prezime);

            SqlCommand command = new SqlCommand(SQL, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    
        /// <summary>
        /// Dodaje novu rezervaciju (bez id-a, jer njega definira baza podataka) u bazu podataka 
        /// </summary>
        /// <param name="r"></param>
        public static void SQL_DodajRezervaciju(Rezervacija r)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string sqlPocetak = r.Pocetak.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlKraj = r.Kraj.ToString("yyyy - MM - dd HH: mm:ss.fff");

            string SQL_1 = String.Format(
                "INSERT INTO REZERVACIJA VALUES({0}, {1}, '{2}', '{3}')",
                r.Gost.BrojOsobne, r.Stol.Broj, sqlPocetak, sqlKraj);

            SqlCommand command = new SqlCommand(SQL_1, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            string SQL_2 = String.Format(
                "SELECT BROJ FROM REZERVACIJA R WHERE R.POCETAK = '{0}' AND R.KRAJ = '{1}'",
                sqlPocetak, sqlKraj);

            connection.Open();
            command = new SqlCommand(SQL_2, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int rez_id = reader.GetInt32(0);
            connection.Close();

            string SQL_3 = String.Format(
                "INSERT INTO REZERVACIJA_GOST VALUES({0}, {1}, '{2}')",
                rez_id, r.Gost.BrojOsobne, r.Kontakt);
            command = new SqlCommand(SQL_3, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    
        /// <summary>
        /// Briše rezervaciju iz baze podataka uključujući i podatke o vezama gosta i rezervacije.
        /// </summary>
        /// <param name="br"> predstavlja broj rezervacije koju brišemo</param>
        public static void SQL_ObrisiRezervaciju(int br)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string SQL = "DELETE FROM REZERVACIJA WHERE BROJ = " + br;

            SqlCommand command = new SqlCommand(SQL, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            string SQL_2 = "DELETE FROM REZERVACIJA_GOST WHERE ID_REZERVACIJA = " + br;

            command = new SqlCommand(SQL_2, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
