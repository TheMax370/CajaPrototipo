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
    public partial class CustomDeposit : Form
    {
        public string Usuario { get; set; }
        
        public CustomDeposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbo_monto.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                decimal monto = Database.ObtenerMonto(Usuario);

                decimal m = decimal.Parse(tbo_monto.Text);


                monto = monto + m;

                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Deposito", m, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("depósito con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                this.Hide();

                if (res == DialogResult.Yes)
                {
                    Recibo r = new Recibo();
                    r.Usuario = Usuario;
                    r.total_monto = monto;
                    r.monto = m;
                    r.transaccion = "Deposito";
                    r.ShowDialog();

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
