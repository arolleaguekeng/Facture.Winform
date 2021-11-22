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
    public partial class FrmAddProduct : Form
    {
        ClientManager manager;
        List<Client> Clients;

        public FrmAddProduct()
        {
            Clients = new List<Client>();
            manager = new ClientManager();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var clien = new Client(tbClientEmail.Text, tbClientName.Text, int.Parse(tbPhoneNumber.Text), tbAddress.Text, Program.products);
                Program.clients = clien;
                foreach(var client in Clients)
                {
                     var producs = client.Products.ToList();
                    foreach (var prod in producs)
                    {
                        Program.products.Add(prod);
                    }
                }
                manager.AddClient(clien);
                manager.SaveClient();
                MessageBox.Show(clien.Name);
                MessageBox.Show("Create Succes !");
                FrmFacture facture = new FrmFacture();
                facture.ShowDialog();

            }

            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void ShowProducts()
        {
                foreach(var produc in Program.products)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Program.products.Add(new Product("res",tbName.Text, tbRef.Text, float.Parse(tbUp.Text),int.Parse(tbQuantity.Text),float.Parse(tbTva.Text)));
                lbCount.Text = Clients.Count().ToString();
                lvShowprod.Items.Clear();
                ShowProducts();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lvShowprod.SelectedItems[0].Remove();
                //var a = lvShowprod.SelectedItems[0].Tag as Product;
                //Program.products.Remove(a);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmHistoric historic = new FrmHistoric();
            historic.Show();
        }
    }
}
