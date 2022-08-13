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
    public partial class new_form : Form
    {
        public new_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel3.Location= new Point (70,40);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            panel3.Location = new Point(100,130 );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Location = new Point(120, 130);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    

   

}
