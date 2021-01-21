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
    public partial class Login : Form
    {

        
        private int attempt = 0;
        
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            Program.log.Debug("Initialize: Project Start");
            Program.log.Info("Login: User is logging in");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbo_usuario.Text == "")
            {
                MessageBox.Show("Por favor introduzca un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (tbo_password.Text == "")
            {
                MessageBox.Show("Por favor introduzca una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                attempt++;

                int status = Database.Login(tbo_usuario.Text, tbo_password.Text);

                if (status == 1)
                {
                    attempt = 0;

                    Program.  log.Info("Login: Employee USUARIO="+ tbo_usuario.Text + " Successfuylly Logged in");

                    this.Hide();
                    EmployeeMain ver = new EmployeeMain();
                    ver.Usuario = tbo_usuario.Text;
                    ver.ShowDialog();
                }

                else
                {
                    Program.log.Warn("Login Error: User USUARIO=" + tbo_usuario.Text + " Faild to Logged - attempt = "+attempt);
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
