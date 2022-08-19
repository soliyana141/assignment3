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
    public partial class DetailPage : Form
    {
        public DetailPage(int num,string d, string obj, int c, int inv, double p)
        {
            InitializeComponent();
            label1.Text = "Num: " + num.ToString();
            label2.Text = "Date: " + d.ToString();
            label3.Text = "Object name: " + obj.ToString();
            label4.Text = "Inventory num: " + inv.ToString();
            label5.Text = "Price: " + p.ToString();
            label6.Text = "Count: " + c.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
