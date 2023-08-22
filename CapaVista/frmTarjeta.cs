﻿using System;
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
using TarjetaCreditoApi.Model;
using System.Data.SqlTypes;
using Newtonsoft.Json.Linq;

namespace CapaVista
{

    public partial class frmTarjeta : Form
    {
        public const string rutaApi = "http://192.168.1.124:88/api/tarjetas/tarjeta"; // Reemplaza con la URL de tu API
        public frmTarjeta()
        {
            InitializeComponent();
        }


        private void frmTarjeta_Load(object sender, EventArgs e)
        {
            lblNombreBanco.Parent = pctCard;
            lblNombre.Parent = pctCard;
            txtTarjeta.Parent = pctCard;
            labelfECHA.Parent = pctCard;
            lblCVC.Parent = pctCard;
            lbl.Parent = pctCard;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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

            for (int i = 2; i <= 8; i += 2)
            {
                sumaPares = sumaPares + int.Parse(numeroTarjeta.Substring(i - 1, 1));
            }

            for (int i = 1; i <= 9; i += 2)
            {
                tmp = int.Parse(numeroTarjeta.Substring(i - 1, 1)) * 2;
                if (tmp > 9)
                    tmp = tmp - 9;
                sumaImpares = sumaImpares + tmp;
            }

            int digito = (sumaPares + sumaImpares) % 10;
            return digito;
        }



        private async void confirmarTarjeta()
        {
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    decimal saldoAutorizado = decimal.Parse(lblSaldoAutorizado.Text);
                    decimal saldoUtilizado = saldoTarjeta(saldoAutorizado);
                    decimal saldoDisponible = saldoAutorizado - saldoUtilizado;
                    DateTime fechaExpira = DateTime.Parse(labelfECHA.Text);
                    MTarjeta postData = new MTarjeta()
                    {
                        idCliente = int.Parse(cedula3.Text),
                        numeroTarjeta = txtTarjeta.Text,
                        fechaexpira = fechaExpira,
                        cvv = int.Parse(lblCVC.Text),
                        cupoAutorizado = saldoAutorizado,
                        cupoUtilizado = saldoUtilizado,
                        cupoDisponible = saldoDisponible
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync(rutaApi, postData);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Tarjeta insertada correctamente.", "Aviso");

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




        public int generarCVC()
        {
            Random random = new Random();
            return random.Next(100, 999);
        }

        public decimal saldoTarjeta()
        {
            Random random = new Random();
            int value = random.Next(1, 1000);

            return value;

        }

        public decimal saldoTarjeta(decimal valorAutorizado)
        {
            Random random = new Random();
            decimal saldoUtilizado = random.Next((int)valorAutorizado);
            return saldoUtilizado;

        }



        public DateTime GenerateRandomDate()
        {
            Random random = new Random();
            DateTime startDate = DateTime.Now.AddYears(-1); // Hace un año desde hoy
            DateTime endDate = DateTime.Now;

            TimeSpan timeSpan = endDate - startDate;
            int randomDays = random.Next(0, (int)timeSpan.TotalDays);
            DateTime randomDate = startDate.AddDays(randomDays);
            return randomDate;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long tarjeta = GenerarNumeroAleatorio();
            int ultimoDigito = CalcularDigitoVerificador(tarjeta.ToString());
            txtTarjeta.Text = tarjeta.ToString() + ultimoDigito;
            labelfECHA.Text = GenerateRandomDate().ToString();
            lblNombre.Text = "Cliente-cliente-cliente";
            lblCVC.Text = generarCVC().ToString();
            btnConfirmar.Enabled = true;
            btnGenerar.Enabled = false;
            lblSaldoAutorizado.Text = saldoTarjeta().ToString();
            txtNombre.Text = lblNombre.Text;
            lblTarjeta.Text = txtTarjeta.Text;
            lblCodigoCvv.Text = lblCVC.Text;
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            confirmarTarjeta();
            this.Close();



        }
    }
}

