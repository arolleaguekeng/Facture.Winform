using Facture.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.Winform
{
    static class Program
    {
        public static List<Product> products; 
        public static Client clients;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            products = new List<Product>();
            clients = new Client();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAddProduct());
        }
    }
}
