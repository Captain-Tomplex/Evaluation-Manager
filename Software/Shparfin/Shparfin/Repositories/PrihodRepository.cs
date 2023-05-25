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
    public class PrihodRepository
    {
        public static List<Prihod> GetPrihode()
        {
            List<Prihod> prihodi = new List<Prihod>();
            string sql = "SELECT * FROM Prihod";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Prihod prihod = CreateObject(reader);
                prihodi.Add(prihod);
            }
            reader.Close();
            DB.CloseConnection();
            return prihodi;

        }

        public static Prihod CreateObject(SqlDataReader reader)
        {
            int idPrihod = int.Parse(reader["IdPrihod"].ToString());
            string komentar = reader["Komentar"].ToString();
            int iznos = int.Parse(reader["Iznos"].ToString());
            DateTime datum = DateTime.Parse(reader["Datum"].ToString());
            int idKategorijaPrihod = int.Parse(reader["IdKategorijaPrihod"].ToString());


            var prihod = new Prihod
            {
                IdPrihod = idPrihod,
                Komentar = komentar,
                Iznos = iznos,
                Datum = datum,
                IdKategorijaPrihod = idKategorijaPrihod,
            };
            return prihod;

        }
    }
}
