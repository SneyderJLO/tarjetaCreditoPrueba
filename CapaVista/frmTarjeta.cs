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
            lblNumero.Parent = pctCard;
            labelfECHA.Parent = pctCard;
            LBLvISA.Parent = pctCard;
            lblCVV.Parent = pctCard;
        }
    }
}
