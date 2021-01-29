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
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        private void nrtelLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void storesButton_Click(object sender, EventArgs e)
        {
            StoreForm store1 = new StoreForm();
            store1.Show();
            this.Hide();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            kartelaControl1.Hide();
        }

        private void kartelaButton_Click(object sender, EventArgs e)
        {
            kartelaControl1.Show();
        }

        private void lokacioniButton_Click(object sender, EventArgs e)
        {
            mapForm map = new mapForm();
            map.Show();
            this.Hide();
        }

        private void kartelaControl1_Load(object sender, EventArgs e)
        {

        }

        private void editoButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutusButton_Click(object sender, EventArgs e)
        {
            aboutUsForm aboutus2 = new aboutUsForm();
            aboutus2.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm cart3 = new CartForm();
            cart3.Show();
            this.Hide();
        }
    }
}
