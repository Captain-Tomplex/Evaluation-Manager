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


            var trosak = new Trosak
            {
                IdTrosak = idTrosak,
                Komentar = komentar,
                Iznos = iznos,
                Datum = datum,
                IdKategorijaTrosak = idKategorijaTrosak,
            };
            return trosak;

        }



        
    }
}
