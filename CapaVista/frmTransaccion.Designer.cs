﻿namespace CapaVista
{
    partial class frmTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaccion));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label22 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            btn_actualizar = new Button();
            panel4 = new Panel();
            dgvProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewButtonColumn();
            txtProducto = new Label();
            cmbProducto = new ComboBox();
            rtbDescripcionProducto = new RichTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            txtTotal = new Label();
            label23 = new Label();
            label26 = new Label();
            label25 = new Label();
            TCvc = new Label();
            label20 = new Label();
            label21 = new Label();
            TFecha = new Label();
            label18 = new Label();
            label16 = new Label();
            TCliente = new Label();
            TNombre = new Label();
            TNumeroTarjeta = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 95);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1132, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 225, 221);
            label22.Location = new Point(1016, 58);
            label22.Name = "label22";
            label22.Size = new Size(160, 16);
            label22.TabIndex = 8;
            label22.Text = "Listado de transacciones";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 95);
            panel5.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 95);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(btn_actualizar);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 434);
            panel2.TabIndex = 1;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.FlatStyle = FlatStyle.Popup;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.Location = new Point(735, 379);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(436, 32);
            btn_actualizar.TabIndex = 7;
            btn_actualizar.Text = "Procesar compra";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dgvProductos);
            panel4.Controls.Add(txtProducto);
            panel4.Controls.Add(cmbProducto);
            panel4.Controls.Add(rtbDescripcionProducto);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(47, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 357);
            panel4.TabIndex = 5;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id, Producto, Precio, eliminar });
            dgvProductos.GridColor = Color.Gainsboro;
            dgvProductos.Location = new Point(37, 206);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(613, 130);
            dgvProductos.TabIndex = 29;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "";
            eliminar.Name = "eliminar";
            eliminar.ReadOnly = true;
            eliminar.Resizable = DataGridViewTriState.False;
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            txtProducto.Location = new Point(181, 47);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(351, 19);
            txtProducto.TabIndex = 28;
            txtProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.FromArgb(224, 225, 221);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FlatStyle = FlatStyle.System;
            cmbProducto.Location = new Point(37, 41);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(126, 23);
            cmbProducto.TabIndex = 1;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // rtbDescripcionProducto
            // 
            rtbDescripcionProducto.BackColor = Color.AliceBlue;
            rtbDescripcionProducto.Location = new Point(37, 111);
            rtbDescripcionProducto.Margin = new Padding(3, 2, 3, 2);
            rtbDescripcionProducto.Name = "rtbDescripcionProducto";
            rtbDescripcionProducto.ReadOnly = true;
            rtbDescripcionProducto.Size = new Size(614, 74);
            rtbDescripcionProducto.TabIndex = 27;
            rtbDescripcionProducto.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(13, 27, 42);
            label2.Location = new Point(37, 88);
            label2.Name = "label2";
            label2.Size = new Size(164, 16);
            label2.TabIndex = 26;
            label2.Text = "Descripción del producto";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.Location = new Point(167, 52);
            label10.Name = "label10";
            label10.Size = new Size(378, 18);
            label10.TabIndex = 26;
            label10.Text = "_____________________________________________________________________";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(13, 27, 42);
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(TCvc);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(TFecha);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(TCliente);
            panel3.Controls.Add(TNombre);
            panel3.Controls.Add(TNumeroTarjeta);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(735, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 319);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(label30);
            panel6.Controls.Add(label31);
            panel6.Controls.Add(label32);
            panel6.Controls.Add(label27);
            panel6.Controls.Add(label28);
            panel6.Controls.Add(label29);
            panel6.Controls.Add(txtTotal);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label26);
            panel6.Controls.Add(label25);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(276, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(158, 315);
            panel6.TabIndex = 25;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(87, 163);
            label30.Name = "label30";
            label30.Size = new Size(40, 21);
            label30.TabIndex = 34;
            label30.Text = "0.00";
            label30.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            label31.Location = new Point(15, 174);
            label31.Name = "label31";
            label31.Size = new Size(124, 20);
            label31.TabIndex = 33;
            label31.Text = "______________________";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(92, 47);
            label32.Name = "label32";
            label32.Size = new Size(32, 15);
            label32.TabIndex = 32;
            label32.Text = "Imp.";
            label32.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(87, 63);
            label27.Name = "label27";
            label27.Size = new Size(41, 21);
            label27.TabIndex = 31;
            label27.Text = "12%";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.Location = new Point(13, 80);
            label28.Name = "label28";
            label28.Size = new Size(124, 14);
            label28.TabIndex = 30;
            label28.Text = "______________________";
            label28.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(60, 148);
            label29.Name = "label29";
            label29.Size = new Size(64, 15);
            label29.TabIndex = 29;
            label29.Text = "Descuento";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(15, 227);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(116, 20);
            txtTotal.TabIndex = 28;
            txtTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(13, 27, 42);
            label23.Location = new Point(15, 17);
            label23.Name = "label23";
            label23.Size = new Size(111, 16);
            label23.TabIndex = 25;
            label23.Text = "Total";
            label23.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(38, 206);
            label26.Name = "label26";
            label26.Size = new Size(90, 15);
            label26.TabIndex = 26;
            label26.Text = "Valor a cancelar";
            // 
            // label25
            // 
            label25.Location = new Point(15, 239);
            label25.Name = "label25";
            label25.Size = new Size(124, 20);
            label25.TabIndex = 35;
            label25.Text = "______________________";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TCvc
            // 
            TCvc.AutoSize = true;
            TCvc.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCvc.Location = new Point(203, 230);
            TCvc.Name = "TCvc";
            TCvc.Size = new Size(37, 21);
            TCvc.TabIndex = 24;
            TCvc.Text = "XXX";
            TCvc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Location = new Point(197, 240);
            label20.Name = "label20";
            label20.Size = new Size(92, 20);
            label20.TabIndex = 23;
            label20.Text = "_______________";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(203, 210);
            label21.Name = "label21";
            label21.Size = new Size(30, 15);
            label21.TabIndex = 22;
            label21.Text = "CVV";
            // 
            // TFecha
            // 
            TFecha.AutoSize = true;
            TFecha.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TFecha.Location = new Point(37, 230);
            TFecha.Name = "TFecha";
            TFecha.Size = new Size(72, 21);
            TFecha.TabIndex = 21;
            TFecha.Text = "MM / AA";
            // 
            // label18
            // 
            label18.Location = new Point(37, 240);
            label18.Name = "label18";
            label18.Size = new Size(89, 20);
            label18.TabIndex = 20;
            label18.Text = "________________";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            label18.Click += label18_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(37, 210);
            label16.Name = "label16";
            label16.Size = new Size(73, 15);
            label16.TabIndex = 19;
            label16.Text = "F. Expiración";
            // 
            // TCliente
            // 
            TCliente.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCliente.Location = new Point(216, 68);
            TCliente.Name = "TCliente";
            TCliente.Size = new Size(52, 21);
            TCliente.TabIndex = 18;
            TCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TNombre
            // 
            TNombre.AutoSize = true;
            TNombre.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TNombre.Location = new Point(65, 68);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(88, 21);
            TNombre.TabIndex = 17;
            TNombre.Text = "xx xxxx xxxx";
            // 
            // TNumeroTarjeta
            // 
            TNumeroTarjeta.AutoSize = true;
            TNumeroTarjeta.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TNumeroTarjeta.Location = new Point(72, 161);
            TNumeroTarjeta.Name = "TNumeroTarjeta";
            TNumeroTarjeta.Size = new Size(126, 21);
            TNumeroTarjeta.TabIndex = 16;
            TNumeroTarjeta.Text = "0000 0000 0000";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.Location = new Point(28, 175);
            label11.Name = "label11";
            label11.Size = new Size(254, 20);
            label11.TabIndex = 14;
            label11.Text = "_________________________________________________";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 138);
            label12.Name = "label12";
            label12.Size = new Size(206, 15);
            label12.TabIndex = 13;
            label12.Text = "Número de tarjeta de crédito o débito";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.Location = new Point(212, 78);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 10;
            label9.Text = "_____________";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(26, 78);
            label8.Name = "label8";
            label8.Size = new Size(169, 20);
            label8.TabIndex = 9;
            label8.Text = "________________________________";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 47);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 8;
            label7.Text = "ID cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 44);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 7;
            label6.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(13, 27, 42);
            label5.Location = new Point(19, 112);
            label5.Name = "label5";
            label5.Size = new Size(109, 16);
            label5.TabIndex = 6;
            label5.Text = "Método de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(13, 27, 42);
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(111, 16);
            label4.TabIndex = 5;
            label4.Text = "Datos del cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(13, 27, 42);
            label3.Location = new Point(982, 15);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 3;
            label3.Text = "Detalles de facturación";
            // 
            // frmTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmTransaccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transacciones";
            Load += frmTransaccion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox cmbProducto;
        private Panel panel3;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Button btn_actualizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label18;
        private Label label16;
        private Label TNombre;
        private Label label20;
        private Label label21;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label22;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label txtTotal;
        private Label label23;
        private Label label26;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label25;
        private RichTextBox rtbDescripcionProducto;
        private Label label2;
        private Label txtProducto;
        private Label label10;
        private DataGridView dgvProductos;
        public Label TFecha;
        public Label TCliente;
        public Label TNumeroTarjeta;
        public Label TCvc;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewButtonColumn eliminar;
    }
}