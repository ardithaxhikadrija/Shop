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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            signUp1.Hide();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            signUp1.Show();
        }
    }
}
