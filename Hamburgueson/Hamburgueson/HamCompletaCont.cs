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
    public partial class HamCompletaCont : UserControl
    {
        int hamTotales = 0;
        double precioTotal = 0;
        //List<Hamburguesa> hams = new List<Hamburguesa>();

        public HamCompletaCont()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hamburguesa ham = new Hamburguesa();

            ham.setNombre("Hamburguesa completa");

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

            ham.setPrecio(4);

            precioTotal = precioTotal + 4;
            hamTotales = hamTotales + 1;

            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();


            Form1.hams.Add(ham);
            Carrito.addCarrito(ham);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.hams.RemoveAt(Form1.hams.Count - 1);
            precioTotal = precioTotal - 4;
            hamTotales = hamTotales - 1;
            label4.Text = precioTotal.ToString() + "€";
            textBox1.Text = hamTotales.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
