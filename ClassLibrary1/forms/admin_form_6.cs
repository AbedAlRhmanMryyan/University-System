using ClassLibrary1.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.forms
{
    public partial class admin_form_6 : Form
    {
        public admin_form_6()
        {
            InitializeComponent();
        }

        private void admin_form_6_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Parent = pictureBox1;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.Dock = DockStyle.Top;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student st = new student();
            if (File.Exists(st.get_student_filename()))
            {
                student s2 = new student();
                student[] s = s2.ReturnAllStudentFromFile();
                for (int i = 0; i < s2.ReturnAllStudentCountFromFile(); i++)
                {
                    if (s[i].get_student_name() == textBox1.Text)
                    {
                        flowLayoutPanel1.Controls.Clear();
                        student_user_control_2 sb = new student_user_control_2();
                        sb.set_student_usercontrol_2(s[i]);
                        flowLayoutPanel1.Controls.Add(sb);
                    }

                }
            }
            else 
            {
                MessageBox.Show("There Is No Students In Database");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student student = new student();
            if (File.Exists(student.get_student_filename()))
            {
                flowLayoutPanel1.Controls.Clear();
                student s2 = new student();
                student[] s = s2.ReturnAllStudentFromFile();
                for (int i = 0; i < s2.ReturnAllStudentCountFromFile(); i++)
                {
                    student_user_control_2 sb = new student_user_control_2();
                    sb.set_student_usercontrol_2(s[i]);
                    flowLayoutPanel1.Controls.Add(sb);
                }
            }
            else 
            {
                MessageBox.Show("There Is No Students In Database");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_form_1 a1=new admin_form_1();
            a1.TopLevel = false;
            a1.TopMost = false;
            a1.Dock=DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a1);
            a1.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            admin_form_1 a1 = new admin_form_1();
            a1.TopLevel = false;
            a1.TopMost = false;
            a1.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a1);
            a1.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            student student = new student();
            if (File.Exists(student.get_student_filename()))
            {
                flowLayoutPanel1.Controls.Clear();
                student s2 = new student();
                student[] s = s2.ReturnAllStudentFromFile();
                for (int i = 0; i < s2.ReturnAllStudentCountFromFile(); i++)
                {
                    student_user_control_2 sb = new student_user_control_2();
                    sb.set_student_usercontrol_2(s[i]);
                    flowLayoutPanel1.Controls.Add(sb);
                }
            }
            else
            {
                MessageBox.Show("There Is No Students In Database");
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            student st = new student();
            if (File.Exists(st.get_student_filename()))
            {
                student s2 = new student();
                student[] s = s2.ReturnAllStudentFromFile();
                for (int i = 0; i < s2.ReturnAllStudentCountFromFile(); i++)
                {
                    if (s[i].get_student_name() == textBox1.Text)
                    {
                        flowLayoutPanel1.Controls.Clear();
                        student_user_control_2 sb = new student_user_control_2();
                        sb.set_student_usercontrol_2(s[i]);
                        flowLayoutPanel1.Controls.Add(sb);
                    }

                }
            }
            else
            {
                MessageBox.Show("There Is No Students In Database");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
