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
            profile1.Hide();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            profileControl1.Hide();
        }

        private void profile1_Load(object sender, EventArgs e)
        {
            
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile1.Show();
        }

        private void scrollButton_Click(object sender, EventArgs e)
        {

        }

        private void profile1_Load_1(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void profile1_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StoreForm store = new StoreForm();
            store.Show();
            this.Hide();
        }

        private void menuPanel21_Load(object sender, EventArgs e)
        {

        }

        private void profilesButton_Click(object sender, EventArgs e)
        {
            profileControl1.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            profileControl1.Hide();
        }
    }
}
