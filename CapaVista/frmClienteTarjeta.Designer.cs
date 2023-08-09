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
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtCedula = new TextBox();
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
            panelContainer.Controls.Add(button1);
            panelContainer.Controls.Add(pictureBox2);
            panelContainer.Controls.Add(label3);
            panelContainer.Controls.Add(label1);
            panelContainer.Controls.Add(txtCedula);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(833, 102);
            panelContainer.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(658, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(403, 71);
            label3.Name = "label3";
            label3.Size = new Size(209, 27);
            label3.TabIndex = 5;
            label3.Text = "________________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 225, 221);
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 34);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el número de cédula";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCedula.BackColor = Color.FromArgb(27, 38, 59);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCedula.ForeColor = SystemColors.Window;
            txtCedula.Location = new Point(403, 48);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(209, 21);
            txtCedula.TabIndex = 1;
            txtCedula.TextAlign = HorizontalAlignment.Center;
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
            dtgDatosCliente.BackgroundColor = Color.FromArgb(224, 225, 221);
            dtgDatosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosCliente.Dock = DockStyle.Right;
            dtgDatosCliente.Location = new Point(197, 102);
            dtgDatosCliente.Name = "dtgDatosCliente";
            dtgDatosCliente.RowTemplate.Height = 25;
            dtgDatosCliente.Size = new Size(636, 348);
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
            ClientSize = new Size(833, 450);
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
        private TextBox txtCedula;
        private DataGridView dtgDatosCliente;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Button button1;
    }
}