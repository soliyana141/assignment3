using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cs_assignment3.model
{
    class Class1
    {
        static private List<Class1> p = new List<Class1>();
       //static private  List<Class1> list = new List<Class1>();
        public int Number { get; set; }

        public string Date { get; set; }

        public int InvNum { get; set; }

        public string ObjName { get; set; }

        public int Count { get; set; }

        public int Price { get; set; }
        public bool isavailable { get; set; }

        public bool simple { get; set; }
        public bool variable { get; set; }


        public void save()
        {
            p.Add(this);
            try {
                string path = @"Server = DESKTOP-8JPT9LB\MSSQLSERVER01; Database = csharp; Integrated security = true; ";
                SqlConnection conn = new SqlConnection(path);
                conn.Open();
                string query = "Insert into csharptable values( @no,@da,@invn,@on,@co,@pr)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@no", this.Number);
                cmd.Parameters.AddWithValue("@da", this.Date);
                cmd.Parameters.AddWithValue("@invn", this.InvNum);
                cmd.Parameters.AddWithValue("@on", this.ObjName);
                cmd.Parameters.AddWithValue("@co", this.Count);
                cmd.Parameters.AddWithValue ("@pr", this.Price);
                
                var result = cmd.ExecuteNonQuery();
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }


        public static List<Class1> getallclass1()
        {
            List<Class1> list = new List<Class1>();
            try
            {
                string path = @"Server = DESKTOP-8JPT9LB\MSSQLSERVER01; Database = csharp; Integrated security = true; ";
                SqlConnection conn = new SqlConnection(path);
                conn.Open();
                string query = "select * from csharptable;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Class1 c = new Class1();
                    c.Number = (int)reader["num"];
                    c.Date = (string)reader["MyDate"];
                    c.InvNum = (int)reader["invnum"];
                    c.ObjName = (string)reader["objname"];
                    c.Count = (int)reader["count"];
                    c.Price = (int)reader["price"];
                    list.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            return list;
        }
        public static Class1 findOne(string name)
        {
            List<Class1> list = new List<Class1>();
            try
            {
                string path = @"Server = DESKTOP-8JPT9LB\MSSQLSERVER01; Database = csharp; Integrated security = true; ";
                SqlConnection conn = new SqlConnection(path);
                conn.Open();
                string query = "select * from csharptable;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Class1 c = new Class1();
                    c.Number = (int)reader["num"];
                    c.Date = (string)reader["MyDate"];
                    c.InvNum = (int)reader["invnum"];
                    c.ObjName = (string)reader["objname"];
                    c.Count = (int)reader["count"];
                    c.Price = (int)reader["price"];
                    list.Add(c);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            return list.Find(p => p.ObjName == name);
        }
    }
}
//+this.Number + "','" + this.Date + "','" + this.InvNum + "','" + this.ObjName + "','" + this.Count + "','" + this.Price + "');";




