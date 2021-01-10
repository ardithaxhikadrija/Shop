
namespace onlineShopping
{
    partial class profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logInButton1 = new System.Windows.Forms.Button();
            this.signUpButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logInButton1
            // 
            this.logInButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.logInButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton1.ForeColor = System.Drawing.Color.White;
            this.logInButton1.Location = new System.Drawing.Point(25, 14);
            this.logInButton1.Name = "logInButton1";
            this.logInButton1.Size = new System.Drawing.Size(160, 52);
            this.logInButton1.TabIndex = 0;
            this.logInButton1.Text = "Log In";
            this.logInButton1.UseVisualStyleBackColor = true;
            this.logInButton1.Click += new System.EventHandler(this.logInButton1_Click);
            // 
            // signUpButton1
            // 
            this.signUpButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.signUpButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton1.ForeColor = System.Drawing.Color.White;
            this.signUpButton1.Location = new System.Drawing.Point(25, 108);
            this.signUpButton1.Name = "signUpButton1";
            this.signUpButton1.Size = new System.Drawing.Size(160, 52);
            this.signUpButton1.TabIndex = 1;
            this.signUpButton1.Text = "SIgn Up";
            this.signUpButton1.UseVisualStyleBackColor = true;
            this.signUpButton1.Click += new System.EventHandler(this.signUpButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "OR";
            // 
            // profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpButton1);
            this.Controls.Add(this.logInButton1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "profile";
            this.Size = new System.Drawing.Size(211, 196);
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInButton1;
        private System.Windows.Forms.Button signUpButton1;
        private System.Windows.Forms.Label label1;
    }
}
