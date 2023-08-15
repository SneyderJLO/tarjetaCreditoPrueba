using TarjetaCreditoApi.ApiHelper;
using TarjetaCreditoApi.Model;
using Newtonsoft.Json;

namespace CapaVista
{
    public partial class frmClienteTarjeta : Form
    {

        public int idTarjeta { get; set; }
        public string id { get; set; }

        public frmClienteTarjeta() => InitializeComponent();


        private void label2_Click(object sender, EventArgs e)
        {
            if (dtgDatosCliente.RowCount == 0)
            {
                MessageBox.Show("El cliente no existe. por lo tanto no se puede asociar tarjeta");
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
            if (e.KeyChar == (char)13)
            {
                if (txtCedula.Text == txtCedula.Text.TrimStart('0'))
                {
                    cargarDatosCliente();
                }
                else
                {
                    MessageBox.Show("no puede ingresar ceros a la izquierda");
                }
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
                    string idCliente = (txtCedula.Text).Trim();
                    string strInput = "0001234";
                    strInput = strInput.TrimStart('0');

                    MessageBox.Show(strInput);
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgDatosCliente.Rows[e.RowIndex];
                dtgDatosCliente.Rows[e.RowIndex].Selected = true;
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
                client.BaseAddress = new Uri("https://localhost:7273/");
                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/tarjetas/tarjetas?id=" + txtCedula.Text);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        List<MTarjeta> tarjetas = JsonConvert.DeserializeObject<List<MTarjeta>>(responseBody);

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
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}