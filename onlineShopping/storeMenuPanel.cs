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
    public partial class storeMenuPanel : UserControl
    {
        public storeMenuPanel()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(50, Color.MidnightBlue);

        }

        private void storeMenuPanel_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeForm home = new homeForm();
            home.Show();
            StoreForm store = new StoreForm();
            store.Hide();
            this.Hide();
        }

        private void storesButton_Click(object sender, EventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {

        }

        private void ordersButton_Click(object sender, EventArgs e)
        {

        }

        private void profilesButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
