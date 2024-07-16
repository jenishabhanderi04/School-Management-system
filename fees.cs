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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
            displayfee();
            Reset();
            fill();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void displayfee()
        {
            con.Open();
            string Query = "select * from feetbl";
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
            cmbid.SelectedIndex = -1;
            txta.Text = "";
        }
        private void fill()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select stid from studenttbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stid", typeof(int));
            dt.Load(rdr);
            cmbid.ValueMember = "stid";
            cmbid.DataSource = dt;
            con.Close();

        }
        private void getstudentname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studenttbl where stid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", cmbid.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtname.Text = dr["stname"].ToString();
            }
            con.Close();
        }
        int Key = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new dashborad().Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || cmbid.SelectedIndex == -1 || txta.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into feetbl(stid,stname,month,amt) values(@sid,@sname,@sdob,@sst)", con);
                    cmd.Parameters.AddWithValue("@sid", cmbid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sst",txta.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("fees inserted");
                    con.Close();
                    displayfee();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
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
                    SqlCommand cmd = new SqlCommand("delete from feetbl where stname ='" + txtname.Text + "' ", con);
                    //cmd.Parameters.AddWithValue("@stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");
                    con.Close();
                    displayfee();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || cmbid.SelectedIndex == -1 || txtname.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update feetbl set month=@sdob,amt=@sst where stname= @sname", con);
                    cmd.Parameters.AddWithValue("@sid", cmbid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sst", txta.Text);

                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student update");
                    con.Close();
                    displayfee();
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

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
          /* try
            {
                string selectCommand = "select stname from feetbl where stid = " + cmbid.Text + "";
                SqlCommand comm = new SqlCommand(selectCommand,con);
                con.Close();
                con.Open();
                SqlDataReader output = comm.ExecuteReader();
                if (output.HasRows)
                {
                    output.Read();
                    txtname.Text = output.GetString(0);
                }
                else {
                    MessageBox.Show("No Records Found");
                }
                con.Close();
            }
            catch (Exception error)
            {
                con.Close();
                MessageBox.Show(error.Message +"\n\n\n\n" + error.StackTrace);
            }*/
        }

        private void cmbid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getstudentname();
        }
    }
}
