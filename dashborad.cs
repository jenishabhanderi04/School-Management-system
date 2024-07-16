using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmanagement
{
    public partial class dashborad : Form
    {
        public dashborad()
        {
            InitializeComponent();
        }

        private void dashborad_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new student().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            new teacher().Show();
            this.Hide();

        }

        private void btnatten_Click(object sender, EventArgs e)
        {
            new attendances().Show();
            this.Hide();

        }

        private void btnevents_Click(object sender, EventArgs e)
        {
            new @event().Show();
            this.Hide();

        }

        private void btnfees_Click(object sender, EventArgs e)
        {
            new fees().Show();
            this.Hide();

        }
    }
}
