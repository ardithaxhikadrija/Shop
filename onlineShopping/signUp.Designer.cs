
namespace onlineShopping
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.Label();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.conEmailAddress = new System.Windows.Forms.Label();
            this.conEmailAdd = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.conPassword = new System.Windows.Forms.Label();
            this.textConPass = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(186, 35);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(393, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(90, 40);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(75, 17);
            this.fullName.TabIndex = 1;
            this.fullName.Text = "Full Name:";
            this.fullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Location = new System.Drawing.Point(71, 90);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(94, 17);
            this.emailAddress.TabIndex = 3;
            this.emailAddress.Text = "Email Adress:";
            // 
            // emailAdd
            // 
            this.emailAdd.Location = new System.Drawing.Point(186, 87);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(393, 22);
            this.emailAdd.TabIndex = 2;
            // 
            // conEmailAddress
            // 
            this.conEmailAddress.AutoSize = true;
            this.conEmailAddress.Location = new System.Drawing.Point(11, 140);
            this.conEmailAddress.Name = "conEmailAddress";
            this.conEmailAddress.Size = new System.Drawing.Size(154, 17);
            this.conEmailAddress.TabIndex = 5;
            this.conEmailAddress.Text = "Confirm Email Address:";
            // 
            // conEmailAdd
            // 
            this.conEmailAdd.Location = new System.Drawing.Point(186, 140);
            this.conEmailAdd.Name = "conEmailAdd";
            this.conEmailAdd.Size = new System.Drawing.Size(393, 22);
            this.conEmailAdd.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(92, 205);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 17);
            this.password.TabIndex = 7;
            this.password.Text = "Password:";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(186, 200);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(393, 22);
            this.textPass.TabIndex = 6;
            // 
            // conPassword
            // 
            this.conPassword.AutoSize = true;
            this.conPassword.Location = new System.Drawing.Point(40, 258);
            this.conPassword.Name = "conPassword";
            this.conPassword.Size = new System.Drawing.Size(125, 17);
            this.conPassword.TabIndex = 9;
            this.conPassword.Text = "Confirm Password:";
            this.conPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // textConPass
            // 
            this.textConPass.Location = new System.Drawing.Point(186, 253);
            this.textConPass.Name = "textConPass";
            this.textConPass.PasswordChar = '*';
            this.textConPass.Size = new System.Drawing.Size(393, 22);
            this.textConPass.TabIndex = 8;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(423, 308);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(156, 42);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 412);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.conPassword);
            this.Controls.Add(this.textConPass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.conEmailAddress);
            this.Controls.Add(this.conEmailAdd);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.txtFullName);
            this.Name = "signUp";
            this.Text = "signUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label emailAddress;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.Label conEmailAddress;
        private System.Windows.Forms.TextBox conEmailAdd;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label conPassword;
        private System.Windows.Forms.TextBox textConPass;
        private System.Windows.Forms.Button signUpButton;
    }
}