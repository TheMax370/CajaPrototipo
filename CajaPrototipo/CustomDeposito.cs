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
    public partial class CustomDeposito : Form
    {
        public CustomDeposito()
        {
            InitializeComponent();
        }

        public string Usuario { get; internal set; }

        private void CustomDeposito_Load(object sender, EventArgs e)
        {

        }

        private void depositoBtn_Click(object sender, EventArgs e)
        {
            if (tbo_monto.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                decimal monto = Database.ObtenerMonto(Usuario);

                decimal d = decimal.Parse(tbo_monto.Text);

                monto = monto + d;

                BuscarCedula.updateAmount(d, "deposito");

                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Deposito", d, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("depósito con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                Program.log.Info("Deposito: " + d + " deposited to account number = " + Usuario);

                string mail = "-----------------------\n" +
                        "Transacción: Deposito\n" +
                        "Monto       : " + d + "\n" +
                        "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                        "Monto Total : " + monto + "\n" +
                        "----------------------\n" +
                        "Gracias por usar cajero automático";

                string toEmail = Database.getEmail(Usuario);

                SendReceipt.Send_Email(toEmail, mail);


                this.Hide();

                if (res == DialogResult.Yes)
                {
                    Recibo r = new Recibo();
                    r.Usuario = Usuario;
                    r.total_monto = monto;
                    r.monto = d;
                    r.transaccion = "Deposito";
                    r.ShowDialog();

                }

            }
            catch (Exception ex)
            {

                Program.log.Error(ex.Message, ex);

                throw;
            }
        }
    }
}
