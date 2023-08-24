
using TarjetaCreditoApi.Model;
using Newtonsoft.Json;

namespace CapaVista
{
    public partial class frmClienteTarjeta : Form
    {
        List<MTarjeta> tarjetas = new List<MTarjeta>();
        public int idTarjeta { get; set; }
        public string id { get; set; }

        public frmClienteTarjeta() => InitializeComponent();


        private void label2_Click(object sender, EventArgs e)
        {
            if (dtgDatosCliente.RowCount == 0)
            {
                MessageBox.Show("El cliente no existe. por lo tanto no se puede asociar tarjeta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                frmTarjeta frmTarjeta = new frmTarjeta();
                frmTarjeta.cedula3.Text = txtCedula.Text;
                frmTarjeta.ShowDialog();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {

                if (txtCedula.Text == txtCedula.Text.TrimStart('0'))
                {
                    cargarDatosCliente();
                }
                else
                {
                    limpiarPantalla();
                    MessageBox.Show("No puede ingresar ceros a la izquierda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }

        }

        public void limpiarPantalla()
        {
            this.dtgDatosCliente.DataSource = null;
            this.dtgDatosCliente.Rows.Clear();
            lblNumeroTarjeta.Text = "";
            lblCVV.Text = "";
            lblFecha.Text = "";
            lblSaldoDisponible.Text = "";

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargarDatosCliente();
        }


        private void dtgDatosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgDatosCliente.Rows[e.RowIndex];
                //  dtgDatosCliente.Rows[e.RowIndex].Selected = true;
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
            }
        }



        private async void cargarDatosCliente()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.124:88/");
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/tarjetas/tarjetas?id=" + txtCedula.Text);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        tarjetas = JsonConvert.DeserializeObject<List<MTarjeta>>(responseBody);

                        if (tarjetas.Count > 0)
                        {
                            dtgDatosCliente.DataSource = tarjetas;
                        }
                        else
                        {
                            limpiarPantalla();
                        }


                    }
                    else
                    {

                        dtgDatosCliente.DataSource = "Error en la solicitud: " + response.ReasonPhrase;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblNumeroTarjeta.Text != "")
                {
                    decimal saldoDisponible = Convert.ToDecimal(lblSaldoDisponible.Text);
                    decimal totalCancelar = Convert.ToDecimal(txtValorTotal.Text);
                    if (totalCancelar <= saldoDisponible)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {

                        MessageBox.Show("Fondos insuficientes. Elige otra tarjeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una tarjeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void dtgDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}