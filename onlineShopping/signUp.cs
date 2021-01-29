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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void signUpButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Please enter username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return;

            }
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Password is incorrect! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IUserRepository repositrory = new UserRepository();
            bool result = await repositrory.Insert(new User() { UserName = txtUser.Text, Password = txtPassword.Text, Email = txtEmail.Text, FullName = txtFullName.Text });
            if (result)
                MessageBox.Show("You have successfully Signed Up", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
