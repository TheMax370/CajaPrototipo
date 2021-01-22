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
    public partial class Cuentas : Form
    {
        internal DataSet clientes;

        public Cuentas()
        {
            InitializeComponent();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {

            Program.log.Info("Accounts: Accounts Form");

            dataGridView1.DataSource = clientes.Tables[0].DefaultView;

            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowNo = dataGridView1.CurrentCell.RowIndex;

            string AccNo = dataGridView1.Rows[rowNo].Cells[4].Value.ToString();

            Program.log.Info("Accounts: Selected Account Number = "+AccNo);

            this.Hide();
            Main main = new Main();
            main.Usuario = AccNo;
            main.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
