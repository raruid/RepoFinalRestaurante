using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgueson
{
    public partial class PizzaQuesosContr : UserControl
    {
        int hamTotales = 0;
        double precioTotal = 0;
        //List<Pizza> hams = new List<Pizza>();

        public PizzaQuesosContr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pizza ham = new Pizza();

            ham.setNombre("Pizza 10 Quesos");

            ham.setRucula(false);

            ham.setBacon(false);

            ham.setPrecio(10);

            precioTotal = precioTotal + 10;
            hamTotales = hamTotales + 1;

            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();


            Form1.hams.Add(ham);
            Carrito.addCarrito(ham);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.hams.RemoveAt(Form1.hams.Count - 1);
            precioTotal = precioTotal - 10;
            hamTotales = hamTotales - 1;
            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
