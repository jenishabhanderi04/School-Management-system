using System;
using System.Windows.Forms;

namespace schoolmanagement
{
    partial class teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsub = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 46);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(924, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEACHERS";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Blue;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(135, 306);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(167, 47);
            this.btnadd.TabIndex = 81;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(284, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "TEACHERS LIST";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(414, 97);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(210, 126);
            this.txtadd.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(410, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(677, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 76;
            this.label6.Text = "Subject";
            // 
            // cmbsub
            // 
            this.cmbsub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbsub.FormattingEnabled = true;
            this.cmbsub.Items.AddRange(new object[] {
            "maths",
            "gujarati",
            "science",
            "hindi",
            "english",
            "physics",
            "chemistry",
            "biology"});
            this.cmbsub.Location = new System.Drawing.Point(677, 95);
            this.cmbsub.Name = "cmbsub";
            this.cmbsub.Size = new System.Drawing.Size(143, 28);
            this.cmbsub.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 74;
            this.label5.Text = "DOB";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(223, 194);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(121, 29);
            this.dob.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(219, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Gender";
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(219, 95);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(138, 28);
            this.cmbgender.TabIndex = 71;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(24, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 22);
            this.txtname.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Name";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(24, 199);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(169, 22);
            this.txtphone.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "PhoneNo.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(846, 318);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(526, 306);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 47);
            this.btndelete.TabIndex = 88;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Blue;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(331, 306);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(157, 47);
            this.btnedit.TabIndex = 89;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Blue;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(695, 306);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(146, 47);
            this.btnback.TabIndex = 90;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 762);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbsub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button btndelete;
        private Button btnedit;
        private Button btnback;
    }
}