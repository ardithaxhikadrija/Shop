﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.minButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
=======
            this.menuPanel21 = new onlineShopping.menuPanel2();
            this.profile1 = new onlineShopping.profile();
>>>>>>> ef8f6ed440d5f27aee4ac062ff3d394601601072
            this.SuspendLayout();
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.Location = new System.Drawing.Point(1125, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 1;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.Location = new System.Drawing.Point(1075, 0);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(30, 30);
            this.profileButton.TabIndex = 2;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profile_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(10, 10);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 50);
            this.menuButton.TabIndex = 4;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // offButton
            // 
            this.offButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offButton.BackColor = System.Drawing.Color.Transparent;
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatAppearance.BorderSize = 0;
            this.offButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.offButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offButton.Image = ((System.Drawing.Image)(resources.GetObject("offButton.Image")));
            this.offButton.Location = new System.Drawing.Point(1170, 0);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(30, 30);
            this.offButton.TabIndex = 0;
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuPanel21
            // 
            this.menuPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(112)))));
            this.menuPanel21.Location = new System.Drawing.Point(0, 0);
            this.menuPanel21.Name = "menuPanel21";
            this.menuPanel21.Size = new System.Drawing.Size(200, 700);
            this.menuPanel21.TabIndex = 7;
            this.menuPanel21.Load += new System.EventHandler(this.menuPanel21_Load);
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.Transparent;
            this.profile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile1.Location = new System.Drawing.Point(904, 50);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(211, 196);
            this.profile1.TabIndex = 6;
            this.profile1.Load += new System.EventHandler(this.profile1_Load_2);
            // 
<<<<<<< HEAD
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
=======
>>>>>>> ef8f6ed440d5f27aee4ac062ff3d394601601072
            // homeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 700);
<<<<<<< HEAD
            this.Controls.Add(this.button1);
=======
            this.Controls.Add(this.menuPanel21);
>>>>>>> ef8f6ed440d5f27aee4ac062ff3d394601601072
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.profileButton);
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
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button menuButton;
        private profile profile1;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
=======
        private menuPanel2 menuPanel21;
>>>>>>> ef8f6ed440d5f27aee4ac062ff3d394601601072
        //private menuPanel menuPanel1;
    }
}

