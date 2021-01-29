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
    public partial class aboutUsForm : Form
    {
        public aboutUsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, Color.MidnightBlue);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void storesButton_Click(object sender, EventArgs e)
        {
            StoreForm store2 = new StoreForm();
            store2.Show();
            this.Hide();
        }

        private void profilesButton_Click(object sender, EventArgs e)
        {
            profileForm profile2 = new profileForm();
            profile2.Show();
            this.Hide();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm cart2 = new CartForm();
            cart2.Show();
            this.Hide();
        }
    }
}
