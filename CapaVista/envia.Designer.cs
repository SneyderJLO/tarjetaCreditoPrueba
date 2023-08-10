namespace CapaVista
{
    partial class envia
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
            txt_envia = new TextBox();
            btn_envia = new Button();
            SuspendLayout();
            // 
            // txt_envia
            // 
            txt_envia.Location = new Point(252, 108);
            txt_envia.Name = "txt_envia";
            txt_envia.Size = new Size(238, 23);
            txt_envia.TabIndex = 1;
            // 
            // btn_envia
            // 
            btn_envia.Location = new Point(323, 189);
            btn_envia.Name = "btn_envia";
            btn_envia.Size = new Size(75, 23);
            btn_envia.TabIndex = 2;
            btn_envia.Text = "enviar";
            btn_envia.UseVisualStyleBackColor = true;
            btn_envia.Click += btn_envia_Click;
            // 
            // envia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_envia);
            Controls.Add(txt_envia);
            Name = "envia";
            Text = "envia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_envia;
        private Button btn_envia;
    }
}