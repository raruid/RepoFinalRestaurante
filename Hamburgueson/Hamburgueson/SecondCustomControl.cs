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
    public partial class SecondCustomControl : UserControl
    {
        HamBasicaContr cont1;
        HamCompletaCont cont2;
        Ham3Contr cont3;
        HamMounstCont cont4;

        public SecondCustomControl()
        {
            InitializeComponent();
        }

        private void SecondCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setControls(HamBasicaContr cont1, HamCompletaCont cont2, Ham3Contr cont3, HamMounstCont cont4)
        {
            this.cont1 = cont1;
            this.cont2 = cont2;
            this.cont3 = cont3;
            this.cont4 = cont4;
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
