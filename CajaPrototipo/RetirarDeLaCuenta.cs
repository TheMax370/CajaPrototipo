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
    public partial class RetirarDeLaCuenta : Form
    {
        public RetirarDeLaCuenta()
        {
            InitializeComponent();
        }

        public string Usuario { get; internal set; }

        private void retirarBtn_Click(object sender, EventArgs e)
        {
            if (tbo_monto.Text == "")
            {
                MessageBox.Show("Por favor ingrese la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbo_usuario.Text == "")
            {
                MessageBox.Show("Por favor ingrese usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                decimal fromMonto = Database.ObtenerMonto(Usuario);
                decimal toMonto = Database.ObtenerMonto(tbo_usuario.Text);

                decimal d = decimal.Parse(tbo_monto.Text);

                fromMonto = fromMonto + d;
                toMonto = toMonto - d;



                Database.ActualizarMonto(Usuario, fromMonto);
                Database.ActualizarMonto(tbo_usuario.Text, toMonto);

                Database.AgregarTransaccion(Usuario, "Retirar De La Cuenta", d, DateTime.Now.ToString("M/d/yyyy"));
                Database.AgregarTransaccion(tbo_usuario.Text, "Retiro", d, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("depósito con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                string mail = "-----------------------\n" +
                        "Transacción: Retirar De La Cuenta\n" +
                        "Monto       : " + d + "\n" +
                        "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                        "Monto Total : " + fromMonto + "\n" +
                        "----------------------\n" +
                        "Gracias por usar cajero automático";

                string toEmail = Database.getEmail(Usuario);

                SendReceipt.Send_Email(toEmail, mail);

                Program.log.Info("RetirarDeLeCuenta : "+d+" deposited to = " + tbo_usuario.Text);

                this.Hide();

                if (res == DialogResult.Yes)
                {
                    Recibo r = new Recibo();
                    r.Usuario = Usuario;
                    r.total_monto = fromMonto;
                    r.monto = d;
                    r.transaccion = "Retirar";
                    r.ShowDialog();

                }

            }
            catch (Exception ex)
            {

                Program.log.Error(ex.Message, ex);

                throw;
            }


        }

        private void RetirarDeLaCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
