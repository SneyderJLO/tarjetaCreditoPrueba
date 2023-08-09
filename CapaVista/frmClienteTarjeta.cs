using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarjetaCreditoApi.Conexion;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Hosting;

namespace CapaVista
{
    public partial class frmClienteTarjeta : Form
    {
        public frmClienteTarjeta()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "");
            }

        }
    }
}