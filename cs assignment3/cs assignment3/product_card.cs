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
    public partial class product_card : UserControl
    {
        private int _MyNum;

        public int MyNum
        {
            get { return _MyNum; }
            set { _MyNum = value; lblNum.Text = value.ToString(); }
        }
        private string _MyDate;

        public string MyDate
        {
            get { return _MyDate; }
            set { _MyDate = value; LblDate.Text = value; }
        }
        private int _MyInvNum;

        public int MyInvNum
        {
            get { return _MyInvNum; }
            set { _MyInvNum = value; LblInv.Text = value.ToString(); }
        }
        private string _MyObjName;

        public string MyObjName
        {
            get { return _MyObjName; }
            set { _MyObjName = value; LblObj.Text = value; }
        }

        private int _MyCount;

        public int MyCount
        {
            get { return _MyCount; }
            set { _MyCount = value; LblCount.Text = value.ToString(); }
        }
        private double _MyPrice;

        public double MyPrice
        {
            get { return _MyPrice; }
            set { _MyPrice = value; LblPrice.Text = value.ToString(); }
        }
        public product_card()
        {
            InitializeComponent();
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void product_card_Load(object sender, EventArgs e)
        {

        }
    }
}

