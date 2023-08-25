namespace CapaVista
{
    partial class frmTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarjeta));
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            cedula3 = new Label();
            label10 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            lblSaldoAutorizado = new Label();
            label11 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            btnConfirmar = new Button();
            label7 = new Label();
            panel7 = new Panel();
            labelfECHA = new Label();
            lbl = new Label();
            lblCVC = new Label();
            lblNombreBanco = new Label();
            txtTarjeta = new Label();
            lblNombre = new Label();
            pctCard = new PictureBox();
            panel2 = new Panel();
            txtAnio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtMes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label8 = new Label();
            panel6 = new Panel();
            btnGenerar = new Button();
            txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label6 = new Label();
            lblTarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblCodigoCvv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label12 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContainer.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctCard).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 85);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(27, 38, 59);
            panelContainer.Controls.Add(panel9);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(panel3);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(988, 85);
            panelContainer.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(65, 90, 119);
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(cedula3);
            panel9.Controls.Add(label10);
            panel9.Location = new Point(799, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(189, 85);
            panel9.TabIndex = 60;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userwhite;
            pictureBox1.Location = new Point(101, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cedula3
            // 
            cedula3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cedula3.ForeColor = Color.White;
            cedula3.Location = new Point(32, 55);
            cedula3.Name = "cedula3";
            cedula3.Size = new Size(63, 15);
            cedula3.TabIndex = 59;
            cedula3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 55);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 58;
            label10.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 20);
            label2.Name = "label2";
            label2.Size = new Size(452, 36);
            label2.TabIndex = 36;
            label2.Text = "Generador de tarjetas de crédito";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(988, 434);
            panel4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 429);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.AliceBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblSaldoAutorizado);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(471, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(513, 430);
            panel5.TabIndex = 2;
            // 
            // lblSaldoAutorizado
            // 
            lblSaldoAutorizado.Anchor = AnchorStyles.None;
            lblSaldoAutorizado.BackColor = Color.Transparent;
            lblSaldoAutorizado.FlatStyle = FlatStyle.Popup;
            lblSaldoAutorizado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldoAutorizado.ForeColor = Color.FromArgb(13, 27, 42);
            lblSaldoAutorizado.Location = new Point(201, 335);
            lblSaldoAutorizado.Name = "lblSaldoAutorizado";
            lblSaldoAutorizado.Size = new Size(266, 21);
            lblSaldoAutorizado.TabIndex = 43;
            lblSaldoAutorizado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(13, 27, 42);
            label11.Location = new Point(186, 346);
            label11.Name = "label11";
            label11.Size = new Size(280, 20);
            label11.TabIndex = 59;
            label11.Text = "_________________________________________________";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(27, 38, 59);
            label9.Location = new Point(352, 319);
            label9.Name = "label9";
            label9.Size = new Size(112, 15);
            label9.TabIndex = 58;
            label9.Text = "Saldo Autorizado";
            // 
            // panel8
            // 
            panel8.Controls.Add(btnConfirmar);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 384);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(511, 44);
            panel8.TabIndex = 58;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(27, 38, 59);
            btnConfirmar.Dock = DockStyle.Bottom;
            btnConfirmar.Enabled = false;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.FromArgb(224, 225, 221);
            btnConfirmar.Location = new Point(0, -1);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(511, 45);
            btnConfirmar.TabIndex = 38;
            btnConfirmar.Text = "Confirmar cambios";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(27, 38, 59);
            label7.Location = new Point(186, 40);
            label7.Name = "label7";
            label7.Size = new Size(283, 19);
            label7.TabIndex = 57;
            label7.Text = "Vista preliminar de tu tarjeta de crédito";
            // 
            // panel7
            // 
            panel7.Controls.Add(labelfECHA);
            panel7.Controls.Add(lbl);
            panel7.Controls.Add(lblCVC);
            panel7.Controls.Add(lblNombreBanco);
            panel7.Controls.Add(txtTarjeta);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(pctCard);
            panel7.Location = new Point(17, 80);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(461, 220);
            panel7.TabIndex = 0;
            // 
            // labelfECHA
            // 
            labelfECHA.Anchor = AnchorStyles.None;
            labelfECHA.BackColor = Color.Transparent;
            labelfECHA.FlatStyle = FlatStyle.Popup;
            labelfECHA.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic, GraphicsUnit.Point);
            labelfECHA.ForeColor = Color.White;
            labelfECHA.Location = new Point(313, 169);
            labelfECHA.Name = "labelfECHA";
            labelfECHA.Size = new Size(108, 32);
            labelfECHA.TabIndex = 40;
            labelfECHA.Text = "00/00";
            labelfECHA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(224, 225, 221);
            lbl.Location = new Point(325, 72);
            lbl.Name = "lbl";
            lbl.Size = new Size(38, 28);
            lbl.TabIndex = 37;
            lbl.Text = "CVV:";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCVC
            // 
            lblCVC.Anchor = AnchorStyles.None;
            lblCVC.BackColor = Color.Transparent;
            lblCVC.FlatStyle = FlatStyle.Popup;
            lblCVC.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblCVC.ForeColor = Color.White;
            lblCVC.Location = new Point(368, 72);
            lblCVC.Name = "lblCVC";
            lblCVC.Size = new Size(56, 28);
            lblCVC.TabIndex = 41;
            lblCVC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombreBanco
            // 
            lblNombreBanco.Anchor = AnchorStyles.None;
            lblNombreBanco.BackColor = Color.Transparent;
            lblNombreBanco.FlatStyle = FlatStyle.Flat;
            lblNombreBanco.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreBanco.ForeColor = Color.White;
            lblNombreBanco.Location = new Point(32, 18);
            lblNombreBanco.Name = "lblNombreBanco";
            lblNombreBanco.Size = new Size(351, 36);
            lblNombreBanco.TabIndex = 38;
            lblNombreBanco.Text = "Banco de Guayaquil";
            lblNombreBanco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Anchor = AnchorStyles.None;
            txtTarjeta.BackColor = Color.Transparent;
            txtTarjeta.FlatStyle = FlatStyle.Popup;
            txtTarjeta.Font = new Font("Courier New", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtTarjeta.ForeColor = Color.White;
            txtTarjeta.Location = new Point(32, 128);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(389, 36);
            txtTarjeta.TabIndex = 39;
            txtTarjeta.Text = "000000000000000";
            txtTarjeta.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Popup;
            lblNombre.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(34, 169);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(258, 32);
            lblNombre.TabIndex = 42;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pctCard
            // 
            pctCard.Dock = DockStyle.Fill;
            pctCard.Image = (Image)resources.GetObject("pctCard.Image");
            pctCard.Location = new Point(0, 0);
            pctCard.Name = "pctCard";
            pctCard.Size = new Size(461, 220);
            pctCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCard.TabIndex = 36;
            pctCard.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtAnio);
            panel2.Controls.Add(txtMes);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblTarjeta);
            panel2.Controls.Add(lblCodigoCvv);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 429);
            panel2.TabIndex = 1;
            // 
            // txtAnio
            // 
            txtAnio.Depth = 0;
            txtAnio.ForeColor = Color.FromArgb(13, 27, 42);
            txtAnio.Hint = "";
            txtAnio.Location = new Point(243, 246);
            txtAnio.Margin = new Padding(3, 2, 3, 2);
            txtAnio.MouseState = MaterialSkin.MouseState.HOVER;
            txtAnio.Name = "txtAnio";
            txtAnio.PasswordChar = '\0';
            txtAnio.SelectedText = "";
            txtAnio.SelectionLength = 0;
            txtAnio.SelectionStart = 0;
            txtAnio.Size = new Size(137, 23);
            txtAnio.TabIndex = 59;
            txtAnio.Text = "XXX";
            txtAnio.UseSystemPasswordChar = false;
            // 
            // txtMes
            // 
            txtMes.Depth = 0;
            txtMes.ForeColor = Color.FromArgb(13, 27, 42);
            txtMes.Hint = "";
            txtMes.Location = new Point(67, 246);
            txtMes.Margin = new Padding(3, 2, 3, 2);
            txtMes.MouseState = MaterialSkin.MouseState.HOVER;
            txtMes.Name = "txtMes";
            txtMes.PasswordChar = '\0';
            txtMes.SelectedText = "";
            txtMes.SelectionLength = 0;
            txtMes.SelectionStart = 0;
            txtMes.Size = new Size(146, 23);
            txtMes.TabIndex = 58;
            txtMes.Text = "XXX";
            txtMes.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(27, 38, 59);
            label8.Location = new Point(47, 282);
            label8.Name = "label8";
            label8.Size = new Size(152, 19);
            label8.TabIndex = 57;
            label8.Text = "Código de seguridad";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnGenerar);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 383);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(471, 44);
            panel6.TabIndex = 56;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(27, 38, 59);
            btnGenerar.Dock = DockStyle.Bottom;
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ForeColor = Color.FromArgb(224, 225, 221);
            btnGenerar.Location = new Point(0, 0);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(471, 44);
            btnGenerar.TabIndex = 38;
            btnGenerar.Text = "Generar tarjeta";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Depth = 0;
            txtNombre.ForeColor = Color.FromArgb(13, 27, 42);
            txtNombre.Hint = "";
            txtNombre.ImeMode = ImeMode.Off;
            txtNombre.Location = new Point(63, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "XXXX XXXXX XXXXXX";
            txtNombre.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(27, 38, 59);
            label6.Location = new Point(47, 40);
            label6.Name = "label6";
            label6.Size = new Size(225, 19);
            label6.TabIndex = 54;
            label6.Text = "Nombres y apellidos del cliente";
            // 
            // lblTarjeta
            // 
            lblTarjeta.Depth = 0;
            lblTarjeta.Font = new Font("Courier New", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lblTarjeta.ForeColor = Color.FromArgb(13, 27, 42);
            lblTarjeta.Hint = "";
            lblTarjeta.Location = new Point(63, 145);
            lblTarjeta.Margin = new Padding(3, 2, 3, 2);
            lblTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.PasswordChar = '\0';
            lblTarjeta.SelectedText = "";
            lblTarjeta.SelectionLength = 0;
            lblTarjeta.SelectionStart = 0;
            lblTarjeta.Size = new Size(317, 23);
            lblTarjeta.TabIndex = 1;
            lblTarjeta.Text = "00000 0000 0000 0";
            lblTarjeta.UseSystemPasswordChar = false;
            // 
            // lblCodigoCvv
            // 
            lblCodigoCvv.Depth = 0;
            lblCodigoCvv.ForeColor = Color.FromArgb(13, 27, 42);
            lblCodigoCvv.Hint = "";
            lblCodigoCvv.Location = new Point(72, 331);
            lblCodigoCvv.Margin = new Padding(3, 2, 3, 2);
            lblCodigoCvv.MouseState = MaterialSkin.MouseState.HOVER;
            lblCodigoCvv.Name = "lblCodigoCvv";
            lblCodigoCvv.PasswordChar = '\0';
            lblCodigoCvv.SelectedText = "";
            lblCodigoCvv.SelectionLength = 0;
            lblCodigoCvv.SelectionStart = 0;
            lblCodigoCvv.Size = new Size(317, 23);
            lblCodigoCvv.TabIndex = 4;
            lblCodigoCvv.Text = "XXX";
            lblCodigoCvv.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(27, 38, 59);
            label3.Location = new Point(63, 308);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 51;
            label3.Text = "CVV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(27, 38, 59);
            label1.Location = new Point(237, 219);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 50;
            label1.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(27, 38, 59);
            label5.Location = new Point(63, 219);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 47;
            label5.Text = "Mes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(27, 38, 59);
            label4.Location = new Point(47, 189);
            label4.Name = "label4";
            label4.Size = new Size(147, 19);
            label4.TabIndex = 44;
            label4.Text = "Fecha de expiración";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(27, 38, 59);
            label12.Location = new Point(47, 115);
            label12.Name = "label12";
            label12.Size = new Size(243, 19);
            label12.TabIndex = 41;
            label12.Text = "BIN/Número de tarjeta de crédito";
            // 
            // frmTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 519);
            Controls.Add(panel4);
            Controls.Add(panelContainer);
            MaximizeBox = false;
            Name = "frmTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTarjeta";
            Load += frmTarjeta_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctCard).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panelContainer;
        public Label cedula1;
        private Panel panel3;
        private Label lblCVV;
        public Label cedula;
        private TextBox textBox1;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private Panel panel8;
        private Button btnConfirmar;
        private Label label7;
        private Panel panel7;
        private Label labelfECHA;
        private Label lbl;
        private Label lblCVC;
        private Label lblNombreBanco;
        private Label txtTarjeta;
        private Label lblNombre;
        private PictureBox pctCard;
        private Panel panel2;
        private Panel panel6;
        private Button btnGenerar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblTarjeta;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblCodigoCvv;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label lblSaldoAutorizado;
        private Label label11;
        private Label label10;
        public Label cedula3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAnio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMes;
        private Panel panel9;
        private PictureBox pictureBox1;
    }
}