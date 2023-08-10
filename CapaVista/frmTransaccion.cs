using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmTransaccion : Form
    {
        public frmTransaccion()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            frmClienteTarjeta frmClienteTar = new frmClienteTarjeta();
            frmClienteTar.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No existen transacciones.", "Transacciones");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
