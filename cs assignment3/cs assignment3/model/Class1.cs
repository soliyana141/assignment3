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
        static private List<Class1> p = new List<Class1>();
        public int Number { get; set; }

        public string Date { get; set; }

        public int InvNum { get; set; }

        public string ObjName { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }
        public bool isavailable { get; set; }

        public bool simple { get; set; }
        public bool variable  { get; set; }


        public void save()
        {
            p.Add(this);
        }
        public static List<Class1> getallclass1()
        {
            return p;
        }
        public static Class1 findOne(string name)
        {
            return p.Find(p => p.ObjName == name);
        }
    }
}

            
        
    

