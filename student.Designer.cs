using System;
using System.Drawing;
using System.Windows.Forms;

namespace schoolmanagement
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 46);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(897, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
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
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(14, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 22);
            this.txtname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // txtfees
            // 
            this.txtfees.Location = new System.Drawing.Point(742, 91);
            this.txtfees.Name = "txtfees";
            this.txtfees.Size = new System.Drawing.Size(145, 22);
            this.txtfees.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(742, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fees";
            // 
            // cmbgender
            // 
            this.cmbgender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(209, 93);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(138, 28);
            this.cmbgender.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(209, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(377, 91);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(121, 29);
            this.dob.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(373, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(534, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "class";
            // 
            // cmbclass
            // 
            this.cmbclass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "1-A",
            "1-B",
            "2-A",
            "2-B",
            "3-A",
            "3-B",
            "4-A",
            "4-B",
            "5-A",
            "5-B",
            "6-A",
            "6-B",
            "7-A",
            "7-B",
            "8-A",
            "8-B",
            "9-A",
            "9-B",
            "10-A",
            "10-B",
            "11-A",
            "11-B",
            "12-A",
            "12-B"});
            this.cmbclass.Location = new System.Drawing.Point(534, 93);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(143, 28);
            this.cmbclass.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "address";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(14, 199);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(196, 80);
            this.txtadd.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(274, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "STUDENT    LIST";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(846, 318);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Blue;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(671, 304);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(146, 47);
            this.btnback.TabIndex = 66;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(496, 304);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 47);
            this.btndelete.TabIndex = 65;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Blue;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(314, 304);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(157, 47);
            this.btnedit.TabIndex = 64;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Blue;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(125, 304);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(167, 47);
            this.btnadd.TabIndex = 63;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 741);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbclass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtfees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "student";
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       private void student_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }*/

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtname;
        private Label label3;
        private TextBox txtfees;
        private Label label2;
        private ComboBox cmbgender;
        private Label label4;
        private DateTimePicker dob;
        private Label label5;
        private Label label6;
        private ComboBox cmbclass;
        private Label label7;
        private TextBox txtadd;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnback;
        private Button btndelete;
        private Button btnedit;
        private Button btnadd;
        private PictureBox pictureBox2;
        private SizeF autoScaleDimensions;

        public SizeF GetAutoScaleDimensions()
        {
            return autoScaleDimensions;
        }

        //private void SetAutoScaleDimensions(SizeF value)
        //{
        //    autoScaleDimensions = value;
        //}
    }
}