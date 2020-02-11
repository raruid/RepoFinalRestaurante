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
    public partial class BebidasControler : UserControl
    {
        public BebidasControler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elemento el = new Elemento();

            el.setNombre("Cerveza");
            el.setPrecio(2);

            Form1.hams.Add(el);

            Carrito.addCarrito(el);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elemento el = new Elemento();

            el.setNombre("Coca Cola");
            el.setPrecio(1.5);

            Form1.hams.Add(el);

            Carrito.addCarrito(el);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elemento el = new Elemento();

            el.setNombre("Fanta");
            el.setPrecio(1);

            Form1.hams.Add(el);

            Carrito.addCarrito(el);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elemento el = new Elemento();

            el.setNombre("Nestea");
            el.setPrecio(2.5);

            Form1.hams.Add(el);

            Carrito.addCarrito(el);
        }
    }
}
