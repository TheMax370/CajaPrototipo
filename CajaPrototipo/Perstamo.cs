using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaPrototipo
{
    public partial class Perstamo : Form
    {
        public Perstamo()
        {
            InitializeComponent();
        }

        decimal[] loans;

        public string Usuario { get; internal set; }

        public void Perstamo_Load()
        {

            panel1.Controls.Clear();

            loans = Database.getLoan(Usuario);

            if (loans == null)
                return;

            CustButton[] buttons = new CustButton[loans.Length];

            for (int j = 0; j < loans.Length; j++)
            {
                buttons[j] = new CustButton();
                buttons[j].Text = loans[j] + "";
                buttons[j].Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); ;
                buttons[j].Top = 70 * (j + 1);
                buttons[j].OnHoverTextColor = System.Drawing.Color.White;
                buttons[j].Left = 50;
                buttons[j].Width = 170;
                buttons[j].Height = 60;

                buttons[j].Click += new EventHandler(button_Clicked);


                panel1.Controls.Add(buttons[j]);
            }

        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            for (int i = 0; i < loans.Length; i++) 
            {
                if (btn.Text.Equals(loans[i] + ""))
                {
                    pagarPerstamo(loans[i]);
                }
            }

            Perstamo_Load();

        }

        private void pagarPerstamo(decimal m)
        {
            try
            {


                decimal monto = Database.ObtenerMonto(Usuario);

                if (monto < m)
                {

                    MessageBox.Show("Lo siento .No hay suficiente dinero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                monto = monto - m;

                BuscarCedula.updateAmount(m, "retiro");

                Database.ActualizarMonto(Usuario, monto);
                Database.AgregarTransaccion(Usuario, "Pagar Perstmo", m, DateTime.Now.ToString("M/d/yyyy"));

                DialogResult res = MessageBox.Show("Préstamo pagado con éxito. Quieres imprimir un recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                Database.deleteDayTrans(Usuario,m);

                string mail = "-----------------------\n" +
                        "Transacción: Pagar Perstamo\n" +
                        "Monto       : " + m + "\n" +
                        "Date: " + DateTime.Now.ToString("M/d/yyyy") + "\n" +
                        "Monto Total : " + monto + "\n" +
                        "----------------------\n" +
                        "Gracias por usar cajero automático";

                string toEmail = Database.getEmail(Usuario);
                
                SendReceipt.Send_Email(toEmail, mail);
                
                Program.log.Info("Perstamo : " + m + " Loan Paid of account = "+Usuario);

                this.Hide();

                if (res == DialogResult.Yes)
                {
                    Recibo r = new Recibo();
                    r.Usuario = Usuario;
                    r.total_monto = monto;
                    r.monto = m;
                    r.transaccion = "Pagar Perstmo";
                    r.ShowDialog();

                }

            }
            catch (Exception ex)
            {

                Program.log.Error(ex.Message, ex);

                throw;
            }
        }

        private void Perstamo_Load(object sender, EventArgs e)
        {

        }
    }
}
