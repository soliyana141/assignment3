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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach(var item in Class1.getallclass1())
            {
                product_card p = new product_card();
                p.MyNum = item.Number;
                p.MyDate = item.Date;
                p.MyInvNum = item.InvNum;
                p.MyObjName = item.ObjName;
                p.MyCount = item.Count;
                p.MyPrice = item.Price;
                flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
