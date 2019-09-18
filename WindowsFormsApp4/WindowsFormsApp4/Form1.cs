using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<Form1> li = new List<Form1>();
        List<customer> customerlist = new List<customer>();
        List<customer> customerlist1 = new List<customer>();
        DataTable dt = new DataTable();

        public static string fname;
        public static string position1;
        public static string email;
        public static int phone;
        public static string search;
        public static int update;



        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            fname = txtname.Text;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            email = txtemail.Text;
        }

        private void txtposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            position1 = txtposition.Text;
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            phone = int.Parse(txtnumber.Text);
        }

        private void insert_Click(object sender, EventArgs e)
        {
           // List<customer> customerlist = new List<customer>();
            customerlist.Add(new customer { Name = txtname.Text, Number = int.Parse(txtnumber.Text), Email = txtemail.Text, position1 = txtposition.Text });
            // dataGridView1.DataSource = customerlist;
            MessageBox.Show("data is inserted");
            foreach (customer q1 in customerlist) {
                //customerlist1.Add(new customer { Name = q1.Name, Number = q1.Number, Email = q1.Email, position1 = q1.position1 });
                customerlist1.Add(q1);
            }
            
           




        }
        public  void getlist()
        {
            List<customer> li = new List<customer>();
            
            foreach(customer q2 in customerlist1)
            {
                li.Add(new customer { Name = q2.Name, Number = q2.Number, Email = q2.Email, position1 = q2.position1 });
                li.Count();

            }
           
        }

        private  void data1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customerlist1.Count; i++)
            {
                customer q = customerlist1[i];
                if (q.Name == search)
                {
                    MessageBox.Show("data FOund");
                }
                else
                {
                    MessageBox.Show("data not found");
                }
            }
            var obj = from i in customerlist1 where i.Name.Contains(search) select i;

            StringBuilder sb = new StringBuilder();
            foreach(customer s in obj)
            {
                sb.Append(s.Name +":"+s.Email+":"+s.Number+":"+s.position1+ Environment.NewLine);
            }
            MessageBox.Show(sb.ToString());
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            search = txtsearch.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = customerlist1;
            dataGridView1.Refresh();

        }

        private void txtupdate_TextChanged(object sender, EventArgs e)
        {
            update = Convert.ToInt16(txtupdate.Text);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var tom in customerlist1.Where(w => w.Name == search))
            {
                tom.Number = update;
            }
            StringBuilder sb2 = new StringBuilder();
            var obj2 = from i in customerlist1 where i.Name.Contains(search) select i;
            foreach (customer s in obj2)
            {
                sb2.Append(s.Name + ":" + s.Email + ":" + s.Number + ":" + s.position1 + Environment.NewLine);
            }
            MessageBox.Show(sb2.ToString());

        }
    }
    
    public class customer
    {
        private string name;
        private string position;
        private string email;
        private int number;

        public string Name
        {
            get { return name; }
            set
            {
                if(name == "")
                {
                    throw new ArgumentException("please enter name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public string position1 {
            get { return position; }
            set
            {
                position = value;
            }

        }

    }
}
