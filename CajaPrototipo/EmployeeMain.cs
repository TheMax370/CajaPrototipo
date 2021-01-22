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
    public partial class EmployeeMain : Form
    {
        public string Usuario { get; set; }

        public EmployeeMain()
        {
            InitializeComponent();
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            Program.log.Info("Search Account: Search Account Form");

            lbl_name.Text = "Bienvenido " + Database.ObtenerNombreDeUsuario(Usuario);
        }

        private void plazaTransBtn_Click(object sender, EventArgs e)
        {
            Program.log.Info("Main: Transaccions");

            Transacciones t = new Transacciones();
            t.Usuario = Usuario;
            t.Transaaccines_Load();
            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(t.disp_panel);
            //t.ShowDialog();
        }

        private void prestamoBtn_Click(object sender, EventArgs e)
        {

            BuscarCedula t = new BuscarCedula();
            BuscarCedula.Usuario = Usuario;
            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(t.panel2);
        }

        private void ClientReport_Click(object sender, EventArgs e)
        {
            ClientReport cr = new ClientReport();
            this.disp_panel.Controls.Clear();
            this.disp_panel.Controls.Add(cr.panel1);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
    }
}
