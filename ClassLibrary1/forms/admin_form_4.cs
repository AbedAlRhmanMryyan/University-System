using ClassLibrary1.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.forms
{
    public partial class admin_form_4 : Form
    {
        public admin_form_4()
        {
            InitializeComponent();
        }

        private void admin_form_4_Load(object sender, EventArgs e)
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
        {/*
           student sv = new student();
            student []sv2 = new student[sv.ReturnAllStudentCountFromFile()];
            sv2=sv.ReturnAllStudentFromFile();
          
            for (int i = 0; i < sv.ReturnAllStudentCountFromFile(); i++)
            {
                student_user_control_2 s = new student_user_control_2();
                s.set_student_usercontrol_2(sv2[i]);
          
                panel2.Controls.Add(s);


            }*/
            flowLayoutPanel1.Controls.Clear();
            student s = new student();
            student_user_control_2[] u2 = new student_user_control_2[s.ReturnAllStudentCountFromFile()];

            int i1 = 0;
            if (File.Exists(s.get_student_filename()))
            {

                student[] s2 = new student[s.ReturnAllStudentCountFromFile()];
                s2 = s.ReturnAllStudentFromFile();
                if (s2[0] == null) { MessageBox.Show("no Student"); }
                else
                {

                    for (int i = 0; i < s.ReturnAllStudentCountFromFile(); i++)
                    {



                        student_user_control_2 u1 = new student_user_control_2();
                        u1.set_student_usercontrol_2(s2[i]);
                        this.flowLayoutPanel1.Controls.Add(u1);
                    }
                    MessageBox.Show("Student Reloded");
                    //     label4.Text = count_student.ToString();
                    // this.panel1.BackColor = Color.LightYellow;
                    Form1.here1.panel13.BackColor = Color.White;

                }
            }
            else { MessageBox.Show("There Is No Students In Data Base"); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Refresh();
            teacher t1 = new teacher();
            if (File.Exists(t1.get_teacher_file()))
            {

                teacher[] t2 = new teacher[t1.Return_all_teacher_array_count()];
                t2 = t1.Return_all_teacher_array();

                for (int i = 0; i < t1.Return_all_teacher_array_count(); i++)
                {
                    teacher_user_control_1 tu = new teacher_user_control_1();
                    tu.set_teacher_usercontrol(t2[i]);
                    flowLayoutPanel1.Controls.Add(tu);
                }
                MessageBox.Show("teachers loaded");
                Form1.here1.panel13.BackColor = Color.White;
                // this.panel1 .BackColor = Color.MediumPurple;
            }
            else { MessageBox.Show("No Teacher in database"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            course co = new course();
            if (File.Exists(co.get_course_file_name()))
            {

                course[] co1 = co.get_all_course_array_fromfile();

                for (int i = 0; i < co.get_all_course_array_count_fromfile(); i++)
                {
                    course_user_control_1 c1 = new course_user_control_1();
                    c1.set_course_user_control(co1[i]);
                    flowLayoutPanel1.Controls.Add(c1);
                }
                MessageBox.Show("Courses Reloded");
                Form1.here1.panel13.BackColor = Color.Beige;
                // this.panel1.BackColor = Color.MediumSlateBlue;

            }
            else MessageBox.Show("there is no course on database");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_1 a4 = new admin_form_1();
            a4.TopLevel = false;
            a4.TopMost = false;
            a4.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(a4);
            a4.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            /*
           student sv = new student();
            student []sv2 = new student[sv.ReturnAllStudentCountFromFile()];
            sv2=sv.ReturnAllStudentFromFile();
          
            for (int i = 0; i < sv.ReturnAllStudentCountFromFile(); i++)
            {
                student_user_control_2 s = new student_user_control_2();
                s.set_student_usercontrol_2(sv2[i]);
          
                panel2.Controls.Add(s);


            }*/
            flowLayoutPanel1.Controls.Clear();
            student s = new student();
            student_user_control_2[] u2 = new student_user_control_2[s.ReturnAllStudentCountFromFile()];

            int i1 = 0;
            if (File.Exists(s.get_student_filename()))
            {

                student[] s2 = new student[s.ReturnAllStudentCountFromFile()];
                s2 = s.ReturnAllStudentFromFile();
                if (s2[0] == null) { MessageBox.Show("no Student"); }
                else
                {

                    for (int i = 0; i < s.ReturnAllStudentCountFromFile(); i++)
                    {



                        student_user_control_2 u1 = new student_user_control_2();
                        u1.set_student_usercontrol_2(s2[i]);
                        this.flowLayoutPanel1.Controls.Add(u1);
                    }
                    MessageBox.Show("Student Reloded");
                    //     label4.Text = count_student.ToString();
                    // this.panel1.BackColor = Color.LightYellow;
              

                }
            }
            else
            {
                MessageBox.Show("There Is No Students In Data Base");
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Refresh();
            teacher t1 = new teacher();
            if (File.Exists(t1.get_teacher_file()))
            {

                teacher[] t2 = new teacher[t1.Return_all_teacher_array_count()];
                t2 = t1.Return_all_teacher_array();

                for (int i = 0; i < t1.Return_all_teacher_array_count(); i++)
                {
                    teacher_user_control_1 tu = new teacher_user_control_1();
                    tu.set_teacher_usercontrol(t2[i]);
                    flowLayoutPanel1.Controls.Add(tu);
                }
                MessageBox.Show("teachers loaded");
           
                // this.panel1 .BackColor = Color.MediumPurple;
            }
            else { MessageBox.Show("No Teacher in database"); }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            course co = new course();
            if (File.Exists(co.get_course_file_name()))
            {

                course[] co1 = co.get_all_course_array_fromfile();

                for (int i = 0; i < co.get_all_course_array_count_fromfile(); i++)
                {
                    course_user_control_1 c1 = new course_user_control_1();
                    c1.set_course_user_control(co1[i]);
                    
                    flowLayoutPanel1.Controls.Add(c1);
                }
                MessageBox.Show("Courses Reloded");
             
                // this.panel1.BackColor = Color.MediumSlateBlue;

            }
            else MessageBox.Show("there is no course on database");
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_1 a4 = new admin_form_1();
            a4.TopLevel = false;
            a4.TopMost = false;
            a4.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(a4);
            a4.Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_1 a4 = new admin_form_1();
            a4.TopLevel = false;
            a4.TopMost = false;
            a4.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(a4);
            a4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
