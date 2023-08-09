using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmTarjeta : Form
    {
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
            lblCVV.Parent = pctCard;
            lblConfirm.Enabled = false;
            lblNombreCliente.Text = "Lorem ipsum dolor sit amet consectetu";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            long tarjeta = GenerarNumeroAleatorio();
            int ultimoDigito = ci(tarjeta.ToString());
            txtTarjeta.Text = tarjeta.ToString() + ultimoDigito;
            labelfECHA.Text = DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString();
            lblNombre.Text = "Lorem ipsum dolor sit amet consectetu";
            lblCVC.Text = "12";
            lblConfirm.Enabled = true;
            lblGenerar.Enabled = false;


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
        public int ci(string numeroTarjeta)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int tmp = 0;

            int digito = 0;

            // sumamos los pares
            for (int i = 2; i <= 8; i += 2)
            {
                sumaPares = sumaPares + int.Parse(numeroTarjeta.Substring(i - 1, 1));
            }

            // sumamos los impares
            for (int i = 1; i <= 9; i += 2)
            {
                tmp = int.Parse(numeroTarjeta.Substring(i - 1, 1)) * 2;
                if (tmp > 9)
                    tmp = tmp - 9;
                sumaImpares = sumaImpares + tmp;
            }

            // Obtenemos el digito
            digito = 15 - ((sumaPares + sumaImpares) % 15);
            if (digito == 15)
                digito = 0;

            return digito;
        }
    }
}

