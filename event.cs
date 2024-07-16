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
    public partial class @event : Form
    {
        public @event()
        {
            InitializeComponent();
            displayeven();
            Reset();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void displayeven()
        {
            con.Open();
            string Query = "select * from etbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            txtname.Text = "";
            txtd.Text = "";
        }
        int Key = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new dashborad().Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into etbl(edesc,edate,eduration) values(@sname,@sdob,@sd)", con);
                  
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sd", txtd.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("added event");
                    con.Close();
                    displayeven();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtd.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into etbl(edesc,edate,eduration) values(@sname,@sdob,@sd)", con);
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sd", txtd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("event edites");
                    con.Close();
                    displayeven();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Key != 0)
            {
                MessageBox.Show("select teacher");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from etbl where edesc ='" + txtname.Text + "' ", con);
                    //cmd.Parameters.AddWithValue("@stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");
                    con.Close();
                    displayeven();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dashborad mn = new dashborad();
            mn.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\n\n\n\n" + error.StackTrace);
            }


            if (txtname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
