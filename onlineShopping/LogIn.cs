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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)){
                MessageBox.Show("Please enter a username","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a valid password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
