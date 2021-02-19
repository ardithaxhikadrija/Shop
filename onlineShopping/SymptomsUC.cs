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
    public partial class SymptomsUC : UserControl
    {
        public SymptomsUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kokedhimbje" || textBox1.Text == "Headache")
            {
                MessageBox.Show("Our algorithm recommend you: Aspirin", "Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your symptoms aren't clear for us.\nTry again!", "Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
