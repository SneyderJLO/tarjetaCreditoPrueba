namespace CapaVista
{
    partial class frmListadoTransaccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoTransaccion));
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            dtgTransaccion = new DataGridView();
            panel2 = new Panel();
            btn_actualizar = new Button();
            lblCVV = new Label();
            label20 = new Label();
            label21 = new Label();
            lblFecha = new Label();
            label18 = new Label();
            label16 = new Label();
            lblNumeroTarjeta = new Label();
            label11 = new Label();
            label12 = new Label();
            label4 = new Label();
            dtgDatosTransaccion = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTransaccion).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosTransaccion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 70);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(515, 20);
            label2.Name = "label2";
            label2.Size = new Size(236, 31);
            label2.TabIndex = 37;
            label2.Text = "Transacciones por cliente";
            label2.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(158, 70);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dtgTransaccion);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(dtgDatosTransaccion);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(780, 394);
            panel4.TabIndex = 2;
            // 
            // dtgTransaccion
            // 
            dtgTransaccion.AllowUserToAddRows = false;
            dtgTransaccion.AllowUserToDeleteRows = false;
            dtgTransaccion.AllowUserToOrderColumns = true;
            dtgTransaccion.BackgroundColor = Color.White;
            dtgTransaccion.BorderStyle = BorderStyle.None;
            dtgTransaccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTransaccion.Dock = DockStyle.Fill;
            dtgTransaccion.GridColor = Color.FromArgb(224, 225, 221);
            dtgTransaccion.Location = new Point(0, 125);
            dtgTransaccion.MultiSelect = false;
            dtgTransaccion.Name = "dtgTransaccion";
            dtgTransaccion.ReadOnly = true;
            dtgTransaccion.RowHeadersWidth = 51;
            dtgTransaccion.RowTemplate.Height = 25;
            dtgTransaccion.Size = new Size(778, 267);
            dtgTransaccion.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 90, 119);
            panel2.Controls.Add(btn_actualizar);
            panel2.Controls.Add(lblCVV);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(lblNumeroTarjeta);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 125);
            panel2.TabIndex = 4;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Anchor = AnchorStyles.Right;
            btn_actualizar.BackColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.Location = new Point(1240, 12);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(185, 23);
            btn_actualizar.TabIndex = 6;
            btn_actualizar.Text = "Actualizar Registros";
            btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // lblCVV
            // 
            lblCVV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCVV.ForeColor = Color.FromArgb(224, 225, 221);
            lblCVV.Location = new Point(572, 65);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(59, 21);
            lblCVV.TabIndex = 34;
            lblCVV.Text = "000 00";
            lblCVV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.ForeColor = Color.FromArgb(224, 225, 221);
            label20.Location = new Point(568, 78);
            label20.Name = "label20";
            label20.Size = new Size(92, 17);
            label20.TabIndex = 33;
            label20.Text = "_______________";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(574, 41);
            label21.Name = "label21";
            label21.Size = new Size(71, 15);
            label21.TabIndex = 32;
            label21.Text = "Cod. Postal";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(224, 225, 221);
            lblFecha.Location = new Point(366, 65);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(146, 21);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "xxxxxxxxxxxxxxxxx";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.ForeColor = Color.FromArgb(224, 225, 221);
            label18.Location = new Point(363, 78);
            label18.Name = "label18";
            label18.Size = new Size(184, 17);
            label18.TabIndex = 30;
            label18.Text = "______________________________";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(363, 41);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 29;
            label16.Text = "Dirección";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNumeroTarjeta.ForeColor = Color.FromArgb(224, 225, 221);
            lblNumeroTarjeta.Location = new Point(84, 69);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(202, 21);
            lblNumeroTarjeta.TabIndex = 28;
            lblNumeroTarjeta.Text = "xxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.ForeColor = Color.FromArgb(224, 225, 221);
            label11.Location = new Point(79, 78);
            label11.Name = "label11";
            label11.Size = new Size(254, 17);
            label11.TabIndex = 26;
            label11.Text = "_________________________________________________";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(79, 50);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 25;
            label12.Text = "Apellidos y nombres";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 225, 221);
            label4.Location = new Point(56, 14);
            label4.Name = "label4";
            label4.Size = new Size(158, 16);
            label4.TabIndex = 0;
            label4.Text = "Datos del cliente";
            // 
            // dtgDatosTransaccion
            // 
            dtgDatosTransaccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgDatosTransaccion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgDatosTransaccion.BackgroundColor = Color.White;
            dtgDatosTransaccion.BorderStyle = BorderStyle.None;
            dtgDatosTransaccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosTransaccion.Dock = DockStyle.Fill;
            dtgDatosTransaccion.GridColor = Color.FromArgb(224, 225, 221);
            dtgDatosTransaccion.Location = new Point(0, 0);
            dtgDatosTransaccion.MultiSelect = false;
            dtgDatosTransaccion.Name = "dtgDatosTransaccion";
            dtgDatosTransaccion.ReadOnly = true;
            dtgDatosTransaccion.RowHeadersWidth = 51;
            dtgDatosTransaccion.RowTemplate.Height = 25;
            dtgDatosTransaccion.Size = new Size(778, 392);
            dtgDatosTransaccion.TabIndex = 2;
            // 
            // frmListadoTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 464);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "frmListadoTransaccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de transacciones por cliente";
            Load += frmListadoTransaccion_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgTransaccion).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosTransaccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel4;
        public DataGridView dtgDatosTransaccion;
        private Panel panel2;
        private Button btn_actualizar;
        public Label lblCVV;
        private Label label20;
        private Label label21;
        public Label lblFecha;
        private Label label18;
        private Label label16;
        public Label lblNumeroTarjeta;
        private Label label11;
        private Label label12;
        private Label label4;
        public DataGridView dtgTransaccion;
    }
}