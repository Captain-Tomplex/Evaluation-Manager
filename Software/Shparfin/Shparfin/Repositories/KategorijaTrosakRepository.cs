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
    public class KategorijaRepository
    {
        public static List<KategorijaTrosak> GetKategorije()
        {
            List<KategorijaTrosak> kategorije = new List<KategorijaTrosak>();
            string sql = "SELECT * FROM KategorijaTrosak";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                KategorijaTrosak kategorija = CreateObject(reader);
                kategorije.Add(kategorija);
            }
            reader.Close();
            DB.CloseConnection();
            return kategorije;
        }

        public static KategorijaTrosak CreateObject(SqlDataReader reader)
        {
            int idKategorijaTrosak = int.Parse(reader["IdKategorijaTrosak"].ToString());
            string naziv = reader["NazivKategorijaTrosak"].ToString();


            var kategorija = new KategorijaTrosak
            {
                IdKategorijaTrosak = idKategorijaTrosak,
                Naziv = naziv,
                
            };
            return kategorija;

        }
    }
}
