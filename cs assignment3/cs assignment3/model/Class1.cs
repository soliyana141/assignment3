using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_assignment3.model
{
    class Class1
    {
        public int Number { get; set; }

        public string Date { get; set; }

        public int InvNum { get; set; }

        public string ObjName { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public void save()
        {
            MessageBox.Show("Successful");
        }
    }
}
