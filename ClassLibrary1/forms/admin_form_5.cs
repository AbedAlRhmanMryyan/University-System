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
    public partial class admin_form_5 : Form
    {
        course v;
        public static admin_form_5 a5;
        public FlowLayoutPanel f2;
        public FlowLayoutPanel f3;
        public admin_form_5()
        {
            InitializeComponent();
            a5 = this;
            f2 = this.flowLayoutPanel2;
            f3 = this.flowLayoutPanel3;
        }
        public void set_course_adminform5(course ce) 
        {
            v = ce;
        }
        public course get_course() {return v;}
        public void set_studnet_incourse(student b) 
        {
            v.set_students(b);
        }

        private void admin_form_5_Load(object sender, EventArgs e)
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
            if (v != null) 
            {
                MessageBox.Show(v.get_course_name());
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            course cv= new course();
            flowLayoutPanel2.Controls.Clear();
            if (cv.get_course_fromfile(textBox1.Text) != null) 
            {
            course bv= new course();
                course_user_control_2 b=new course_user_control_2();
                b.set_course_user_control(cv.get_course_fromfile(textBox1.Text));
                flowLayoutPanel2.Controls.Add(b);
                v=cv.get_course_fromfile(textBox1.Text);
                MessageBox.Show("course name : "+v.get_course_name());
            }
            else { MessageBox.Show("Course Not Found"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student_user_control_1 s1 = new student_user_control_1();
            student[] s4 = v.get_students().ToArray();
            MessageBox.Show(v.get_students().Count.ToString());
          /* for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++) 
           {
       
           }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            course v = new course();
            course[] co = v.get_all_course_array_fromfile();

            for (int i = 0; i < v.get_all_course_array_count_fromfile(); i++)
            {

          
                course_user_control_2 c2 = new course_user_control_2();
                c2.set_course_user_control(co[i]);
                flowLayoutPanel2.Controls.Add(c2);
            }
            MessageBox.Show("Courses Reloaded");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(v.get_course_name());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            student p=new student();
            student[] s=p.ReturnAllStudentFromFile();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < p.ReturnAllStudentCountFromFile(); i++) 
            {
              
            student_user_control_3 c = new student_user_control_3();
                c.set_student_userconrol_3(s[i]);
                flowLayoutPanel1.Controls.Add(c);

            }
            MessageBox.Show("Students Reloaded");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool ixz = false;
            bool ixz2 = false;
            bool ixz3 = false;

            if (flowLayoutPanel2.Controls.Count == 0 || flowLayoutPanel2.Controls.Count >= 2 || flowLayoutPanel3.Controls.Count == 0 || flowLayoutPanel3.Controls.Count >= 2)
            { MessageBox.Show("somthing is wrong"); }
            else
            {
                if (v.get_students().Count > v.get_capacity())
                {
                    MessageBox.Show("Too Many Students");
                    ixz = true;
                }
                else
                {
                    MessageBox.Show("course name" + v.get_course_name());
                    student_user_control_3[] st = new student_user_control_3[1];
                    flowLayoutPanel3.Controls.CopyTo(st, 0);
                    student x = st[0].get_studnet_userconrol_3();
                    student[] s4 = v.get_students().ToArray();


                    int op = v.get_students().Count - 1;
                    for (int i = 0; i < v.get_students().Count; i++)
                    {
                        if (s4[i].get_student_name() == x.get_student_name())
                        {

                            flowLayoutPanel3.Controls.Clear();

                            MessageBox.Show("you enterd reapeated student");
                            break;

                        }
                        if (op == i)
                        {
                            flowLayoutPanel3.Controls.Clear();
                            ixz3 = true;

                        }
                    }
                    if (ixz3 == true && ixz == false)
                    {
                     
                        v.set_course_numofstudents(1);
                        v.set_students(x);
                        v.edit_course_v2(v);
                        MessageBox.Show("Course Updated");

                    }




                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_form_1 a1=new admin_form_1();
            a1.TopLevel = false;
            a1.TopMost = false;
            a1.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a1);
            a1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            student st = new student();
            if (File.Exists(st.get_student_filename()))
            {
                student s2 = new student();
                bool b=false;
                student[] s = s2.ReturnAllStudentFromFile();
                for (int i = 0; i < s2.ReturnAllStudentCountFromFile(); i++)
                {
                    if (s[i].get_student_name() == textBox2.Text)
                    {
                        b = false;
                        flowLayoutPanel1.Controls.Clear();
                        student_user_control_3 sb = new student_user_control_3();
                        sb.set_student_userconrol_3(s[i]);
                        flowLayoutPanel1.Controls.Add(sb);
                    }

                    if (flowLayoutPanel1.Controls.Count == 0) {b=true;}
                }
                if (b==true) { MessageBox.Show("Student Not Found"); }
            }
            else
            {
                MessageBox.Show("There Is No Students In Database");
            }
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
            student p = new student();
            student[] s = p.ReturnAllStudentFromFile();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < p.ReturnAllStudentCountFromFile(); i++)
            {

                student_user_control_3 c = new student_user_control_3();
                c.set_student_userconrol_3(s[i]);
                flowLayoutPanel1.Controls.Add(c);

            }
            MessageBox.Show("Students Reloaded");
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            course v = new course();
            course[] co = v.get_all_course_array_fromfile();

            for (int i = 0; i < v.get_all_course_array_count_fromfile(); i++)
            {


                course_user_control_2 c2 = new course_user_control_2();
                c2.set_course_user_control(co[i]);
                flowLayoutPanel2.Controls.Add(c2);
            }
            MessageBox.Show("Courses Reloaded");
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            bool ixz = false;
            bool ixz2 = false;
            bool ixz3 = false;

            if (flowLayoutPanel2.Controls.Count == 0 || flowLayoutPanel2.Controls.Count >= 2 || flowLayoutPanel3.Controls.Count == 0 || flowLayoutPanel3.Controls.Count >= 2)
            { MessageBox.Show("somthing is wrong"); }
            else
            {
                if (v.get_students().Count > v.get_capacity())
                {
                    MessageBox.Show("Too Many Students");
                    ixz = true;
                }
                else
                {
                    MessageBox.Show("course name" + v.get_course_name());
                    student_user_control_3[] st = new student_user_control_3[1];
                    flowLayoutPanel3.Controls.CopyTo(st, 0);
                    student x = st[0].get_studnet_userconrol_3();
                    student[] s4 = v.get_students().ToArray();


                    int op = v.get_students().Count - 1;
                    for (int i = 0; i < v.get_students().Count; i++)
                    {
                        if (s4[i].get_student_name() == x.get_student_name())
                        {

                            flowLayoutPanel3.Controls.Clear();

                            MessageBox.Show("you enterd reapeated student");
                            break;

                        }
                        if (op == i)
                        {
                            flowLayoutPanel3.Controls.Clear();
                            ixz3 = true;

                        }
                    }
                    if (ixz3 == true && ixz == false)
                    {

                        v.set_course_numofstudents(1);
                        v.set_students(x);
                        v.edit_course_v2(v);
                        MessageBox.Show("Course Updated");

                    }




                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
