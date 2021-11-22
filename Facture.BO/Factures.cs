using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Factures
    {
        public int BillNumber { get; set; }

        public Factures()
        {
            Random random = new Random();
            BillNumber = random.Next(500);
        }
    }
}
