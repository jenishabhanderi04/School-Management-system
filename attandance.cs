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
    public partial class attendances : Form
    {
        public attendances()
        {
            InitializeComponent();
            displayatt();
            Reset();
            fill();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void displayatt()
        {
            con.Open();
            string Query = "select * from attbl";
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
            cmbst.SelectedIndex = -1;
            cmbid.SelectedIndex = -1;
        }
        int Key = 0;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void fill()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select stid from studenttbl",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stid",typeof(int));
            dt.Load(rdr);
            cmbid.ValueMember = "stid";
            cmbid.DataSource =dt;
            con.Close();

        }
        private void getstudentname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studenttbl where stid=@sid", con);
            cmd.Parameters.AddWithValue("@sid",cmbid.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtname.Text = dr["stname"].ToString();
            }
            con.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
           if (txtname.Text == "" ||  cmbst.SelectedIndex == -1)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into attbl(atid,atname,atdate,atstatus) values(@sid,@sname,@sdob,@sst)", con);
                    cmd.Parameters.AddWithValue("@sid", cmbid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sst", cmbst.SelectedItem.ToString());
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("attendance taken");
                    con.Close();
                    displayatt();
                    Reset();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new dashborad().Show();
            this.Hide();
        }

        private void attendances_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void cmbid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getstudentname();
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
                    SqlCommand cmd = new SqlCommand("delete from attbl where atname ='"+ txtname.Text+"' ", con);
                    //cmd.Parameters.AddWithValue("@stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record deleted");
                    con.Close();
                    displayatt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == ""  || cmbst.SelectedIndex == -1 )
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update attbl set atname= @sname,atdate=@sdob,atstatus=@sst where atid=@sid", con);
                    cmd.Parameters.AddWithValue("@sid", cmbid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sst", cmbst.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student update");
                    con.Close();
                    displayatt();
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
    }
}
