using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10026113
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Fill required fields");
                isOk = false;

            }
            else if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Fill the Details");
                isOk = false;
            }

            if (isOk == true)
            {
                SqlConnection one = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\10026113\10026113\Library.mdf;Integrated Security=True;Connect Timeout=30");
                one.Open();

               
                    string input = "UPDATE Book SET ISBN ='"+textBox1.Text+"', Name = '"+textBox2.Text+"', Author = '"+textBox3.Text+"' WHERE ISBN = '"+textBox1.Text+"' ";
                    SqlCommand cmd = new SqlCommand(input, one);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry Updated Successuly");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { Library x = new Library();
            this.Hide();
            x.Show();
        }
    }
}
