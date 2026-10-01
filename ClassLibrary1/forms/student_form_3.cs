using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class student_form_3 : Form
    {

        public static student_form_3 s3_form;
        student form_student;
        public student_form_3()
        {
            InitializeComponent();
            s3_form = this;
            form_student=student_form_1.s_form.get_student_form();
            label3.Text = form_student.get_student_name();
            label4.Text = form_student.get_student_username();
            label5.Text = form_student.get_student_GPA().ToString();
            label7.Text = form_student.get_student_active().ToString();
            label12.Text = form_student.get_student_date_of_birth();
            label9.Text = form_student.get_student_total_ch().ToString();
            try
            {
                if (form_student.get_student_picture() != null)
                {
                    pictureBox1.Image = Image.FromFile(form_student.get_student_picture());
                }
            }
            catch { }

        }
        public void set_student_form(student s) { form_student = s; }
        public student get_student_form() { return form_student; }
        private void student_form_3_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock = DockStyle.Top;
            Form1.here1.panel13.Parent = pictureBox2;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
            tableLayoutPanel1.Parent = pictureBox2;
            tableLayoutPanel1.Parent.BackColor = Color.Transparent;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1.here1.panel222.Controls.Clear();
            student_form_1 s1 = new student_form_1();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock = DockStyle.Fill;
            student_form_1.s_form.set_student_form(form_student);
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            Form2 s1 = new Form2();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock = DockStyle.Fill;

            s1.Show();
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.Dock = DockStyle.None;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            student_form_1 s1 = new student_form_1();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock = DockStyle.Fill;
            student_form_1.s_form.set_student_form(form_student);
            s1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
