using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_assignment3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = email.Text;
            if (email.Text.Equals("admin") && password.Text.Equals("admin"))
            {
            Form1 screen = new Form1(username); 
            screen.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
