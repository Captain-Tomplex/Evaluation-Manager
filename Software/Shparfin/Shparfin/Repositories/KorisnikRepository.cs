using DBLayer;
using Shparfin.Models;
using System.Data.SqlClient;


namespace Shparfin.Repositories
{
    internal class KorisnikRepository
    {

        public static Korisnik GetKorisnik()
        {
            Korisnik korisnik = new Korisnik();
            string sql = $"SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                korisnik = CreateObject(reader);

            }
            reader.Close();
            DB.CloseConnection();
            return korisnik;
        }

        public static void UpdateKorisnik(Korisnik korisnik)
        {

            string sql = $"UPDATE Korisnik SET Prijava = {korisnik.Prijava} WHERE IdKorisnik = {korisnik.IdKorisnik}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static Korisnik CreateObject(SqlDataReader reader)
        {
            int idKorisnik = int.Parse(reader["IdKorisnik"].ToString());
            string uloga = reader["Uloga"].ToString();
            int prijava = int.Parse(reader["Prijava"].ToString());



            var korisnik = new Korisnik
            {
                IdKorisnik = idKorisnik,
                Uloga = uloga,
                Prijava = prijava

            };
            return korisnik;

        }
    }
}
