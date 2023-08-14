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
using Newtonsoft.Json;

namespace CapaVista
{
    public partial class frmClienteTarjeta : Form
    {

        public int idTarjeta { get; set; }
        public string id { get; set; }

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

                frmTarjeta.cedula3.Text = txtCedula.Text;
                frmTarjeta.ShowDialog(); // Muestra Form2 como un diálogo modal

                // frmTarjeta.ShowDialog();


            }
            //this.Close(); // Cierra la aplicación cuando se cierre Form2 (si es necesario)
            //frmTarjeta.Visible = true;
        }

        private async void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cargarDatosCliente();
            }
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarDatosCliente();
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



        private void dtgDatosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hace clic en los encabezados
            {
                DataGridViewRow selectedRow = dtgDatosCliente.Rows[e.RowIndex];
                dtgDatosCliente.Rows[e.RowIndex].Selected = true;
                // Obtener valores de las celdas
                id = selectedRow.Cells["idCliente"].Value.ToString();
                idTarjeta = int.Parse(selectedRow.Cells["idTarjeta"].Value.ToString());
                string? numeroTarjeta = selectedRow.Cells["numeroTarjeta"].Value.ToString();
                DateTime fechaExpira = DateTime.Parse(selectedRow.Cells["fechaexpira"].Value.ToString());
                string? saldoDisponible = selectedRow.Cells["cupoDisponible"].Value.ToString();
                string? cvc = selectedRow.Cells["cvv"].Value.ToString();
                this.lblNumeroTarjeta.Text = numeroTarjeta;
                this.lblFecha.Text = fechaExpira.Month + "/" + fechaExpira.Year;
                this.lblCVV.Text = cvc;
                this.lblSaldoDisponible.Text = saldoDisponible;
                // Hacer lo que necesites con los valores obtenidos
            }
        }



        private async void cargarDatosCliente()
        {
            using (HttpClient client = new HttpClient())
            {
                // Configura la base URL de tu API
                client.BaseAddress = new Uri("https://localhost:7273/");
                try
                {
                    // Realiza la llamada GET a la API y espera la respuesta
                    HttpResponseMessage response = await client.GetAsync("api/tarjetas/tarjetas?id=" + txtCedula.Text);
                    // Verifica si la respuesta es exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena JSON
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Aquí puedes procesar o mostrar el responseBody como necesites
                        List<MTarjeta> tarjetas = JsonConvert.DeserializeObject<List<MTarjeta>>(responseBody);
                        // Asigna la lista de tarjetas al DataGridView
                        if (tarjetas.Count > 0)
                        {
                            dtgDatosCliente.DataSource = tarjetas;
                        }
                        else
                        {
                            this.dtgDatosCliente.DataSource = null;
                            this.dtgDatosCliente.Rows.Clear();
                        }

                    }
                    else
                    {
                        // Si la respuesta no es exitosa, muestra un mensaje de error
                        dtgDatosCliente.DataSource = "Error en la solicitud: " + response.ReasonPhrase;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones en caso de problemas de conexión u otros errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}