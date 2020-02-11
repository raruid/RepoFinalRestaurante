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
    public partial class Take_away : UserControl
    {
        public Take_away()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pedido se ha realizado correctamente, \nrecoja el ticket de su pedido");
            this.Hide();
        }
    }
}
