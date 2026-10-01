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
    public partial class teacher_form_3 : Form
    {
        public static teacher_form_3 t3;
        public FlowLayoutPanel f;
        public FlowLayoutPanel f3;
        public FlowLayoutPanel f2;
        teacher v;
        student st;
        course course1;
        public void set_course_tf3(course cg) { course1 = cg; }
        public void set_student_tf3(student stu) { st= stu; }
        public student get_stu() { return st; }
        public void set_teacher_tf3(teacher v3) { v = v3; }
        public teacher get_teacher_tf3() { return v; }
        public teacher_form_3()
        {
            InitializeComponent();
            t3 = this;
            f=this.flowLayoutPanel1;
            f3=this.flowLayoutPanel3;
            f2=this.flowLayoutPanel2;
        }
        //(old GPA * old Total credit hours)
        //+ (new grade * credit hours of the new course)
        private void teacher_form_3_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            teacher te = new teacher();
            course vb = new course();
            course[] v2 = new course[vb.get_count_teacher_from_course_fromfile(v.get_teacher_name())];
            v2 = vb.get_teacher_from_course_fromfile(v.get_teacher_name());
            if (v2 != null)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    course_user_control_5 c3 = new course_user_control_5();
                    c3.set_course_uc5(v2[i]);
                    flowLayoutPanel2.Controls.Add(c3);
                }
            }
            else { MessageBox.Show("You Dont Have Any Courses"); }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            teacher_form_1 t1 = new teacher_form_1();
            t1.TopLevel = false;
            t1.TopMost = false;
            t1.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t1);
            t1.set_teacher_form(v);
            t1.Show();

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel3.Controls.Count != 0 || flowLayoutPanel3.Controls.Count > 1 || textBox3.Text == "")
            {
                if (v != null && st != null && course1 != null)
                {
                    grade g = new grade();
                    try
                    {

                        g.set_course_name(course1.get_course_name());
                        g.set_student_name(st.get_student_name());
                        g.set_teacher_name(v.get_teacher_name());
                        g.set_grade(float.Parse(textBox3.Text), st, course1);
                        g.set_grade_2(float.Parse(textBox3.Text));
                        g.send_grade_tofile();
                        MessageBox.Show("grade uploaded complete");
                    }
                    catch { MessageBox.Show("error input"); }
                }
                else MessageBox.Show("somthing is wrong");
            }
            else MessageBox.Show("somthing is wrong");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
