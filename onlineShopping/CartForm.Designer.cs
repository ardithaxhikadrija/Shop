
namespace onlineShopping
{
    partial class CartForm
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
            this.CarttextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarttextBox1
            // 
            this.CarttextBox1.Location = new System.Drawing.Point(25, 27);
            this.CarttextBox1.Multiline = true;
            this.CarttextBox1.Name = "CarttextBox1";
            this.CarttextBox1.ReadOnly = true;
            this.CarttextBox1.Size = new System.Drawing.Size(522, 642);
            this.CarttextBox1.TabIndex = 0;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.CarttextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarttextBox1;
    }
}