using Facture.BO;
using Facture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BLL
{
    public class ClientManager
    {
        ClientRepository repository;
        public ClientManager()
        {
            repository = new ClientRepository();
        }
        public void AddClient(Client client)
        {
            repository.Add(client);
        }
        public List<Client> GetClients()
        {
            return repository.GetAll();
        }

        public void SaveClient()
        {
            repository.Save();
        }
    }
}
