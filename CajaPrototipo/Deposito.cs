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
    public partial class Deposito : Form
    {
        public string Usuario { get; set; }

        public Deposito()
        {
            InitializeComponent();
        }

        private void Deposito_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            deposito(200);
        }

        private void deposito(decimal d)
        {

            try
            {

                decimal monto = Database.ObtenerMonto(Usuario);


                monto = monto + d;

                Program.log.Info("Deposito: " + d + " deposited to account number = " + Usuario);

                BuscarCedula.updateAmount(d, "deposito");

                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Deposito", d, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("depósito con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                    MostrarRecibo(d, monto);

                }

            }
            catch (Exception ex)
            {

                Program.log.Error(ex.Message, ex);

                throw;
            }
        }

        private void MostrarRecibo(decimal monto,decimal total)
        {

            Recibo r = new Recibo();
            r.Usuario = Usuario;
            r.total_monto = total;
            r.monto = monto;
            r.transaccion = "Deposito";
            r.ShowDialog();

        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            deposito(500);
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {

            deposito(1000);
        }

        private void btn_1500_Click(object sender, EventArgs e)
        {

            deposito(1500);
        }

        private void btn_2000_Click(object sender, EventArgs e)
        {
            deposito(2000);
        }

        private void btn_custom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomDeposito d = new CustomDeposito();
            d.Usuario = Usuario;
            d.ShowDialog();
        }
    }
}
