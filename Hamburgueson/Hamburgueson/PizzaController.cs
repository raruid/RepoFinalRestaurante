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
    public partial class PizzaController : UserControl
    {
        PizzaMustCont cont1;
        PizzaPepeContr cont2;
        PizzaMustanaContr cont3;
        PizzaQuesosContr cont4;

        public PizzaController()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        internal void setControllers(PizzaMustCont cont1, PizzaPepeContr cont2, PizzaMustanaContr cont3, PizzaQuesosContr cont4)
        {
            this.cont1 = cont1;
            this.cont2 = cont2;
            this.cont3 = cont3;
            this.cont4 = cont4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cont2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cont3.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont4.BringToFront();
        }
    }
}
