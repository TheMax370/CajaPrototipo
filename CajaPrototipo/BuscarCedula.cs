using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaPrototipo
{
    public partial class BuscarCedula : Form
    {
        public static string Usuario { get; set; }
        public decimal Cerrar { get; set; }

        public BuscarCedula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.log.Info("Search Account: Searching Account by Cedula = " +tbo_cedula.Text);

            DataSet clientes = Database.ObtenerCliente(tbo_cedula.Text);
            //this.Hide();

            if (clientes.Tables.Count == 0) {

                Program.log.Info("Search Account: No Account Found"); 
                return;

            }
            Program.log.Info("Search Account: "+clientes.Tables[0].Rows.Count+" Account(s) found with Cedula = "+tbo_cedula.Text);

            Cuentas cuentas = new Cuentas();
            cuentas.clientes = clientes;
            cuentas.ShowDialog();

        }

        private void BuscarCédula_Load(object sender, EventArgs e)
        {
            Program.log.Info("Search Account: Search Account Form");

            string query = "SELECT  TOP 1 count(*) count  from tbl_TransaccionDiaria WHERE Usuario = '" + Usuario + "' and date = '" + DateTime.Now.ToString("M/d/yyyy") + "'";

            if (!Database.IsOpenCloseTransExists(query))
            {

                query = "insert into tbl_TransaccionDiaria(Usuario,date,comenzar,cerrar)values('" + Usuario + "','" +
                    DateTime.Now.ToString("M/d/yyyy") + "',50000,50000)";
                Database.InsertOpenCloseTrans(query);
                lbl_cerrar.Text = "50000.0000";

            }
            else 
            {
                decimal monto = Database.ObtenerDiaMonto(Usuario);
                lbl_cerrar.Text = monto+"";

            }

            lbl_comienzo.Text = "50000.0000";
        }

        public static void updateAmount(decimal m, string s)
        {
            decimal monto = Database.ObtenerDiaMonto(Usuario);

            if (s.Equals("deposito"))
                monto += m;

            if (s.Equals("retiro"))
                monto -= m;

            string query = "update tbl_TransaccionDiaria set cerrar = " + monto + "  where Usuario = '" + Usuario + "'";
            Database.UpdateOpenCloseTrans(query);


        }

        
    }
}
