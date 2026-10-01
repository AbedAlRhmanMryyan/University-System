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
    public partial class course_user_control_1 : UserControl
    {
        course c1;
 
        public course_user_control_1()
        {
            InitializeComponent();
        }
        public void set_course_user_control(course co) { c1 = co; }
        public course get_course_user_control() { return c1; }

        private void button1_Click(object sender, EventArgs e)
        {
           
            student_form_4 s4=new student_form_4();
            student[] s;
             s=c1.get_students().ToArray();
            for(int i=0; i < s.Length; i++) 
            {
                student_user_control_1 s1 = new student_user_control_1();
                s1.set_student_usercontrol(s[i]);
          
                s4.f1.Controls.Add(s1);
                s1.bbbbbbb1.Hide();
                s1.bbbbbbb2.Hide();
                s1.bbbbbbb3.Hide();
            }
            s4.ShowDialog();
        }

        private void course_user_control_1_Load(object sender, EventArgs e)
        {
            coursename.Text=c1.get_course_name();
            credithours.Text=c1.get_ch_hours().ToString();
            teachername.Text=c1.get_teacher_name();
            capacity.Text=c1.get_capacity().ToString();

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            credithours.Parent = pictureBox1;
            credithours.BackColor = Color.Transparent;

            teachername.Parent = pictureBox1;
            teachername.BackColor = Color.Transparent;

            capacity.Parent = pictureBox1;
            capacity.BackColor = Color.Transparent;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
