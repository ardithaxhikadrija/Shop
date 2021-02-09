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
            tracking1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            label2.Text = cf.label4.Text;
            label1.Text = cf.label3.Text;
            label7.Text = cf.totaliBox.Text;
            while (cf.listBoxCart.Items.Count != 0)
            {
                for(int i = 0; i < cf.listBoxCart.Items.Count; i++)
                {
                    listBox1.Items.Add(cf.listBoxCart.Items[i]);
                    cf.listBoxCart.Items.Remove(cf.listBoxCart.Items[i]);
                }
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartButton_Click_1(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Hide();
        }

        private void storesButton_Click(object sender, EventArgs e)
        {
            StoreForm store = new StoreForm();
            store.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tracking1.Show();
        }
    }
}
