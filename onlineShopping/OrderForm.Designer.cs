
namespace onlineShopping
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.aboutusButton = new System.Windows.Forms.Button();
            this.profilesButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.storesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Controls.Add(this.aboutusButton);
            this.panel9.Controls.Add(this.profilesButton);
            this.panel9.Controls.Add(this.ordersButton);
            this.panel9.Controls.Add(this.cartButton);
            this.panel9.Controls.Add(this.storesButton);
            this.panel9.Controls.Add(this.homeButton);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(177, 700);
            this.panel9.TabIndex = 24;
            // 
            // aboutusButton
            // 
            this.aboutusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.aboutusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutusButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutusButton.ForeColor = System.Drawing.Color.White;
            this.aboutusButton.Location = new System.Drawing.Point(0, 380);
            this.aboutusButton.Name = "aboutusButton";
            this.aboutusButton.Size = new System.Drawing.Size(175, 75);
            this.aboutusButton.TabIndex = 17;
            this.aboutusButton.Text = "About Us";
            this.aboutusButton.UseVisualStyleBackColor = true;
            // 
            // profilesButton
            // 
            this.profilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.profilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilesButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilesButton.ForeColor = System.Drawing.Color.White;
            this.profilesButton.Image = ((System.Drawing.Image)(resources.GetObject("profilesButton.Image")));
            this.profilesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilesButton.Location = new System.Drawing.Point(0, 304);
            this.profilesButton.Name = "profilesButton";
            this.profilesButton.Size = new System.Drawing.Size(175, 75);
            this.profilesButton.TabIndex = 16;
            this.profilesButton.Text = "Profile";
            this.profilesButton.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.Color.White;
            this.ordersButton.Image = ((System.Drawing.Image)(resources.GetObject("ordersButton.Image")));
            this.ordersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersButton.Location = new System.Drawing.Point(0, 228);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(175, 75);
            this.ordersButton.TabIndex = 15;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            // 
            // cartButton
            // 
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Image = ((System.Drawing.Image)(resources.GetObject("cartButton.Image")));
            this.cartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartButton.Location = new System.Drawing.Point(0, 152);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(175, 75);
            this.cartButton.TabIndex = 14;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // storesButton
            // 
            this.storesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.storesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storesButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storesButton.ForeColor = System.Drawing.Color.White;
            this.storesButton.Image = ((System.Drawing.Image)(resources.GetObject("storesButton.Image")));
            this.storesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storesButton.Location = new System.Drawing.Point(0, 76);
            this.storesButton.Name = "storesButton";
            this.storesButton.Size = new System.Drawing.Size(175, 75);
            this.storesButton.TabIndex = 13;
            this.storesButton.Text = "Stores";
            this.storesButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(175, 75);
            this.homeButton.TabIndex = 12;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button aboutusButton;
        private System.Windows.Forms.Button profilesButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button storesButton;
        private System.Windows.Forms.Button homeButton;
    }
}