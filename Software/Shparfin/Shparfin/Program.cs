using DBLayer;
using Shparfin.Models;
using Shparfin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shparfin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DB.SetConfiguration("IPS23_tanic21", "tanic21", "7_2a_Jqj");

            Korisnik k = KorisnikRepository.GetKorisnik();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(k.Prijava == 1)
            {
                Application.Run(new FrmLogin());
            }
            else
            {
                Application.Run(new FrmTroskovi());
            }


        }
    }
}
