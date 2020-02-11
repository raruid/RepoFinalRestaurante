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
    public partial class OtrosController : UserControl
    {
        ArosCebContr cont1;
        PatatasContr cont2;
        Nuggets cont3;

        public OtrosController()
        {
            InitializeComponent();
        }

        internal void setControllers(ArosCebContr arosCebContr1, PatatasContr patatasContr1, Nuggets nuggets1)
        {
            this.cont1 = arosCebContr1;
            this.cont2 = patatasContr1;
            this.cont3 = nuggets1;
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
            cont2.BringToFront();
        }
    }
}
