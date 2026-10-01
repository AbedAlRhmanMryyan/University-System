using ClassLibrary1.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.forms
{
    public partial class student_form_5 : Form
    {
        public static student_form_5 sf5;
        public FlowLayoutPanel f;
        student st;
        course ct;
        public void set_student_sf5(student stu) {st= stu;}
        public student get_student_sf4(){return st;}
        public void set_course_sf5(course b) { ct=b;}
        public course get_course_sf5(){return ct;}
        public student_form_5()
        {
            InitializeComponent();
            sf5 = this;
            f = this.flowLayoutPanel2;
        }

        private void student_form_5_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock = DockStyle.Top;
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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            student_form_1 s1 = new student_form_1();
            s1.TopLevel = false;
            s1.TopMost= false;
            s1.Dock = DockStyle.Fill;
            s1.set_student_form(st);
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(s1);
            s1.Show();

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            course[] cv;
            course cv1=new course();
            student vc=new student();
            cv = cv1.get_student_from_course_fromfile(st.get_student_name());
            for(int i = 0; i < cv.Length; i++) 
            {
            course_user_control_4 c3=new course_user_control_4();
                c3.set_course_uc4(cv[i]);
                flowLayoutPanel2.Controls.Add(c3);
            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (ct != null)
            {
                flowLayoutPanel1.Controls.Clear();
                messages m = new messages();
                messages[] v = m.get_message_fromfile(ct.get_course_name());


                if (v != null)
                {
                    for (int i = 0; i < m.get_message_fromfile_count(ct.get_course_name()); i++)
                    {
                        message_user_control_1 c = new message_user_control_1();
                        c.set_message_user_control_1(v[i]);

                        flowLayoutPanel1.Controls.Add(c);
                    }

                }
                else { MessageBox.Show("There is no message"); }
            }if(ct==null)MessageBox.Show("you dont select any course");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
