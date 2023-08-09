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
            lblNombreCliente.Text = "Lorem ipsum dolor sit amet consectetu";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            long tarjeta = GenerarNumeroAleatorio();
            txtTarjeta.Text = tarjeta.ToString();
            labelfECHA.Text = DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString();
            lblNombre.Text = "Lorem ipsum dolor sit amet consectetu";
            lblCVC.Text = "12";

        }

        public static long GenerarNumeroAleatorio()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();
            long numeroAleatorio = BitConverter.ToInt64(bytes, 0);
            numeroAleatorio = Math.Abs(numeroAleatorio);
            numeroAleatorio %= 9000000000;
            numeroAleatorio += 1000000000000000;
            return numeroAleatorio;
        }
    }
}
