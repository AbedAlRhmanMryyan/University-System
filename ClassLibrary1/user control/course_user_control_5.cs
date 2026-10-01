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
    
    public partial class course_user_control_5 : UserControl
    {
        course c;
        public void set_course_uc5(course course_uc5) {c=course_uc5;}
        public course get_course_uc5() {return c;}
        public course_user_control_5()
        {
            InitializeComponent();
        }

        private void course_user_control_5_Load(object sender, EventArgs e)
        {
            coursename.Text=c.get_course_name();
            teacher.Text=c.get_teacher_name();
            credithours.Text=c.get_ch_hours().ToString();

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;

            credithours.Parent = pictureBox1;
            credithours.BackColor = Color.Transparent;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            teacher_form_3.t3.f.Controls.Clear();
            teacher_form_3.t3.f2.Controls.Clear();
            teacher_form_3.t3.f2.Controls.Add(this);
            teacher_form_3.t3.set_course_tf3(c);
            student []b=c.get_students().ToArray();
       
            for (int i43 = 0; i43 < b.Length; i43++) 
            {
                student_user_control_4 u4 = new student_user_control_4();
                u4.set_student_uc4(b[i43]);
                teacher_form_3.t3.f.Controls.Add(u4);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
