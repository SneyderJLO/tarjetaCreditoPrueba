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
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtCedula = new TextBox();
            btn_actualizar = new Button();
            pictureBox1 = new PictureBox();
            dtgDatosCliente = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDatosCliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(27, 38, 59);
            panelContainer.Controls.Add(pictureBox2);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(txtCedula);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1034, 102);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(332, 71);
            label3.Name = "label3";
            label3.Size = new Size(481, 27);
            label3.TabIndex = 5;
            label3.Text = "________________________________________";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 225, 221);
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(521, 34);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el número de cédula";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Right;
            txtCedula.BackColor = Color.FromArgb(27, 38, 59);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(475, 47);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(199, 21);
            txtCedula.TabIndex = 1;
            txtCedula.TextAlign = HorizontalAlignment.Center;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = Color.FromArgb(224, 225, 221);
            btn_actualizar.FlatStyle = FlatStyle.Popup;
            btn_actualizar.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.ForeColor = Color.FromArgb(27, 38, 59);
            btn_actualizar.Location = new Point(835, 418);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(199, 32);
            btn_actualizar.TabIndex = 6;
            btn_actualizar.Text = "Actualizar Registros";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dtgDatosCliente
            // 
            dtgDatosCliente.Anchor = AnchorStyles.Right;
            dtgDatosCliente.BackgroundColor = Color.FromArgb(224, 225, 221);
            dtgDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosCliente.GridColor = Color.FromArgb(224, 225, 221);
            dtgDatosCliente.Location = new Point(174, 102);
            dtgDatosCliente.Name = "dtgDatosCliente";
            dtgDatosCliente.RowTemplate.Height = 25;
            dtgDatosCliente.Size = new Size(860, 310);
            dtgDatosCliente.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 348);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 185);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 225, 221);
            label2.Location = new Point(60, 34);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 5;
            label2.Text = "Generar tarjeta";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // frmClienteTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 225, 221);
            ClientSize = new Size(1034, 450);
            Controls.Add(btn_actualizar);
            Controls.Add(panel1);
            Controls.Add(dtgDatosCliente);
            Controls.Add(panelContainer);
            MaximizeBox = false;
            Name = "frmClienteTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDatosCliente).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private DataGridView dtgDatosCliente;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        public TextBox txtCedula;
        private Button btn_actualizar;
    }
}