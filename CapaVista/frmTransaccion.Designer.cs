namespace CapaVista
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
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label22 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            btn_actualizar = new Button();
            panel4 = new Panel();
            label10 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label24 = new Label();
            label23 = new Label();
            label26 = new Label();
            label25 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(824, 95);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(735, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 225, 221);
            label22.Location = new Point(612, 56);
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
            panel2.BackColor = Color.FromArgb(224, 225, 221);
            panel2.Controls.Add(btn_actualizar);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 434);
            panel2.TabIndex = 1;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.FlatStyle = FlatStyle.Popup;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.Location = new Point(587, 379);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(199, 32);
            btn_actualizar.TabIndex = 7;
            btn_actualizar.Text = "Procesar compra";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(47, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 313);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 80);
            label10.Name = "label10";
            label10.Size = new Size(240, 21);
            label10.TabIndex = 25;
            label10.Text = "xx xxxx xxxx";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(27, 38, 59);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 6F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(224, 225, 221);
            button1.Location = new Point(161, 270);
            button1.Name = "button1";
            button1.Size = new Size(103, 28);
            button1.TabIndex = 8;
            button1.Text = "Eliminar producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 225, 221);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Valor });
            dataGridView1.Location = new Point(24, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 121);
            dataGridView1.TabIndex = 12;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(220, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(253, 17);
            label2.TabIndex = 10;
            label2.Text = "_______________________________________________";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 225, 221);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CardService", "CardService", "CardService", "CardService", "CardService", "CardService" });
            comboBox1.Location = new Point(24, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(13, 27, 42);
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
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
            panel3.Location = new Point(347, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 313);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label30);
            panel6.Controls.Add(label31);
            panel6.Controls.Add(label32);
            panel6.Controls.Add(label27);
            panel6.Controls.Add(label28);
            panel6.Controls.Add(label29);
            panel6.Controls.Add(label24);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label26);
            panel6.Controls.Add(label25);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(295, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(142, 311);
            panel6.TabIndex = 25;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(87, 163);
            label30.Name = "label30";
            label30.Size = new Size(37, 21);
            label30.TabIndex = 34;
            label30.Text = "XXX";
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
            label27.Size = new Size(37, 21);
            label27.TabIndex = 31;
            label27.Text = "XXX";
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
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(89, 227);
            label24.Name = "label24";
            label24.Size = new Size(37, 21);
            label24.TabIndex = 28;
            label24.Text = "XXX";
            label24.TextAlign = ContentAlignment.MiddleLeft;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(203, 230);
            label19.Name = "label19";
            label19.Size = new Size(37, 21);
            label19.TabIndex = 24;
            label19.Text = "XXX";
            label19.TextAlign = ContentAlignment.MiddleLeft;
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(37, 230);
            label17.Name = "label17";
            label17.Size = new Size(72, 21);
            label17.TabIndex = 21;
            label17.Text = "MM / AA";
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(216, 68);
            label15.Name = "label15";
            label15.Size = new Size(24, 21);
            label15.TabIndex = 18;
            label15.Text = "xx";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(65, 68);
            label14.Name = "label14";
            label14.Size = new Size(88, 21);
            label14.TabIndex = 17;
            label14.Text = "xx xxxx xxxx";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(68, 164);
            label13.Name = "label13";
            label13.Size = new Size(126, 21);
            label13.TabIndex = 16;
            label13.Text = "0000 0000 0000";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 156);
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
            pictureBox2.Location = new Point(28, 62);
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
            label3.Location = new Point(597, 25);
            label3.Name = "label3";
            label3.Size = new Size(190, 21);
            label3.TabIndex = 3;
            label3.Text = "Detalles de facturación";
            // 
            // frmTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmTransaccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransaccion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ComboBox comboBox1;
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
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label17;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label19;
        private Label label20;
        private Label label21;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label22;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Valor;
        private Button button1;
        private Label label10;
        private Panel panel6;
        private Label label24;
        private Label label23;
        private Label label26;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label25;
    }
}