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
    public partial class student_user_control_4 : UserControl
    {
        public Button bbb1;
        public Button bbb2;
        student s;
        public void set_student_uc4(student st) { s= st; }
        public student get_student_uc4(){ return s; }

        public student_user_control_4()
        {
            InitializeComponent();
            bbb1 = this.button1;
            bbb2 = this.button2;
        }

        private void student_user_control_4_Load(object sender, EventArgs e)
        {
            name.Text = s.get_student_name();
            username.Text = s.get_student_username();
            date.Text = s.get_student_date_of_birth();
            try
            {
                pictureBox1.Image = Image.FromFile(s.get_student_picture());
            }
            catch { }
            name.Parent = pictureBox2;
            username.Parent = pictureBox2;
            date.Parent = pictureBox2;

            name.BackColor=Color.Transparent;
            username.BackColor = Color.Transparent;
            date.BackColor = Color.Transparent;


        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher_form_3.t3.f3.Controls.Clear();
            teacher_form_3.t3.f3.Controls.Add(this);
            teacher_form_3.t3.set_student_tf3(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            teacher_form_3.t3.f.Controls.Add(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
