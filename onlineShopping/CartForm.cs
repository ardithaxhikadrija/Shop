﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace onlineShopping
{
    public partial class CartForm : Form
    {
        public String date, time;
        double totali = 0;
        double a, b, c, d, f, g, h, j;



        private void ordersButton_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            OrderForm order = new OrderForm(this);
            order.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailText.Text))
            {
                MessageBox.Show("Please enter your email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random r = new Random();
                string orderID = r.Next().ToString();
                string to, from, pass, mail;
                label4.Text = DateTime.Now.ToLongTimeString();
                label3.Text = DateTime.Now.ToLongDateString();
                MessageBox.Show("Your order has been placed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                to = (emailText.Text).ToString();
                from = "droneshipping77@gmail.com";
                pass = "ismetpeja";
                mail = "Thank you for your purchase.\n Your order ID is: " + orderID + "\n Your total is " + totaliBox.Text.ToString();
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                string foto = location.Text;
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(foto);
                message.Attachments.Add(attachment);
                message.Body = mail;
                message.Subject = "DroneShipping order!";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                OrderForm order = new OrderForm(this);
                order.Show();
                this.Hide();
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            StoreForm store = new StoreForm();
            store.Hide();
            this.Close();
        }

        StoreForm sf;
        public CartForm(StoreForm store)
        {
            InitializeComponent();
            this.sf = store;
        }

        public CartForm()
        {
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            if (sf.checkBox1.Checked == true)
            {
                listBoxCart.Items.Add(sf.aspirinLabel.Text);
                a = double.Parse(sf.label3.Text);
                totali += a;
            }
            if (sf.checkBox2.Checked == true)
            {
                listBoxCart.Items.Add(sf.vitaminaCLabel.Text);
                b = double.Parse(sf.label1.Text);
                totali += b;
            }
            if (sf.checkBox3.Checked == true)
            {
                listBoxCart.Items.Add(sf.vitaminaDLabel.Text);
                c = double.Parse(sf.label5.Text);
                totali += c;
            }
            if (sf.checkBox4.Checked == true)
            {
                listBoxCart.Items.Add(sf.kalciumLabel.Text);
                d = double.Parse(sf.label7.Text);
                totali += d;
            }
            if (sf.checkBox5.Checked == true)
            {
                listBoxCart.Items.Add(sf.maskaLabel.Text);
                f = double.Parse(sf.maska.Text);
                totali += f;
            }
            if (sf.checkBox6.Checked == true)
            {
                listBoxCart.Items.Add(sf.desinfektuesLabel.Text);
                g = double.Parse(sf.label11.Text);
                totali += g;
            }
            if (sf.checkBox7.Checked == true)
            {
                listBoxCart.Items.Add(sf.antacidLabel.Text);
                h = double.Parse(sf.label13.Text);
                totali += h;
            }
            if (sf.checkBox8.Checked == true)
            {
                listBoxCart.Items.Add(sf.magneziumLabel.Text);
                j = double.Parse(sf.label15.Text);
                totali += j;
            }

            totaliBox.Text = "$"+totali.ToString(); 
        }
        
        

        private void listBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex > -1)
            {
                listBoxCart.Items.RemoveAt((sender as ListBox).SelectedIndex);
            }
        }
    }
}
