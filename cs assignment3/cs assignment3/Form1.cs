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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  private void btnadd_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1
            {
                Number = int.Parse(tbnum.Text),
                Date = dateTimePicker1.Text,
                InvNum = int.Parse(tbinvnum.Text),
                ObjName = tbobjname.Text,
                Count = int.Parse(tbcount.Text),
                Price = double.Parse(tbprice.Text)
            };
            c.save();
        }
    }
}
