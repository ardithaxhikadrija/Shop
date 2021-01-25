using System;
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
    public partial class OrderForm : Form
    {
        CartForm cf;
        public OrderForm(CartForm cart)
        {
            InitializeComponent();
            this.cf = cart;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            label2.Text = cf.label4.Text;
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
