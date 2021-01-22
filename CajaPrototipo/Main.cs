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
    public partial class Main : Form
    {
        public string Usuario { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void depositoBtn_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Deposito");

            Deposito d = new Deposito();

            d.Usuario = Usuario;

            d.panel1.Left = 10;
            d.panel1.Top = 10;

            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(d.panel1);
            //dc.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Prestamo");

            Perstamo p = new Perstamo();
            p.Usuario = Usuario;

            p.disp_panel.Left = 10;
            p.disp_panel.Top = 10;

            p.Perstamo_Load();

            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(p.disp_panel);
            //dc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Retiro");

            Retiro r = new Retiro();
            r.Usuario = Usuario;

            r.disp_panel.Left = 10;
            r.disp_panel.Top = 10;

            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(r.disp_panel);
            //dc.ShowDialog();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Program.log.Info("Main: Main Form");

            lbl_name.Text = "Numero de cuenta : " + Usuario;
        }

        
        private void DepositarCuenta_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Depositar Cuenta");

            DepositarCuenta dc = new DepositarCuenta();
            dc.Usuario = Usuario;

            dc.disp_panel.Left = 10;
            dc.disp_panel.Top = 10;

            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(dc.disp_panel);
            //dc.ShowDialog();
        }

        private void RetirarDeLaCuenta_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Retirar De La Cuenta");

            RetirarDeLaCuenta dc = new RetirarDeLaCuenta();
            dc.Usuario = Usuario;

            dc.disp_panel.Left = 10;
            dc.disp_panel.Top = 10;


            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(dc.disp_panel);
            //dc.ShowDialog();
        }
    }
}
