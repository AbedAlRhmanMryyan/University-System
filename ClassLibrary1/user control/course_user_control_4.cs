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
    public partial class course_user_control_4 : UserControl
    {
        course z;
        messages []m;
        public void set_course_uc4(course co) 
        {
        z= co;
        }
        public course get_course_uc4() {  return z; }
        public course_user_control_4()
        {
            InitializeComponent();
        
         
            
        }

        private void course_user_control_4_Load(object sender, EventArgs e)
        {
            coursename.Text=z.get_course_name();
            credithours.Text=z.get_ch_hours().ToString();
            teacher.Text=z.get_teacher_name();

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            credithours.Parent = pictureBox1;
            credithours.BackColor = Color.Transparent;

            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            student_form_5.sf5.f.Controls.Clear();
            student_form_5.sf5.f.Controls.Add(this);
            student_form_5.sf5.set_course_sf5(z);
            MessageBox.Show("Course Selected");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            messages v = new messages();
            m = v.get_message_fromfile();
            for(int i=0; i<m.Length; i++) 
            {
                if (m[i].get_course_messages() == student_form_5.sf5.get_course_sf5().get_course_name()) 
                {
                    MessageBox.Show(m[i].get_message());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
