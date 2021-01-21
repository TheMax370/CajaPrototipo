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
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        public string Usuario { get; internal set; }

        public void Transaaccines_Load()
        {
            Program.log.Info("Transaccions : Display All Transactions " );

            this.tbl_TransaccionTableAdapter1.Fill(this.databaseDataSet2.tbl_Transaccion);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaccións_Load(object sender, EventArgs e)
        {

        }
    }
}
