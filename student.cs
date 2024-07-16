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
    public partial class student: Form
    {
        public student()
        {
            InitializeComponent();
            displaystudent();
            Reset();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0GE4MF2C\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void displaystudent()
        {
            con.Open();
            string Query = "select * from studenttbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();    
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtfees.Text == "" || txtadd.Text == "" || cmbgender.SelectedIndex == -1 || cmbclass.SelectedIndex == -1)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into studenttbl(stname,stgen,stdob,stclass,stfee,stadd) values(@sname,@sgen,@sdob,@sclass,@sfee,@sadd)", con);
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sgen", cmbgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sclass", cmbclass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sfee", txtfees.Text);
                    cmd.Parameters.AddWithValue("@sadd", txtadd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student added");
                    con.Close();
                    displaystudent();
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
        private void Reset()
        {
            txtname.Text = "";
            txtfees.Text = "";
            txtadd.Text = "";
            cmbgender.SelectedIndex = 0;
            cmbclass.SelectedIndex = 0;
        }
        int Key = 0;

      /*  private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1_CellContentClick(sender, e, txtname);
        }*/

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //cmbgender.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //dob.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //cmbclass.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //txtfees.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //txtadd.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            try
            {
                MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

                //dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //txtname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //cmbgender.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //dob.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //cmbclass.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtfees.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtadd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

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
             if(Key != 0)
              {
                  MessageBox.Show("select student");
              }
              else
              {
                  try
                  {
                      con.Open();
                      SqlCommand cmd = new SqlCommand("delete from studenttbl where stname = '"+txtname.Text+"'",con);
                      //cmd.Parameters.AddWithValue("@stkey", Key);
                      cmd.ExecuteNonQuery();
                      MessageBox.Show("student deleted");
                      con.Close();
                      displaystudent();
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
                 }

          /*  con.Open();
            string Query = "delete  from studenttbl where name =" +txtname.Text + " ";
            cmd = new SqlCommand(Query , con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("student deleted");
            displaystudent();
          */
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtfees.Text == "" || txtadd.Text == "" || cmbgender.SelectedIndex == -1 || cmbclass.SelectedIndex == -1)
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update studenttbl set stname=@sname,stgen=@sgen,stdob=@sdob,stclass=@sclass,stfee=@sfee,stadd=@sadd", con);
                    cmd.Parameters.AddWithValue("@sname", txtname.Text);
                    cmd.Parameters.AddWithValue("@sgen", cmbgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sdob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@sclass", cmbclass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sfee", txtfees.Text);
                    cmd.Parameters.AddWithValue("@sadd", txtadd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student update");
                    con.Close();
                    displaystudent();
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

