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
    public partial class CustomRetrio : Form
    {
        public CustomRetrio()
        {
            InitializeComponent();
        }

        public string Usuario { get; internal set; }


        private void retiroBtn_Click(object sender, EventArgs e)
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


                monto = monto - m;


                BuscarCedula.updateAmount(m, "dretiro");

                if (monto < m)
                {

                    Program.log.Info("Retiro : Failed to withdaw - Not enough amount in account number = " + Usuario);

                    MessageBox.Show("Lo siento .No hay suficiente dinero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Retiro", m, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("Retiro con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                string mail = "-----------------------\n" +
                        "Transacción: Retiro\n" +
                        "Monto       : " + m + "\n" +
                        "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                        "Monto Total : " + monto + "\n" +
                        "----------------------\n" +
                        "Gracias por usar cajero automático";

                string toEmail = Database.getEmail(Usuario);

                SendReceipt.Send_Email(toEmail, mail);

                Program.log.Info("Retiro : " + m + " withdraw from account number = " + Usuario);

                this.Hide();

                if (res == DialogResult.Yes)
                {
                    Recibo r = new Recibo();
                    r.Usuario = Usuario;
                    r.total_monto = monto;
                    r.monto = m;
                    r.transaccion = "Retiro";
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
