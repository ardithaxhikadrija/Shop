﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineShopping
{
    public partial class Tracking : UserControl
    {
        public Tracking()
        {
            InitializeComponent();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has not been shipped yet!","Tracking",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
