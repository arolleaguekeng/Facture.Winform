using Facture.BLL;
using Facture.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.Winform
{
    public partial class FrmHistoric : Form
    {
        List<Client> clients;
        List<Product> products;
        ClientManager manager;
        public FrmHistoric()
        {
            manager = new ClientManager();
            clients = new List<Client>();
            products = new List<Product>();
            InitializeComponent();
        }

        private void FrmRemoveProduct_Load(object sender, EventArgs e)
        {
            clients = manager.GetClients();
            foreach (var cli in clients)
            {
                products = cli.Products;
            }


            foreach (var client in clients)
            {
                try
                {
                    ListViewItem lvi = new ListViewItem(new string[] { client.Id, client.Name.ToString(), client.PhoneNumber.ToString() });
                    lvi.Tag = client;
                    lvClient.Items.Add(lvi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowClientProducts()
        {
            foreach (var produc in products)
            {
                try
                {
                    ListViewItem lvi = new ListViewItem(new string[] { produc.Name, produc.quantity.ToString(), produc.Priceone.ToString(), produc.Price.ToString() });
                    lvi.Tag = produc;
                    lvShowprod.Items.Add(lvi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lvClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var client = lvClient.SelectedItems[0].Tag as Client;
                products = client.Products.ToList();
                lvShowprod.Items.Clear();
                ShowClientProducts();
            }
            catch
            {
                
            }

        }
    }
}
