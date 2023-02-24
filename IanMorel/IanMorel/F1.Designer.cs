namespace IanMorel
{
    partial class F1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.RegresarButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(284, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 175);
            this.listBox1.TabIndex = 0;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(540, 132);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(207, 44);
            this.CalcularButton.TabIndex = 1;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // RegresarButton1
            // 
            this.RegresarButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarButton1.Location = new System.Drawing.Point(31, 132);
            this.RegresarButton1.Name = "RegresarButton1";
            this.RegresarButton1.Size = new System.Drawing.Size(207, 44);
            this.RegresarButton1.TabIndex = 2;
            this.RegresarButton1.Text = "Regresar";
            this.RegresarButton1.UseVisualStyleBackColor = true;
            this.RegresarButton1.Click += new System.EventHandler(this.RegresarButton1_Click);
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegresarButton1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.listBox1);
            this.Name = "F1";
            this.Text = "F1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button RegresarButton1;
    }
}