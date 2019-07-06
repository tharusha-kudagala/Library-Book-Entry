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
    public partial class Delete : Form
    {
        public Delete()
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

            if (isOk == true)
            {
                SqlConnection one = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\10026113\10026113\Library.mdf;Integrated Security=True;Connect Timeout=30");
                one.Open();
 
                {
                    string input = "DELETE FROM Book WHERE ISBN = '"+textBox1.Text+"'";
                    SqlCommand cmd = new SqlCommand(input, one);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry Deleted Successuly");
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Library z = new Library();
            this.Hide();
            z.Show();

        }
    }
}
