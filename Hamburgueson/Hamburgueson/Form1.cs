﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaHamburguesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            //firstCustomControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            //firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            //mySecondCustomControl1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
