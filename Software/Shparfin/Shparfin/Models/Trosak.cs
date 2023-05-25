using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shparfin.Models
{
    public class Trosak
    {
        public int IdTrosak { get; set; }

        public string Komentar {get; set; }

        public int Iznos { get; set; }

        public DateTime Datum { get; set; }

        public int IdPodKategorijaTrosak { get; set; }

        public int IdKorisnik { get; set; }

        public int IdKategorijaTrosak {get; set; }


    }
}
