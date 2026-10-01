using ClassLibrary1.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class student_form_1 : Form
    {
         public static student_form_1 s_form;
         student form_student;

        public student_form_1()
        {
            InitializeComponent();
            s_form = this;
        }
        public void set_student_form(student s) { form_student = s; }
        public student get_student_form() { return form_student; }
        private void student_form_1_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock=DockStyle.Top;
            Form1.here1.panel13.Parent = pictureBox1;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            student_form_3 b= new student_form_3();
            b.TopLevel=false;
            b.TopMost=false;
            b.Dock=DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(b);
            student_form_3.s3_form.set_student_form(form_student);
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.TopMost = false;
            Form1.here1.panel222.Controls.Add(f2);
            f2.Dock = DockStyle.Fill;
            f2.Show();
    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            student_form_2 f=new student_form_2();
            f.TopLevel= false;
            f.TopMost = false;
            Form1.here1.panel222.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
          
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            student_form_6 f=new student_form_6();
            f.TopLevel= false;
            f.TopMost= false;
            f.Dock= DockStyle.Fill;
            f.set_student_f6(form_student);
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(f);
            f.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            student_form_5 s5=new student_form_5();
            s5.TopLevel = false;
            s5.TopMost = false;
            s5.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(s5);
            s5.set_student_sf5(form_student);
            s5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
