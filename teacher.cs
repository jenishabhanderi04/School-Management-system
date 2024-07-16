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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
            displayteacher();
            Reset();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void displayteacher()
        {
            con.Open();
            string Query = "select * from teachertbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtphone.Text == "" || txtadd.Text == "" || cmbgender.SelectedIndex == -1 || cmbsub.SelectedIndex == -1)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into teachertbl(tname,tgen,tdob,tsub,tphone,tadd) values(@sname,@sgen,@sdob,@ssub,@sphone,@sadd)", con);
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sgen", cmbgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@ssub", cmbsub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sphone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@sadd", txtadd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student added");
                    con.Close();
                    displayteacher();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
        private void Reset()
        {
            txtname.Text = "";
            txtphone.Text = "";
            txtadd.Text = "";
            cmbgender.SelectedIndex = 0;
            cmbsub.SelectedIndex = 0;
        }
        int Key = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new dashborad().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btndelete_Click_1(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from teachertbl where tname = '" + txtname.Text + "'", con);
                    //cmd.Parameters.AddWithValue("@stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("teacher deleted");
                    con.Close();
                    displayteacher();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {

            if (txtname.Text == "" || txtphone.Text == "" || txtadd.Text == "" || cmbgender.SelectedIndex == -1 || cmbsub.SelectedIndex == -1)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update teachertbl set tgen=@sgen,tdob=@sdob,tsub=@ssub,tphone=@sphone,tadd=@sadd where  tname=@sname", con);
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sgen", cmbgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@ssub", cmbsub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sphone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@sadd", txtadd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student update");
                    con.Close();
                    displayteacher();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            dashborad mn = new dashborad();
            mn.Show();
            this.Hide();

        }
    }
}
