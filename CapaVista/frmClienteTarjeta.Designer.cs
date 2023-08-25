
namespace CapaVista
{
    partial class frmClienteTarjeta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteTarjeta));
            panelContainer = new Panel();
            panel9 = new Panel();
            panel11 = new Panel();
            dtgDatosCliente = new DataGridView();
            panel10 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            txtValorTotal = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_actualizar = new Button();
            lblSaldoDisponible = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
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
            panel8 = new Panel();
            txtCedula = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel1 = new Panel();
            panelContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosCliente).BeginInit();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(27, 38, 59);
            panelContainer.Controls.Add(panel9);
            panelContainer.Controls.Add(panel8);
            panelContainer.Controls.Add(panel5);
            panelContainer.Controls.Add(panel4);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1030, 560);
            panelContainer.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(181, 112);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(849, 448);
            panel9.TabIndex = 43;
            // 
            // panel11
            // 
            panel11.Controls.Add(dtgDatosCliente);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 128);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(849, 276);
            panel11.TabIndex = 5;
            // 
            // dtgDatosCliente
            // 
            dtgDatosCliente.AllowUserToAddRows = false;
            dtgDatosCliente.AllowUserToDeleteRows = false;
            dtgDatosCliente.AllowUserToResizeColumns = false;
            dtgDatosCliente.AllowUserToResizeRows = false;
            dtgDatosCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatosCliente.BackgroundColor = Color.WhiteSmoke;
            dtgDatosCliente.BorderStyle = BorderStyle.None;
            dtgDatosCliente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgDatosCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgDatosCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dtgDatosCliente.GridColor = Color.FromArgb(224, 225, 221);
            dtgDatosCliente.Location = new Point(0, 0);
            dtgDatosCliente.MultiSelect = false;
            dtgDatosCliente.Name = "dtgDatosCliente";
            dtgDatosCliente.ReadOnly = true;
            dtgDatosCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgDatosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgDatosCliente.RowHeadersVisible = false;
            dtgDatosCliente.RowHeadersWidth = 51;
            dtgDatosCliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dtgDatosCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgDatosCliente.RowTemplate.Height = 25;
            dtgDatosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatosCliente.Size = new Size(849, 276);
            dtgDatosCliente.TabIndex = 1;
            dtgDatosCliente.CellClick += dtgDatosCliente_CellClick;
            dtgDatosCliente.CellContentClick += dtgDatosCliente_CellContentClick;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 404);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(849, 44);
            panel10.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 90, 119);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 225, 221);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(849, 44);
            button1.TabIndex = 37;
            button1.Text = "Seleccionar tarjeta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 90, 119);
            panel3.Controls.Add(txtValorTotal);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btn_actualizar);
            panel3.Controls.Add(lblSaldoDisponible);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblCVV);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(lblFecha);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(lblNumeroTarjeta);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 128);
            panel3.TabIndex = 3;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtValorTotal.ForeColor = Color.FromArgb(224, 225, 221);
            txtValorTotal.Location = new Point(699, 74);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(73, 21);
            txtValorTotal.TabIndex = 49;
            txtValorTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.ForeColor = Color.FromArgb(224, 225, 221);
            label6.Location = new Point(693, 89);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 48;
            label6.Text = "_______________";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(699, 50);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 47;
            label7.Text = "Valor a cancelar";
            // 
            // btn_actualizar
            // 
            btn_actualizar.Anchor = AnchorStyles.Right;
            btn_actualizar.BackColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.Location = new Point(662, 0);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(185, 23);
            btn_actualizar.TabIndex = 6;
            btn_actualizar.Text = "Actualizar Registros";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // lblSaldoDisponible
            // 
            lblSaldoDisponible.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSaldoDisponible.ForeColor = Color.FromArgb(224, 225, 221);
            lblSaldoDisponible.Location = new Point(577, 74);
            lblSaldoDisponible.Name = "lblSaldoDisponible";
            lblSaldoDisponible.Size = new Size(73, 21);
            lblSaldoDisponible.TabIndex = 46;
            lblSaldoDisponible.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.ForeColor = Color.FromArgb(224, 225, 221);
            label9.Location = new Point(571, 89);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 45;
            label9.Text = "_______________";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(577, 50);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 44;
            label10.Text = "Saldo disponible";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // lblCVV
            // 
            lblCVV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCVV.ForeColor = Color.FromArgb(224, 225, 221);
            lblCVV.Location = new Point(462, 74);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(70, 21);
            lblCVV.TabIndex = 34;
            lblCVV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.ForeColor = Color.FromArgb(224, 225, 221);
            label20.Location = new Point(456, 89);
            label20.Name = "label20";
            label20.Size = new Size(92, 20);
            label20.TabIndex = 33;
            label20.Text = "_______________";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(462, 50);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 32;
            label21.Text = "CVV";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(224, 225, 221);
            lblFecha.Location = new Point(325, 74);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(89, 21);
            lblFecha.TabIndex = 31;
            // 
            // label18
            // 
            label18.ForeColor = Color.FromArgb(224, 225, 221);
            label18.Location = new Point(325, 89);
            label18.Name = "label18";
            label18.Size = new Size(89, 20);
            label18.TabIndex = 30;
            label18.Text = "________________";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(325, 50);
            label16.Name = "label16";
            label16.Size = new Size(79, 15);
            label16.TabIndex = 29;
            label16.Text = "F. Expiración";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNumeroTarjeta.ForeColor = Color.FromArgb(224, 225, 221);
            lblNumeroTarjeta.Location = new Point(89, 74);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(198, 21);
            lblNumeroTarjeta.TabIndex = 28;
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(224, 225, 221);
            label11.Location = new Point(49, 90);
            label11.Name = "label11";
            label11.Size = new Size(254, 20);
            label11.TabIndex = 26;
            label11.Text = "_________________________________________________";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(39, 50);
            label12.Name = "label12";
            label12.Size = new Size(218, 15);
            label12.TabIndex = 25;
            label12.Text = "Número de tarjeta de crédito o débito";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 225, 221);
            label4.Location = new Point(26, 20);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 0;
            label4.Text = "Detalles de tarjeta";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCedula);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(181, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(849, 112);
            panel8.TabIndex = 42;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.BackColor = Color.FromArgb(27, 38, 59);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(328, 50);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(199, 21);
            txtCedula.TabIndex = 0;
            txtCedula.TextAlign = HorizontalAlignment.Center;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(199, 65);
            label3.Name = "label3";
            label3.Size = new Size(481, 27);
            label3.TabIndex = 5;
            label3.Text = "________________________________________";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 225, 221);
            label1.Location = new Point(167, 14);
            label1.Name = "label1";
            label1.Size = new Size(521, 34);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el número de cédula";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(181, 560);
            panel5.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 112);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(181, 448);
            panel7.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 448);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 225, 221);
            label2.Location = new Point(49, 14);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 5;
            label2.Text = "Generar tarjeta";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 112);
            panel6.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 225, 221);
            panel4.Location = new Point(221, 538);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 53);
            panel4.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1032, 562);
            panel1.TabIndex = 2;
            // 
            // frmClienteTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1032, 562);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmClienteTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDatosCliente).EndInit();
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        public TextBox txtCedula;
        private Button btn_actualizar;
        private Panel panel3;
        private Label label4;
        private Label label20;
        private Label label21;
        private Label label18;
        private Label label16;
        private Label label11;
        private Label label12;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel10;
        public Label lblCVV;
        public Label lblFecha;
        public Label lblNumeroTarjeta;
        public DataGridView dtgDatosCliente;
        private Label label6;
        private Label label7;
        public Label txtValorTotal;
        public Label lblSaldoDisponible;
    }
}