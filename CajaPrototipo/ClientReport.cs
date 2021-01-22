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

namespace CajaPrototipo
{
    public partial class ClientReport : Form
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        public string Usuario { get; internal set; }

        public void ClientReport_Load()
        {
            this.reportViewer1.RefreshReport();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet5",Database.ObtenerCliente2(tbo_cedula.Text));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Alan\\Desktop\\CajaPrototipo\\CajaPrototipo\\Report5.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {

        }
    }
}
