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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblConfirm = new Label();
            cedula3 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            lbl = new Label();
            txtTarjeta = new Label();
            lblNombre = new Label();
            lblNombreBanco = new Label();
            lblCVC = new Label();
            labelfECHA = new Label();
            pctCard = new PictureBox();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            lblGenerar = new Label();
            lblNombreCliente = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctCard).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 395);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblConfirm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 185);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblConfirm
            // 
            lblConfirm.Cursor = Cursors.Hand;
            lblConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirm.ForeColor = Color.FromArgb(224, 225, 221);
            lblConfirm.Location = new Point(44, 23);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(131, 26);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "Confirmar cambios";
            lblConfirm.TextAlign = ContentAlignment.MiddleLeft;
            lblConfirm.Click += lblConfirm_Click;
            // 
            // cedula3
            // 
            cedula3.BackColor = Color.Transparent;
            cedula3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cedula3.ForeColor = SystemColors.ButtonFace;
            cedula3.Location = new Point(640, 40);
            cedula3.Name = "cedula3";
            cedula3.Size = new Size(88, 42);
            cedula3.TabIndex = 6;
            cedula3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(27, 38, 59);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(532, 395);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(lbl);
            panel6.Controls.Add(txtTarjeta);
            panel6.Controls.Add(lblNombre);
            panel6.Controls.Add(lblNombreBanco);
            panel6.Controls.Add(lblCVC);
            panel6.Controls.Add(labelfECHA);
            panel6.Controls.Add(pctCard);
            panel6.Location = new Point(52, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 272);
            panel6.TabIndex = 36;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(224, 225, 221);
            lbl.Location = new Point(313, 103);
            lbl.Name = "lbl";
            lbl.Size = new Size(38, 25);
            lbl.TabIndex = 6;
            lbl.Text = "CVV:";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Anchor = AnchorStyles.None;
            txtTarjeta.BackColor = Color.Transparent;
            txtTarjeta.FlatStyle = FlatStyle.Popup;
            txtTarjeta.Font = new Font("Courier New", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            txtTarjeta.ForeColor = Color.White;
            txtTarjeta.Location = new Point(30, 163);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(389, 36);
            txtTarjeta.TabIndex = 32;
            txtTarjeta.Text = "000000000000000";
            txtTarjeta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Popup;
            lblNombre.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(39, 219);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(164, 25);
            lblNombre.TabIndex = 35;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreBanco
            // 
            lblNombreBanco.Anchor = AnchorStyles.None;
            lblNombreBanco.BackColor = Color.Transparent;
            lblNombreBanco.FlatStyle = FlatStyle.Flat;
            lblNombreBanco.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreBanco.ForeColor = Color.White;
            lblNombreBanco.Location = new Point(30, 31);
            lblNombreBanco.Name = "lblNombreBanco";
            lblNombreBanco.Size = new Size(351, 36);
            lblNombreBanco.TabIndex = 28;
            lblNombreBanco.Text = "Banco del Pacífico";
            lblNombreBanco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCVC
            // 
            lblCVC.Anchor = AnchorStyles.None;
            lblCVC.BackColor = Color.Transparent;
            lblCVC.FlatStyle = FlatStyle.Popup;
            lblCVC.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCVC.ForeColor = Color.White;
            lblCVC.Location = new Point(357, 103);
            lblCVC.Name = "lblCVC";
            lblCVC.Size = new Size(56, 27);
            lblCVC.TabIndex = 34;
            lblCVC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelfECHA
            // 
            labelfECHA.Anchor = AnchorStyles.None;
            labelfECHA.BackColor = Color.Transparent;
            labelfECHA.FlatStyle = FlatStyle.Popup;
            labelfECHA.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelfECHA.ForeColor = Color.White;
            labelfECHA.Location = new Point(235, 212);
            labelfECHA.Name = "labelfECHA";
            labelfECHA.Size = new Size(79, 32);
            labelfECHA.TabIndex = 33;
            labelfECHA.Text = "00/00";
            labelfECHA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pctCard
            // 
            pctCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pctCard.Image = (Image)resources.GetObject("pctCard.Image");
            pctCard.Location = new Point(0, 2);
            pctCard.Name = "pctCard";
            pctCard.Size = new Size(428, 267);
            pctCard.TabIndex = 0;
            pctCard.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(27, 38, 59);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(lblGenerar);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 309);
            panel5.Name = "panel5";
            panel5.Size = new Size(530, 84);
            panel5.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(184, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // lblGenerar
            // 
            lblGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGenerar.Cursor = Cursors.Hand;
            lblGenerar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenerar.ForeColor = Color.FromArgb(224, 225, 221);
            lblGenerar.Location = new Point(223, 32);
            lblGenerar.Name = "lblGenerar";
            lblGenerar.Size = new Size(121, 24);
            lblGenerar.TabIndex = 6;
            lblGenerar.Text = "Generar valores";
            lblGenerar.TextAlign = ContentAlignment.MiddleLeft;
            lblGenerar.Click += label3_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombreCliente.ForeColor = Color.FromArgb(224, 225, 221);
            lblNombreCliente.Location = new Point(320, 40);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(314, 42);
            lblNombreCliente.TabIndex = 4;
            lblNombreCliente.TextAlign = ContentAlignment.MiddleRight;
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
            panelContainer.Controls.Add(cedula3);
            panelContainer.Controls.Add(panel3);
            panelContainer.Controls.Add(lblNombreCliente);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(732, 85);
            panelContainer.TabIndex = 3;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // frmTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 480);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelContainer);
            MaximizeBox = false;
            Name = "frmTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTarjeta";
            Load += frmTarjeta_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctCard).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblConfirm;
        private PictureBox pictureBox2;
        private Panel panelContainer;
        public Label cedula1;
        private Label lblNombreCliente;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblGenerar;
        private PictureBox pictureBox4;
        private PictureBox pctCard;
        private Label lblNombreBanco;
        private Label lblNombre;
        private Label labelfECHA;
        private Label txtTarjeta;
        private Label lblCVC;
        private Label lblCVV;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label lbl;
        public Label cedula;
        private Label label1;
        private TextBox textBox1;
        public Label cedula3;
    }
}