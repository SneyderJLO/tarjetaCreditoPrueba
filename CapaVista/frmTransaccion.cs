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
using TarjetaCreditoApi.ApiHelper;
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
                        // Haz lo que necesites con el texto obtenido
                    }
                }
            }
            else
            {
                confirmarTransaccion();
            }
        }
        private async void confirmarTransaccion()
        {
            using (HttpClient client = new HttpClient())
            {
                string rutaApi = "https://localhost:7273/api/tarjetas/transaccion";
                try
                {


                    // Crear un objeto para enviar en el cuerpo de la solicitud POST
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
                        MessageBox.Show("Transaccion insertada correctamente.");

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
                // Configura la base URL de tu API
                client.BaseAddress = new Uri("https://localhost:7273/");
                try
                {
                    // Realiza la llamada GET a la API y espera la respuesta
                    HttpResponseMessage response = await client.GetAsync("api/tarjetas/transacciones?id=" + TCliente.Text);
                    // Verifica si la respuesta es exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena JSON
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Aquí puedes procesar o mostrar el responseBody como necesites
                        List<MTransaccion> tarjetas = JsonConvert.DeserializeObject<List<MTransaccion>>(responseBody);
                        // Asigna la lista de tarjetas al DataGridView
                        if (tarjetas.Count > 0)
                        {
                            var dialogo = new frmClienteTarjeta();


                            dialogo.dtgDatosCliente.DataSource = tarjetas;
                            dialogo.ShowDialog();


                        }


                    }

                }
                catch (Exception ex)
                {
                    // Manejo de excepciones en caso de problemas de conexión u otros errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void frmTransaccion_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // Configura la base URL de tu API
                client.BaseAddress = new Uri("https://fakestoreapi.com/products");
                // client.BaseAddress = new Uri("https://api.storerestapi.com/products");
                try
                {
                    // Realiza la llamada GET a la API y espera la respuesta
                    HttpResponseMessage response = await client.GetAsync("products");
                    // Verifica si la respuesta es exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena JSON
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Aquí puedes procesar o mostrar el responseBody como necesites
                        tarjetas = JsonConvert.DeserializeObject<List<MProducto>>(responseBody);
                        // Asigna la lista de tarjetas al DataGridView

                        List<string> products = new List<string>();
                        foreach (var item in tarjetas)
                        {
                            products.Add(item.id + "");
                        }
                        cmbProducto.DataSource = products;
                        // MessageBox.Show(tarjetas.Count + "");
                    }
                    else
                    {
                        // Si la respuesta no es exitosa, muestra un mensaje de error
                        dgvProductos.DataSource = "Error en la solicitud: " + response.ReasonPhrase;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones en caso de problemas de conexión u otros errores
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

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
            row.CreateCells(dgvProductos, idProducto, precioProducto, tituloProducto);

            // Agregar la fila a la DataGridView
            dgvProductos.Rows.Add(row);
            total += precio;
            this.txtTotal.Text = "" + total;

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
