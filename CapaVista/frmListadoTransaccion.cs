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
    public partial class frmListadoTransaccion : Form
    {
        public frmListadoTransaccion()
        {
            InitializeComponent();
        }

        private void frmListadoTransaccion_Load(object sender, EventArgs e)
        {
            dtgTransaccion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            // dtgTransaccion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
    }
}
