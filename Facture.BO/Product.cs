using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Product : BaseModel
    {
        public string Reference { get; set; }
        public float Price { get; set; }
        public float Priceone { get; set; }
        public int quantity { get; set; }
        public float TVA { get; set; }
        public string date { get; set; }

        public Product(string id, string name, string reference, float priceone, int quantity,float tva)
        {
            TVA = tva;
            Id = id;
            Name = name;
            Reference = reference;
            Price = (priceone *quantity)+(priceone*tva);
            Priceone = priceone;
            this.quantity = quantity;
            date = DateTime.Now.Date.ToString();
        }
    }
}
