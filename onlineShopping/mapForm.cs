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
    public partial class mapForm: Form
    {
        public mapForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void kerkoButton_Click(object sender, EventArgs e)
        {
            string rruga = rrugaTextBox.Text;
            string qyteti = qytetiTextBox.Text;
            string shteti = shtetiTextBox.Text;
            string zip = zipTextBox.Text;
            try 
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if (rruga != string.Empty)
                {
                    queryaddress.Append(rruga + "," + "+");
                }
                if (qyteti != string.Empty)
                {
                    queryaddress.Append(qyteti + "," + "+");
                }
                if (shteti != string.Empty)
                {
                    queryaddress.Append(shteti + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shtetiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qytetiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rrugaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
