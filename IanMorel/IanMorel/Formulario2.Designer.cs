namespace IanMorel
{
    partial class Formulario2
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
            this.RegresarButton1 = new System.Windows.Forms.Button();
            this.PrecioTextBox1 = new System.Windows.Forms.TextBox();
            this.NombreTextBox1 = new System.Windows.Forms.TextBox();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.AgregarButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegresarButton1
            // 
            this.RegresarButton1.Location = new System.Drawing.Point(41, 116);
            this.RegresarButton1.Name = "RegresarButton1";
            this.RegresarButton1.Size = new System.Drawing.Size(160, 44);
            this.RegresarButton1.TabIndex = 0;
            this.RegresarButton1.Text = "Regresar";
            this.RegresarButton1.UseVisualStyleBackColor = true;
            this.RegresarButton1.Click += new System.EventHandler(this.RegresarButton1_Click);
            // 
            // PrecioTextBox1
            // 
            this.PrecioTextBox1.Location = new System.Drawing.Point(293, 209);
            this.PrecioTextBox1.Name = "PrecioTextBox1";
            this.PrecioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox1.TabIndex = 1;
            this.PrecioTextBox1.Text = "Precio";
            // 
            // NombreTextBox1
            // 
            this.NombreTextBox1.Location = new System.Drawing.Point(293, 173);
            this.NombreTextBox1.Name = "NombreTextBox1";
            this.NombreTextBox1.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox1.TabIndex = 2;
            this.NombreTextBox1.Text = "Nombre";
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(494, 171);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(149, 40);
            this.CalcularButton1.TabIndex = 3;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // AgregarButton1
            // 
            this.AgregarButton1.Location = new System.Drawing.Point(508, 127);
            this.AgregarButton1.Name = "AgregarButton1";
            this.AgregarButton1.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton1.TabIndex = 4;
            this.AgregarButton1.Text = "Agregar";
            this.AgregarButton1.UseVisualStyleBackColor = true;
            this.AgregarButton1.Click += new System.EventHandler(this.AgregarButton1_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgregarButton1);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.NombreTextBox1);
            this.Controls.Add(this.PrecioTextBox1);
            this.Controls.Add(this.RegresarButton1);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegresarButton1;
        private System.Windows.Forms.TextBox PrecioTextBox1;
        private System.Windows.Forms.TextBox NombreTextBox1;
        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.Button AgregarButton1;
    }
}