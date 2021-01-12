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
    public partial class menuPanel : UserControl
    {
        public menuPanel()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(50, Color.MidnightBlue);
        }

        private void menuPanel_Load(object sender, EventArgs e)
        {

        }

        private void ordersButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
