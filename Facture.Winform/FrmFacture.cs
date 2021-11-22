using Facture.BLL;
using Facture.BO;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmFacture : Form
    {
        List<Factures> factures;
        ProductManager manager;
        List<Client> clients;

        public FrmFacture()
        {
            factures = new List<Factures>();
            clients = new List<Client>();
            manager = new ProductManager();
            InitializeComponent();
        }

        private void FrmFacture_Load(object sender, EventArgs e)
        {
            clients.Add(Program.clients);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetProduct", Program.products)
                );
            this.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetFacture", factures)
                );
            this.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetClient", clients)
                );
            this.reportViewer1.LocalReport.ReportPath = "RpFacture.rdlc";
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
