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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CapaVista
{
    public partial class frmTransaccion : Form
    {
        decimal total = 0;
        int idTarjeta = 0;
        decimal saldoDisponible = 0;
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

            if (total > 0)
            {

                if (TCliente.Text != "" && TNumeroTarjeta.Text != "")
                {
                    if (total < saldoDisponible)
                    {
                        DialogResult result = MessageBox.Show("¿Estás seguro de continuar?", "Confirmación",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //MessageBox.Show("Confirmado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            confirmarTransaccion();
                            actualizarCupo();
                            limpiarPantalla();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Superaste el saldo disponible de tu tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {


                    using (var dialogo = new frmClienteTarjeta())
                    {
                        dialogo.txtValorTotal.Text = txtTotal.Text;
                        if (dialogo.ShowDialog() == DialogResult.OK)
                        {
                            TCliente.Text = dialogo.id;
                            idTarjeta = dialogo.idTarjeta;
                            TNombre.Text = "cliente-cliente";
                            TNumeroTarjeta.Text = dialogo.lblNumeroTarjeta.Text;
                            TCvc.Text = dialogo.lblCVV.Text;
                            TFecha.Text = dialogo.lblFecha.Text;
                            saldoDisponible = decimal.Parse(dialogo.lblSaldoDisponible.Text);

                        }
                    }
                    //pictureBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }




        public void limpiarPantalla()
        {
            TNumeroTarjeta.Text = "";
            TCvc.Text = "";
            TFecha.Text = "";
            txtTotal.Text = "";
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            total = 0;

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
                        MessageBox.Show("Transaccion insertada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        public async void actualizarCupo()
        {
            string ApiBaseUrl = "http://192.168.1.124:88/api/tarjetas";
            try

            {
                //var totalCompra = Convert.ToDecimal(txtTotal.Text.Substring(0, txtTotal.Text.IndexOf('.')));
                //MessageBox.Show(totalCompra + "");
                using (HttpClient client = new HttpClient())
                {

                    // Configurar encabezados si es necesario
                    // client.DefaultRequestHeaders.Add("Authorization", "Bearer TOKEN_AQUI");

                    // Construir la URL con los parámetros de consulta
                    string url = $"{ApiBaseUrl}/actualizarCupo?idTarjeta={idTarjeta}&valorCompra={total}";

                    // Realizar la solicitud HTTP PUT
                    HttpResponseMessage response = await client.PutAsync(url, null);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            string precioProducto = precio.ToString("N2");
            // int indexDecimal = precioProducto.IndexOf('.');


            DataGridViewRow row = new DataGridViewRow();




            row.CreateCells(dgvProductos, idProducto, tituloProducto, precioProducto);//.Substring(0, indexDecimal));

            // Agregar la fila a la DataGridView
            dgvProductos.Rows.Add(row);
            total += precio;
            this.txtTotal.Text = "" + total;



            //  MessageBox.Show("Superaste el saldo disponible de tu tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvProductos.Rows[e.RowIndex];
            var dgv = (DataGridView)sender;
            var precio = decimal.Parse(selectedRow.Cells["precio"].Value.ToString());
            if (e.ColumnIndex == dgv.Columns["eliminar"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {

                    total -= precio;

                    txtTotal.Text = total.ToString("N2");
                    dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);

                }



            }
        }
    }
}
