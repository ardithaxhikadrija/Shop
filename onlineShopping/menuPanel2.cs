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
    public partial class menuPanel2 : UserControl
    {
        public menuPanel2()
        {
            InitializeComponent();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {

        }

        private void menuPanel2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, Color.MidnightBlue);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void storesButton_Click(object sender, EventArgs e)
        {
            StoreForm store = new StoreForm();
            store.Show();
            this.Hide();
        }
    }
}
