
namespace onlineShopping
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.offButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.profile1 = new onlineShopping.profile();
            this.SuspendLayout();
            // 
            // offButton
            // 
            this.offButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offButton.BackColor = System.Drawing.Color.Transparent;
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatAppearance.BorderSize = 0;
            this.offButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.offButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offButton.Image = ((System.Drawing.Image)(resources.GetObject("offButton.Image")));
            this.offButton.Location = new System.Drawing.Point(1160, 0);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(40, 38);
            this.offButton.TabIndex = 0;
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.Location = new System.Drawing.Point(1114, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(40, 38);
            this.minButton.TabIndex = 1;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.BackColor = System.Drawing.Color.Transparent;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Location = new System.Drawing.Point(1036, 0);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(40, 38);
            this.profile.TabIndex = 2;
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Location = new System.Drawing.Point(897, 44);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(211, 196);
            this.profile1.TabIndex = 3;
            // 
            // homeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.offButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button profile;
        private profile profile1;
    }
}

