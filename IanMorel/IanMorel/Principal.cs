using System;
using System.Windows.Forms;

namespace IanMorel
{

    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {
            F1 menuFormulario1 = new F1();
            this.Hide();
            menuFormulario1.Show();
        }


        private void toolStripTabItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem3_Click(object sender, EventArgs e)
        {


        }

        private void toolStripTabItem4_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2();
            this.Hide();
            formulario2.Show();
        }

        private void toolStripTabItem5_Click(object sender, EventArgs e)
        {
            Formulario3 formulario3 = new Formulario3();
            this.Hide();
            formulario3.Show();
        }
    }
}
