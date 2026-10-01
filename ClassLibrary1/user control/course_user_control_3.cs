using ClassLibrary1.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.user_control
{
    public partial class course_user_control_3 : UserControl
    {
        course c;
        public course_user_control_3()
        {
            InitializeComponent();
        }
        public void set_course_cuc3(course v) 
        {
            c = v;
        }
        public course get_course_cuc3() { return c; }


        private void course_user_control_3_Load(object sender, EventArgs e)
        {
            coursename.Text=c.get_course_name();
            credithours.Text=c.get_ch_hours().ToString();
            teacher.Text=c.get_teacher_name();

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            credithours.Parent = pictureBox1;
            credithours.BackColor = Color.Transparent;

            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
        
            student_form_4 s4 = new student_form_4();
            student[] s;
            s = c.get_students().ToArray();
            for (int i = 0; i < s.Length; i++)
            {
                student_user_control_1 s1 = new student_user_control_1();
                s1.set_student_usercontrol(s[i]);
                s1.bbbbbbb1.Hide();
                s1.bbbbbbb2.Hide();
                s1.bbbbbbb3.Hide();
                s4.f1.Controls.Add(s1);
            }
            s4.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            teacher_form_2.t2_form.fl.Controls.Clear();
            teacher_form_2.t2_form.fl.Controls.Add(this);
            teacher_form_2.t2_form.set_course_teacher_form_2(c);
            MessageBox.Show("Course Selected");
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
