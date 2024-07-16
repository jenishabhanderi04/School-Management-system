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

namespace schoolmanagement
{
    public partial class login: Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectCommand = "select  count(UserName) as Total from tblUser where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                SqlCommand comm = new SqlCommand(selectCommand, con);
                con.Open();
                int rows = (int)comm.ExecuteScalar();

                con.Close();
                if (rows == 1)
                {
                    new dashborad().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid password or username");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("error");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
