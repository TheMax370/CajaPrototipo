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
    public partial class Recibo : Form
    {
        
        public Recibo()
        {
            InitializeComponent();
        }

        public string Usuario { get; set; }
        public string transaccion { get; set; }
        public decimal monto { get; set; }
        public decimal total_monto { get; set; }

        private void Recibo_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("M/d/yyyy");
            lbl_cue.Text = Usuario;
            lbl_monto.Text = monto+"";
            lbl_total.Text = total_monto+"";
            lbl_transaccion.Text = transaccion;

        }
    }
}
