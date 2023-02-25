using System;
using System.Windows.Forms;

namespace IanMorel
{
    public partial class Formulario3 : Form
    {
        private string nombre;
        private string apellido;
        public Formulario3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.Show();
        }

        private void Mostrarutton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTextBox1.Text))
            {
                errorProvider1.SetError(NombreTextBox1, "Ingrese unNombre");
                NombreTextBox1.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(ApellidoTextBox1.Text))
            {
                errorProvider1.SetError(ApellidoTextBox1, "Ingrese unNombre");
                ApellidoTextBox1.Focus();
                return;
            }

            errorProvider1.Clear();
            nombre = NombreTextBox1.Text;
            apellido = ApellidoTextBox1.Text;
            listBox1.Items.Clear();
            MostrarNumeros();
        }

        private void MostrarNumeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(nombre + " " + apellido);
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add(nombre);
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add(apellido);
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

