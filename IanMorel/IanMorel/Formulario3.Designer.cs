namespace IanMorel
{
    partial class Formulario3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Mostrarutton2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NombreTextBox1 = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mostrarutton2
            // 
            this.Mostrarutton2.Location = new System.Drawing.Point(517, 270);
            this.Mostrarutton2.Name = "Mostrarutton2";
            this.Mostrarutton2.Size = new System.Drawing.Size(173, 80);
            this.Mostrarutton2.TabIndex = 1;
            this.Mostrarutton2.Text = "Mostrar";
            this.Mostrarutton2.UseVisualStyleBackColor = true;
            this.Mostrarutton2.Click += new System.EventHandler(this.Mostrarutton2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(216, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 420);
            this.listBox1.TabIndex = 2;
            // 
            // NombreTextBox1
            // 
            this.NombreTextBox1.Location = new System.Drawing.Point(49, 197);
            this.NombreTextBox1.Name = "NombreTextBox1";
            this.NombreTextBox1.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox1.TabIndex = 3;
            // 
            // ApellidoTextBox1
            // 
            this.ApellidoTextBox1.Location = new System.Drawing.Point(49, 254);
            this.ApellidoTextBox1.Name = "ApellidoTextBox1";
            this.ApellidoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ApellidoTextBox1.TabIndex = 4;
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApellidoTextBox1);
            this.Controls.Add(this.NombreTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Mostrarutton2);
            this.Controls.Add(this.button1);
            this.Name = "Formulario3";
            this.Text = "Formulario3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mostrarutton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox NombreTextBox1;
        private System.Windows.Forms.TextBox ApellidoTextBox1;
    }
}