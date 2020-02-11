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
    public partial class Ham3Contr : UserControl
    {

        int hamTotales = 0;
        double precioTotal = 0;
        //List<HamburguesaBacon> hams = new List<HamburguesaBacon>();
        public Ham3Contr()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HamburguesaBacon ham = new HamburguesaBacon();

            ham.setNombre("Hamburguesa Mustard Pro");

            if (checkBox1.Checked)
            {
                ham.setQueso(true);
            }
            else
            {
                ham.setQueso(false);
            }

            if (checkBox2.Checked)
            {
                ham.setTomate(true);
            }
            else
            {
                ham.setTomate(false);
            }

            if (checkBox3.Checked)
            {
                ham.setLechuga(true);
            }
            else
            {
                ham.setLechuga(false);
            }

            if (checkBox4.Checked)
            {
                ham.setBacon(true);
            }
            else
            {
                ham.setBacon(false);
            }

            ham.setPrecio(6);

            precioTotal = precioTotal + 6;
            hamTotales = hamTotales + 1;

            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();


            Form1.hams.Add(ham);
            Carrito.addCarrito(ham);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.hams.RemoveAt(Form1.hams.Count - 1);
            precioTotal = precioTotal - 6;
            hamTotales = hamTotales - 1;
            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();
        }
    }
}
