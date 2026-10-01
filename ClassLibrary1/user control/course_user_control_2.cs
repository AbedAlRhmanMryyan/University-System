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
    public partial class course_user_control_2 : UserControl
    {
        public course_user_control_2()
        {
            InitializeComponent();
        }
        course c1;
        public void set_course_user_control(course co) { c1 = co; }
        public course get_course_user_control() { return c1; }
        private void course_user_control_2_Load(object sender, EventArgs e)
        {
            coursename.Text=c1.get_course_name();
            teacher.Text=c1.get_teacher_name();
            credithours.Text=c1.get_ch_hours().ToString();
            capacity.Text=c1.get_capacity().ToString();

            credithours.Parent = pictureBox1;
            credithours.BackColor = Color.Transparent;

            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;

           capacity.Parent = pictureBox1;
            capacity.BackColor = Color.Transparent;

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            student_form_4 s4 = new student_form_4();
            student[] s;
            s = c1.get_students().ToArray();
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

        private void button2_Click(object sender, EventArgs e)
        {
            admin_form_5.a5.f2.Controls.Clear();
            admin_form_5.a5.f2.Controls.Add(this);
            admin_form_5.a5.set_course_adminform5(null);
            admin_form_5.a5.set_course_adminform5(c1);
            MessageBox.Show("Course Selected");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
