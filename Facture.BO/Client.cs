using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Client : BaseModel
    {
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }
        public Client()
        {

        }

        public Client(string id, string name,int phoneNumber,string address,List<Product> products)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Id = id;
            Address = address;
            Products = products;
        }
    }
}
