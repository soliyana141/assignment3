using cs_assignment3.model;
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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pro = Class1.findOne(tbsearch.Text);
            if (pro == null)
            {
                MessageBox.Show("Not found");
            }
            else
            {
                MessageBox.Show("Found");
            }
        }
    }
}
