using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IanMorel
{
    public partial class Formulario2 : Form
    {
        List<Producto> productos = new List<Producto>();
        bool seguirAgregandoProductos = true;
        public Formulario2()
        {
            InitializeComponent();
        }

        private void RegresarButton1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.Show();
        }

        private async void CalcularButton1_Click(object sender, EventArgs e)
        {
            decimal totalVenta = 0;

            foreach (Producto producto in productos)
            {
                totalVenta += producto.PrecioUnitario;
            }

            decimal descuento = await CalcularDescuento(totalVenta);

            decimal totalAPagar = totalVenta - descuento;

            MessageBox.Show($"Total venta: ${totalVenta}\nDescuento del 15%: ${descuento}\nTotal a pagar: ${totalAPagar}");
        }

        private async Task<decimal> CalcularDescuento(decimal totalVenta)
        {
            await Task.Delay(2000); // Simulamos una tarea asíncrona que demora 2 segundos.

            return totalVenta * 0.15m;
        }

        private void AgregarButton1_Click(object sender, EventArgs e)
        {
            string nombreProducto = NombreTextBox1.Text;
            decimal precioUnitario = decimal.Parse(PrecioTextBox1.Text);

            productos.Add(new Producto(nombreProducto, precioUnitario));

            MessageBox.Show("Producto agregado");

            NombreTextBox1.Clear();
            PrecioTextBox1.Clear();
        }
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            seguirAgregandoProductos = false;
        }

    }

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }

        public Producto(string nombre, decimal precioUnitario)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;

        }

    }
}
