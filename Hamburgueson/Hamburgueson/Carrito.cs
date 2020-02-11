using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hamburgueson
{
    public partial class Carrito : UserControl
    {
        public static List<double> precios = new List<double>();
        public static double totalPrecioCarrito;

        public Carrito()
        {
            InitializeComponent();
            take_away1.Hide();
        }

        public static void addCarrito(Elemento ele)
        {
            double precio;

            precio = ele.getPrecio();
            ListViewItem item;
            item = new ListViewItem(ele.getNombre());

            //item.SubItems.Add();
            
            item.SubItems.Add(ele.getPrecio().ToString());


            precios.Add(precio);
            sumarPrecios();

            lista.Items.Add(item);
        }

        public static void sumarPrecios()
        {
            totalPrecioCarrito = 0;

            if (precios.Count != 0)
            {
                for (int i = 0; i < precios.Count; i++)
                {
                    totalPrecioCarrito += precios[i];
                    textBox2.Text = totalPrecioCarrito.ToString() + "€";
                }
            }
            else
            {
                textBox2.Text = totalPrecioCarrito.ToString() + "€";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lista.SelectedItems)
            {
                int i = item.Index;
                precios.RemoveAt(i);
                item.Remove();
                sumarPrecios();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            take_away1.Show();
            take_away1.BringToFront();
        }
    }
}
