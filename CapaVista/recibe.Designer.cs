namespace CapaVista
{
    partial class recibe
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
            txt_recibe = new TextBox();
            SuspendLayout();
            // 
            // txt_recibe
            // 
            txt_recibe.Location = new Point(210, 81);
            txt_recibe.Name = "txt_recibe";
            txt_recibe.Size = new Size(238, 23);
            txt_recibe.TabIndex = 0;
            // 
            // recibe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_recibe);
            Name = "recibe";
            Text = "recibe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_recibe;
    }
}