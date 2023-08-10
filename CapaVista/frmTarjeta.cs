using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarjetaCreditoApi.ApiHelper;
using TarjetaCreditoApi.Model;


namespace CapaVista
{

    public partial class frmTarjeta : Form
    {
        public const string rutaApi = "https://localhost:7273/api/tarjetas"; // Reemplaza con la URL de tu API
        public frmTarjeta()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            InitializeComponent();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTarjeta_Load(object sender, EventArgs e)
        {

            lblNombreBanco.Parent = pctCard;
            lblNombre.Parent = pctCard;
            txtTarjeta.Parent = pctCard;
            labelfECHA.Parent = pctCard;
            lblCVC.Parent = pctCard;
            lbl.Parent = pctCard;
            //lblConfirm.Enabled = false;
            lblNombreCliente.Text = "Id Cliente:";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            long tarjeta = GenerarNumeroAleatorio();
            int ultimoDigito = CalcularDigitoVerificador(tarjeta.ToString());
            txtTarjeta.Text = tarjeta.ToString() + ultimoDigito;
            labelfECHA.Text = DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString();
            lblNombre.Text = "Lorem ipsum dolor sit amet consectetu";
            lblCVC.Text = "144";
            //lblConfirm.Enabled = true;
            //lblGenerar.Enabled = false;


        }

        public static long GenerarNumeroAleatorio()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();
            long numeroAleatorio = BitConverter.ToInt64(bytes, 0);
            numeroAleatorio = Math.Abs(numeroAleatorio);
            numeroAleatorio %= 9000000000;
            numeroAleatorio += 100000000000000;
            return numeroAleatorio;
        }
        public int CalcularDigitoVerificador(string numeroTarjeta)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int tmp = 0;

            // Sumamos los pares
            for (int i = 2; i <= 8; i += 2)
            {
                sumaPares = sumaPares + int.Parse(numeroTarjeta.Substring(i - 1, 1));
            }

            // Sumamos los impares
            for (int i = 1; i <= 9; i += 2)
            {
                tmp = int.Parse(numeroTarjeta.Substring(i - 1, 1)) * 2;
                if (tmp > 9)
                    tmp = tmp - 9;
                sumaImpares = sumaImpares + tmp;
            }

            // Obtenemos el dígito
            int digito = (sumaPares + sumaImpares) % 10;
            return digito;
        }

        private async void lblConfirm_Click(object sender, EventArgs e)
        {
            confirmar();
            this.Close();


        }
        public async void confirmar()
        {
            try
            {
                MTarjeta datosTarjeta = new MTarjeta()
                {


                    idCliente = int.Parse(cedula3.Text),
                   // idTarjeta = 99,
                    numeroTarjeta = txtTarjeta.Text,
                    fechaexpira = DateTime.Now,
                    cvv = int.Parse(lblCVC.Text),
                    cupoAutorizado = 12,
                    cupoUtilizado = 12,
                    cupoDisponible = 0
                };
                Reply oReply = new Reply();

                oReply = await Consumer.Execute<MTarjeta>(rutaApi, methodHttp.POST, datosTarjeta);


                if (oReply.StatusCode == "OK")
                {
                    MessageBox.Show("Tarjeta insertada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar la tarjeta. Código de estado: " + oReply.StatusCode);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

