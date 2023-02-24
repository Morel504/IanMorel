using System;
using System.Windows.Forms;

namespace IanMorel
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double capital = 200000.00;
            double tasaInteresMensual = 0.015;
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            double[] intereses = new double[12];

            for (int i = 0; i < meses.Length; i++)
            {
                double interesMensual = calcularInteresMensual(capital, tasaInteresMensual);
                intereses[i] = interesMensual;
                capital += interesMensual;
            }

            listBox1.Items.Clear();
            for (int i = 0; i < meses.Length; i++)
            {
                string item = meses[i] + " - " + intereses[i].ToString("C2");
                listBox1.Items.Add(item);
            }
        }

        private double calcularInteresMensual(double capital, double tasaInteresMensual)
        {
            double interes = capital * tasaInteresMensual;
            return interes;
        }

        private void RegresarButton1_Click(object sender, EventArgs e)
        {
            Principal principalFormulario = new Principal();
            this.Hide();
            principalFormulario.Show();
        }
    }
}

