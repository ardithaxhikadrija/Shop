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
    public partial class CartForm : Form
    {
        StoreForm sf;
        public CartForm(StoreForm store)
        {
            InitializeComponent();
            this.sf = store;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            if (sf.checkBox1.Checked == true){
                CarttextBox1.Text = sf.aspirinLabel.Text;

            }
            
        }
    }
}
