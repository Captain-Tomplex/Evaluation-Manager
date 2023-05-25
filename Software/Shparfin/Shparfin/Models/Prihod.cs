using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shparfin.Models
{
    public class Prihod
    {
        public int IdPrihod { get; set; }

        public string Komentar { get; set; }

        public int Iznos { get; set; }

        public DateTime Datum { get; set; }

        public int IdKategorijaPrihod { get; set; }
    }
}
