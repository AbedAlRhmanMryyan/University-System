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
    public partial class student_user_control_3 : UserControl
    {
        student s;
        public void set_student_userconrol_3(student st) 
        {
        s= st;
        }
        public student get_studnet_userconrol_3() {  return s; }
        public student_user_control_3()
        {
            InitializeComponent();
        }

        private void student_user_control_3_Load(object sender, EventArgs e)
        {
            name.Text=s.get_student_name();
            username.Text=s.get_student_username();
            date.Text=s.get_student_date_of_birth();
            try
            {
                pictureBox1.Image = Image.FromFile(s.get_student_picture());
            }
            catch { }

            name.Parent = pictureBox2;
            name.BackColor = Color.Transparent;

            username.Parent = pictureBox2;
            username.BackColor = Color.Transparent;

            date.Parent = pictureBox2;
            date.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
           
            if (admin_form_5.a5.f2.Controls.Count > 1)
            {
                MessageBox.Show("You Must Select A Course");
            }
            else
            {
                student v = new student();
                student[] cv = admin_form_5.a5.get_course().get_students().ToArray();
                for (int i = 0; i < cv.Length; i++)
                {
                    if (cv[i].get_student_name() != s.get_student_name())
                    {
                        admin_form_5.a5.f3.Controls.Add(this);
                    }
                }
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
