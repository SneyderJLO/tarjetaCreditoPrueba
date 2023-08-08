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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            lblCVV = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            lblNombreBanco = new Label();
            LBLvISA = new Label();
            labelfECHA = new Label();
            pctCard = new PictureBox();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctCard).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 38, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 344);
            panel1.TabIndex = 4;
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
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 225, 221);
            label2.Location = new Point(44, 23);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 5;
            label2.Text = "Confirmar cambios";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(27, 38, 59);
            panelContainer.Controls.Add(panel3);
            panelContainer.Controls.Add(label1);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(740, 107);
            panelContainer.TabIndex = 3;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 107);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 225, 221);
            label1.Location = new Point(201, 33);
            label1.Name = "label1";
            label1.Size = new Size(501, 42);
            label1.TabIndex = 4;
            label1.Text = "Neysser tenemea lojano";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(27, 38, 59);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(200, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(540, 383);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(lblCVV);
            panel6.Controls.Add(lblNumero);
            panel6.Controls.Add(lblNombre);
            panel6.Controls.Add(lblNombreBanco);
            panel6.Controls.Add(LBLvISA);
            panel6.Controls.Add(labelfECHA);
            panel6.Controls.Add(pctCard);
            panel6.Location = new Point(69, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(431, 262);
            panel6.TabIndex = 36;
            // 
            // lblCVV
            // 
            lblCVV.Anchor = AnchorStyles.None;
            lblCVV.BackColor = Color.Transparent;
            lblCVV.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCVV.ForeColor = Color.FromArgb(224, 225, 221);
            lblCVV.Location = new Point(313, 98);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(38, 25);
            lblCVV.TabIndex = 6;
            lblCVV.Text = "CVV:";
            lblCVV.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.None;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.FlatStyle = FlatStyle.Popup;
            lblNumero.Font = new Font("Courier New", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(30, 158);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(389, 36);
            lblNumero.TabIndex = 32;
            lblNumero.Text = "000000000000000";
            lblNumero.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.FlatStyle = FlatStyle.Popup;
            lblNombre.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(39, 214);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(164, 25);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "sadsad";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreBanco
            // 
            lblNombreBanco.Anchor = AnchorStyles.None;
            lblNombreBanco.BackColor = Color.Transparent;
            lblNombreBanco.FlatStyle = FlatStyle.Flat;
            lblNombreBanco.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreBanco.ForeColor = Color.White;
            lblNombreBanco.Location = new Point(30, 26);
            lblNombreBanco.Name = "lblNombreBanco";
            lblNombreBanco.Size = new Size(351, 36);
            lblNombreBanco.TabIndex = 28;
            lblNombreBanco.Text = "Banco del Pacífico";
            lblNombreBanco.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LBLvISA
            // 
            LBLvISA.Anchor = AnchorStyles.None;
            LBLvISA.BackColor = Color.Transparent;
            LBLvISA.FlatStyle = FlatStyle.Popup;
            LBLvISA.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBLvISA.ForeColor = Color.White;
            LBLvISA.Location = new Point(357, 98);
            LBLvISA.Name = "LBLvISA";
            LBLvISA.Size = new Size(56, 27);
            LBLvISA.TabIndex = 34;
            LBLvISA.Text = "b";
            LBLvISA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelfECHA
            // 
            labelfECHA.Anchor = AnchorStyles.None;
            labelfECHA.BackColor = Color.Transparent;
            labelfECHA.FlatStyle = FlatStyle.Popup;
            labelfECHA.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelfECHA.ForeColor = Color.White;
            labelfECHA.Location = new Point(209, 214);
            labelfECHA.Name = "labelfECHA";
            labelfECHA.Size = new Size(79, 25);
            labelfECHA.TabIndex = 33;
            labelfECHA.Text = "00/00";
            labelfECHA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pctCard
            // 
            pctCard.Anchor = AnchorStyles.None;
            pctCard.Image = (Image)resources.GetObject("pctCard.Image");
            pctCard.Location = new Point(3, 0);
            pctCard.Name = "pctCard";
            pctCard.Size = new Size(428, 256);
            pctCard.TabIndex = 0;
            pctCard.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(27, 38, 59);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, 303);
            panel5.Name = "panel5";
            panel5.Size = new Size(538, 60);
            panel5.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(210, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 225, 221);
            label3.Location = new Point(249, 16);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 6;
            label3.Text = "Generar valores";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 451);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelContainer);
            Name = "frmTarjeta";
            Text = "frmTarjeta";
            Load += frmTarjeta_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctCard).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panelContainer;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pctCard;
        private Label lblNombreBanco;
        private Label lblNombre;
        private Label labelfECHA;
        private Label lblNumero;
        private Label LBLvISA;
        private Label lblCVV;
        private Panel panel6;
        private PictureBox pictureBox3;
    }
}