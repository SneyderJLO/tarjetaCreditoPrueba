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
using TarjetaCreditoApi.ApiHelper;
using TarjetaCreditoApi.Model;
using TarjetaCreditoApi.Controllers;
using Microsoft.AspNetCore.Mvc;

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



        private void label2_Click(object sender, EventArgs e)
        {
            //Reply oReply = new Reply();

            // this.dtgDatosCliente.DataSource = oReply.Data;


            if (dtgDatosCliente.RowCount == 0)
            {
                MessageBox.Show("El cliente no existe. por lo tanto no se puede asociar tarjeta");
            }
            else
            {
                frmTarjeta frmTarjeta = new frmTarjeta();
                //this.Hide();
                // frmTarjeta.ShowDialog(); // Muestra Form2 como un diálogo modal
                frmTarjeta.cedula3.Text = txtCedula.Text;
                frmTarjeta.Show();


            }
            //this.Close(); // Cierra la aplicación cuando se cierre Form2 (si es necesario)
            //frmTarjeta.Visible = true;
        }

        private async void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                mostrar();
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
        public async void mostrar()
        {

            try
            {
                if (txtCedula.Text != "")
                {
                    int idCliente = Convert.ToInt32(txtCedula.Text);
                    string getRutaCliente = "https://localhost:7273/api/tarjetas?id=" + idCliente;
                    //Creamos el listado de Posts a llenar
                    List<MTarjeta> listado = new List<MTarjeta>();
                    Reply oReply = new Reply();
                    oReply = await Consumer.Execute<List<MTarjeta>>(getRutaCliente, methodHttp.GET, listado);

                    this.dtgDatosCliente.DataSource = oReply.Data;

                }
                else
                {
                    MessageBox.Show("Debes ingresar un valor", "Error");
                }

            }
            catch (Exception ex)
            {
                this.dtgDatosCliente.DataSource = null;
                this.dtgDatosCliente.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
        }

    }
}