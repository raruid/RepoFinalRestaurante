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
    public partial class PatatasContr : UserControl
    {

        int hamTotales = 0;
        double precioTotal = 0;
        //List<Complemento> hams = new List<Complemento>();

        public PatatasContr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complemento ham = new Complemento();

            ham.setNombre("Patatas");

            if (checkBox1.Checked)
            {
                ham.setKetchup(true);
            }
            else
            {
                ham.setKetchup(false);
            }

            if (checkBox2.Checked)
            {
                ham.setMayo(true);
            }
            else
            {
                ham.setMayo(false);
            }

            if (checkBox3.Checked)
            {
                ham.setMustaza(true);
            }
            else
            {
                ham.setMustaza(false);
            }

            ham.setPrecio(2.5);

            precioTotal = precioTotal + 2.5;
            hamTotales = hamTotales + 1;

            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();


            Form1.hams.Add(ham);
            Carrito.addCarrito(ham);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.hams.RemoveAt(Form1.hams.Count - 1);
            precioTotal = precioTotal - 2.5;
            hamTotales = hamTotales - 1;
            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();
        }
    }
}
