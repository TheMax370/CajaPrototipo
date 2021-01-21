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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        public string Usuario { get; set; }

        private void retiro(decimal m) 
        {
            try
            {

                decimal monto = Database.ObtenerMonto(Usuario);

                if (monto < m)
                {
                    Program.log.Info("Retiro : Failed to withdaw - Not enough amount in account number = " + Usuario);

                    MessageBox.Show("Lo siento .No hay suficiente dinero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                monto = monto - m;

                BuscarCedula.updateAmount(m, "retiro");

                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Retiro", m, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("Retiro con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                Program.log.Info("Retiro : "+m+" withdraw from account number = " + Usuario);


                string mail = "-----------------------\n" +
                        "Transacción: Retiro\n" +
                        "Monto       : " + m + "\n" +
                        "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                        "Monto Total : " + monto + "\n" +
                        "----------------------\n" +
                        "Gracias por usar cajero automático";

                string toEmail = Database.getEmail(Usuario);

                this.Hide();

                SendReceipt.Send_Email(toEmail, mail);

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



  

        private void Retiro_Load(object sender, EventArgs e)
        {
             
        }


        private void Btn_1000_Click(object sender, EventArgs e)
        {
            retiro(1000);
        }

        private void Btn_500_Click(object sender, EventArgs e)
        {
            retiro(500);
        }

        private void Btn_200_Click(object sender, EventArgs e)
        {
            retiro(200);
        }

        private void Btn_1500_Click(object sender, EventArgs e)
        {
            retiro(1500);
        }

        private void Btn_2000_Click(object sender, EventArgs e)
        {
            retiro(2000);
        }

        private void custButton1_Click(object sender, EventArgs e)
        {
            CustomRetrio customRetrio = new CustomRetrio();
            customRetrio.Usuario = Usuario;
            customRetrio.ShowDialog();
        }

        private void disp_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
