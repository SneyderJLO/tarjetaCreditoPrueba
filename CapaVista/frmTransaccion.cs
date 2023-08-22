using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarjetaCreditoApi.Model;
using TarjetaCreditoApi.Model.Producto;
using TarjetaCreditoApi.Model.Transaccion;

namespace CapaVista
{
    public partial class frmTransaccion : Form
    {
        decimal total = 0;
        int idTarjeta = 0;
        List<MProducto> tarjetas = new List<MProducto>();
        public frmTransaccion()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            if (TCliente.Text == "")
            {
                using (var dialogo = new frmClienteTarjeta())
                {
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        TCliente.Text = dialogo.id;
                        idTarjeta = dialogo.idTarjeta;
                        TNombre.Text = "cliente-cliente";
                        TNumeroTarjeta.Text = dialogo.lblNumeroTarjeta.Text;
                        TCvc.Text = dialogo.lblCVV.Text;
                        TFecha.Text = dialogo.lblFecha.Text;

                    }
                }
            }
            else if (total <= 0)
            {

                confirmarTransaccion();

            }
            else
            {
                MessageBox.Show("No se han seleccionado productos");
            }
        }
        private async void confirmarTransaccion()
        {
            using (HttpClient client = new HttpClient())
            {
                string rutaApi = "http://192.168.1.124:88/api/tarjetas/transaccion";
                try
                {
                    MTransaccion postData = new MTransaccion()
                    {
                        idProducto = cmbProducto.SelectedIndex + 1,
                        idTarjeta = idTarjeta,
                        fecha = DateTime.Now,
                        producto = txtProducto.Text,
                        valor = total
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync(rutaApi, postData);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Transaccion insertada correctamente.", "Aviso");

                    }
                    else
                    {
                        MessageBox.Show("Error en la solicitud POST: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cargarDatosCliente();
        }


        private async void cargarDatosCliente()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.124:88/");
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/tarjetas/transacciones?id=" + TCliente.Text);

                    if (response.IsSuccessStatusCode)
                    {

                        string responseBody = await response.Content.ReadAsStringAsync();
                        List<MTransaccion> tarjetas = JsonConvert.DeserializeObject<List<MTransaccion>>(responseBody);

                        if (tarjetas.Count > 0)
                        {
                            var dialogo = new frmListadoTransaccion();
                            dialogo.dtgTransaccion.DataSource = tarjetas;

                            dialogo.ShowDialog();
                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private async void frmTransaccion_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://fakestoreapi.com/products");
                // client.BaseAddress = new Uri("https://api.storerestapi.com/products");
                try
                {
                    HttpResponseMessage response = await client.GetAsync("products");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        tarjetas = JsonConvert.DeserializeObject<List<MProducto>>(responseBody);
                        List<string> products = new List<string>();
                        foreach (var item in tarjetas)
                        {
                            products.Add(item.id + "");
                        }
                        cmbProducto.DataSource = products;
                    }
                    else
                    {
                        dgvProductos.DataSource = "Error en la solicitud: " + response.ReasonPhrase;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexProducto = cmbProducto.SelectedIndex;
            var tituloProducto = (from p in tarjetas
                                  where p.id == indexProducto + 1
                                  select p.Titutlo).FirstOrDefault();


            var descripcionProducto = (from p in tarjetas
                                       where p.id == indexProducto + 1
                                       select p.Descripcion).FirstOrDefault();

            this.rtbDescripcionProducto.Text = descripcionProducto.ToString();
            this.txtProducto.Text = tituloProducto.ToUpper().ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var precio = (from p in tarjetas
                          where p.id == cmbProducto.SelectedIndex + 1
                          select p.Precio).FirstOrDefault();
            string idProducto = cmbProducto.SelectedIndex + 1 + "";
            string tituloProducto = txtProducto.Text;
            string precioProducto = precio.ToString();
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvProductos, idProducto, tituloProducto, precioProducto);

            // Agregar la fila a la DataGridView
            dgvProductos.Rows.Add(row);
            total += precio;
            this.txtTotal.Text = "" + total;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
