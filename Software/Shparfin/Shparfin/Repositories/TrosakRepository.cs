using DBLayer;
using Shparfin.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shparfin.Repositories
{
    public class TrosakRepository
    {

        public static Trosak GetTrosak(int id)
        {
            Trosak trosak = null;
            string sql = $"SELECT * FROM Trosak WHERE idTrosak = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                trosak = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return trosak;
        }


        public static List<Trosak> GetTroskove()
        {
            List<Trosak> troskovi = new List<Trosak>();
            string sql = "SELECT * FROM Trosak";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Trosak trosak = CreateObject(reader);
                troskovi.Add(trosak);
            }
            reader.Close();
            DB.CloseConnection();
            return troskovi;
        }

        public static Trosak CreateObject(SqlDataReader reader)
        {
            int idTrosak = int.Parse(reader["IdTrosak"].ToString());
            string komentar = reader["Komentar"].ToString();
            int iznos = int.Parse(reader["Iznos"].ToString());
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            int idKategorijaTrosak = int.Parse(reader["IdKategorijaTrosak"].ToString());
            int idPodKategorijaTrosak = int.Parse(reader["IdPodKategorijaTrosak"].ToString());
            int idKorisnik = int.Parse(reader["IdKorisnik"].ToString());

            var trosak = new Trosak
            {
                IdTrosak = idTrosak,
                Komentar = komentar,
                Iznos = iznos,
                Datum = datum,
                IdKategorijaTrosak = idKategorijaTrosak,
                IdPodKategorijaTrosak = idPodKategorijaTrosak,
                IdKorisnik = idKorisnik
            };
            return trosak;

        }

        public static void InsertTrosak(string komentar, string iznos, DateTime datum, int idPodKategorijaTrosak, int idKategorijaTrosak)
        {

            int idKorisnik = 1;

            string sql = $"INSERT INTO Trosak (Komentar, Iznos, Datum, IdPodKategorijaTrosak, IdKorisnik, IdKategorijaTrosak) " +
                         $"VALUES ('{komentar}', '{iznos}', '{datum.ToString("yyyy-MM-dd")}', '{idPodKategorijaTrosak}', '{idKorisnik}', '{idKategorijaTrosak}')";


            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


        public static void UpdateTrosak(Trosak trosak)
        {           

            string sql = $"UPDATE Trosak SET Komentar = '{trosak.Komentar}', Iznos = '{trosak.Iznos}', Datum = '{trosak.Datum.ToString("yyyy-MM-dd")}', IdPodKategorijaTrosak = {trosak.IdPodKategorijaTrosak}, IdKategorijaTrosak = {trosak.IdKategorijaTrosak} WHERE IdTrosak = {trosak.IdTrosak}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteTrosak(Trosak trosak)
        {
            string sql = $"DELETE FROM Trosak WHERE IdTrosak = {trosak.IdTrosak}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }



    }
}