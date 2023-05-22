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
            string sql = "SELECT * FROM Students";
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
            int id = int.Parse(reader["Id"].ToString());
            string kategorija = reader["Kategorija"].ToString();
            string komentar = reader["Komentar"].ToString();
            int iznos = int.Parse(reader["Iznos"].ToString());
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            
            var trosak = new Trosak
            {
                Id = id,
                Kategorija = kategorija,
                Komentar = komentar,
                Iznos = iznos,
                Datum = datum
            };
            return trosak;
        }


    }
}
