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
using System.Text.RegularExpressions;

namespace cs_assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db.DataSource = null;
            db.DataSource = Class1.getallclass1();
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            ERP.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(tbnum.Text))
            {
                ERP.SetError(tbnum, "Number required");
            }
            else if (string.IsNullOrEmpty(tbinvnum.Text))
            {
                ERP.SetError(tbinvnum, "invetory Number required");
            }
            else if (string.IsNullOrEmpty(tbobjname.Text))
            {
                ERP.SetError(tbobjname, "Name required");
            }
            else if (string.IsNullOrEmpty(tbcount.Text))
            {
                ERP.SetError(tbcount, "Count required");
            }
            else if (string.IsNullOrEmpty(tbprice.Text))
            {
                ERP.SetError(tbprice, "Price required");
            }
            else if (!r.IsMatch(tbobjname.Text))
            {
                ERP.SetError(tbobjname, "Incorrect syntax");
            }
            else
            {
                ERP.Clear();
                try
                {
                    Class1 c = new Class1
                    {
                        Number = int.Parse(tbnum.Text),
                        Date = dateTimePicker1.Text,
                        InvNum = int.Parse(tbinvnum.Text),
                        ObjName = tbobjname.Text,
                        Count = int.Parse(tbcount.Text),
                        Price = int.Parse(tbprice.Text),
                        isavailable=available.Checked,
                        simple=simple.Checked,
                        variable=variable.Checked
                    };
                    c.save();
                    db.DataSource = null;
                    db.DataSource = Class1.getallclass1();
                }
                catch (Exception)
                {
                    MessageBox.Show("empty");
                };
                string checkItems = " ";
                foreach (var item in checkbox.CheckedItems)
                {
                    checkItems += item.ToString();

                }
                MessageBox.Show(checkItems);
            }
        }
            private void btnCancel_Click(object sender, EventArgs e)
            {
                System.Environment.Exit(0);
            }

        private void checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


        
        
