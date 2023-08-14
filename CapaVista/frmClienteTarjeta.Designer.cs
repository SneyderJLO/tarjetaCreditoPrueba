
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteTarjeta));
            panelContainer = new Panel();
            panel9 = new Panel();
            panel11 = new Panel();
            dtgDatosCliente = new DataGridView();
            panel10 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
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
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1177, 769);
            panelContainer.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(207, 149);
            panel9.Name = "panel9";
            panel9.Size = new Size(970, 620);
            panel9.TabIndex = 43;
            // 
            // panel11
            // 
            panel11.Controls.Add(dtgDatosCliente);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 171);
            panel11.Name = "panel11";
            panel11.Size = new Size(970, 391);
            panel11.TabIndex = 5;
            // 
            // dtgDatosCliente
            // 
            dtgDatosCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgDatosCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgDatosCliente.BackgroundColor = Color.White;
            dtgDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosCliente.GridColor = Color.FromArgb(224, 225, 221);
            dtgDatosCliente.Location = new Point(0, 0);
            dtgDatosCliente.Margin = new Padding(3, 4, 3, 4);
            dtgDatosCliente.MultiSelect = false;
            dtgDatosCliente.Name = "dtgDatosCliente";
            dtgDatosCliente.ReadOnly = true;
            dtgDatosCliente.RowHeadersWidth = 51;
            dtgDatosCliente.RowTemplate.Height = 25;
            dtgDatosCliente.Size = new Size(970, 391);
            dtgDatosCliente.TabIndex = 1;
            dtgDatosCliente.CellClick += dtgDatosCliente_CellClick;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 562);
            panel10.Name = "panel10";
            panel10.Size = new Size(970, 58);
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
            button1.Name = "button1";
            button1.Size = new Size(970, 58);
            button1.TabIndex = 37;
            button1.Text = "Seleccionar tarjeta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 90, 119);
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
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 171);
            panel3.TabIndex = 3;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Anchor = AnchorStyles.Right;
            btn_actualizar.BackColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.Location = new Point(756, 0);
            btn_actualizar.Margin = new Padding(3, 4, 3, 4);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(211, 31);
            btn_actualizar.TabIndex = 6;
            btn_actualizar.Text = "Actualizar Registros";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // lblSaldoDisponible
            // 
            lblSaldoDisponible.AutoSize = true;
            lblSaldoDisponible.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSaldoDisponible.ForeColor = Color.FromArgb(224, 225, 221);
            lblSaldoDisponible.Location = new Point(694, 98);
            lblSaldoDisponible.Name = "lblSaldoDisponible";
            lblSaldoDisponible.Size = new Size(48, 28);
            lblSaldoDisponible.TabIndex = 46;
            lblSaldoDisponible.Text = "XXX";
            lblSaldoDisponible.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.ForeColor = Color.FromArgb(224, 225, 221);
            label9.Location = new Point(687, 119);
            label9.Name = "label9";
            label9.Size = new Size(105, 27);
            label9.TabIndex = 45;
            label9.Text = "_______________";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(27, 38, 59);
            label10.Location = new Point(694, 66);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 44;
            label10.Text = "Saldo disponible";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(91, 98);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCVV.ForeColor = Color.FromArgb(224, 225, 221);
            lblCVV.Location = new Point(562, 98);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(48, 28);
            lblCVV.TabIndex = 34;
            lblCVV.Text = "XXX";
            lblCVV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.ForeColor = Color.FromArgb(224, 225, 221);
            label20.Location = new Point(555, 119);
            label20.Name = "label20";
            label20.Size = new Size(105, 27);
            label20.TabIndex = 33;
            label20.Text = "_______________";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(27, 38, 59);
            label21.Location = new Point(562, 66);
            label21.Name = "label21";
            label21.Size = new Size(40, 20);
            label21.TabIndex = 32;
            label21.Text = "CVV";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(224, 225, 221);
            lblFecha.Location = new Point(406, 98);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(90, 28);
            lblFecha.TabIndex = 31;
            lblFecha.Text = "MM / AA";
            // 
            // label18
            // 
            label18.ForeColor = Color.FromArgb(224, 225, 221);
            label18.Location = new Point(406, 119);
            label18.Name = "label18";
            label18.Size = new Size(102, 27);
            label18.TabIndex = 30;
            label18.Text = "________________";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(27, 38, 59);
            label16.Location = new Point(406, 66);
            label16.Name = "label16";
            label16.Size = new Size(104, 20);
            label16.TabIndex = 29;
            label16.Text = "F. Expiración";
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNumeroTarjeta.ForeColor = Color.FromArgb(224, 225, 221);
            lblNumeroTarjeta.Location = new Point(136, 98);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(154, 28);
            lblNumeroTarjeta.TabIndex = 28;
            lblNumeroTarjeta.Text = "0000 0000 0000";
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(224, 225, 221);
            label11.Location = new Point(90, 120);
            label11.Name = "label11";
            label11.Size = new Size(290, 27);
            label11.TabIndex = 26;
            label11.Text = "_________________________________________________";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(27, 38, 59);
            label12.Location = new Point(79, 66);
            label12.Name = "label12";
            label12.Size = new Size(289, 20);
            label12.TabIndex = 25;
            label12.Text = "Número de tarjeta de crédito o débito";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 225, 221);
            label4.Location = new Point(64, 27);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 0;
            label4.Text = "Detalles de tarjeta";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCedula);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(207, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(970, 149);
            panel8.TabIndex = 42;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.BackColor = Color.FromArgb(27, 38, 59);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(375, 66);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(227, 26);
            txtCedula.TabIndex = 0;
            txtCedula.TextAlign = HorizontalAlignment.Center;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(227, 87);
            label3.Name = "label3";
            label3.Size = new Size(550, 36);
            label3.TabIndex = 5;
            label3.Text = "________________________________________";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 225, 221);
            label1.Location = new Point(191, 18);
            label1.Name = "label1";
            label1.Size = new Size(595, 45);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el número de cédula";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 769);
            panel5.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 149);
            panel7.Name = "panel7";
            panel7.Size = new Size(207, 620);
            panel7.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 620);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 225, 221);
            label2.Location = new Point(56, 19);
            label2.Name = "label2";
            label2.Size = new Size(155, 33);
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
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 149);
            panel6.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(224, 225, 221);
            panel4.Location = new Point(253, 717);
            panel4.Name = "panel4";
            panel4.Size = new Size(972, 94);
            panel4.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 771);
            panel1.TabIndex = 2;
            // 
            // frmClienteTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 225, 221);
            ClientSize = new Size(1179, 771);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblSaldoDisponible;
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
    }
}