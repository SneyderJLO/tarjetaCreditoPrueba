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
    public partial class envia : Form
    {
        public envia()
        {
            InitializeComponent();
        }

        private void btn_envia_Click(object sender, EventArgs e)
        {
            recibe recibe = new recibe();
            recibe.txt_recibe.Text = txt_envia.Text;
            recibe.Show();
        }
    }
}
