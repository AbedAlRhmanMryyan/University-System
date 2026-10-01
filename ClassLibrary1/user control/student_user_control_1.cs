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

namespace ClassLibrary1
{
    public partial class student_user_control_1 : UserControl
    {

       public static UserControl studentControl;
       public Label studentLabel1;
        public Label studentLabel2;
        public Label studentLabel3;
        public PictureBox studentPictureBox1;
        student s;
        public void set_student_usercontrol(student b) { s = b; }
        public student get_student_usercontrol() { return s; }
        public Button g;
        public Button bbbbbbb1;
        public Button bbbbbbb2;
        public Button bbbbbbb3;

        public student_user_control_1()
        {

            InitializeComponent();
            studentControl = this;
            studentLabel1 = this.label4;
            studentLabel2 = this.label5;
            studentLabel3 = this.label6;
            studentPictureBox1 = this.pictureBox1;
            button3.Hide();
            g = button3;
            bbbbbbb1=this.button1;
            bbbbbbb2=this.button2;
            bbbbbbb3=this.button3;
    }

        private void student_user_control_1_Load(object sender, EventArgs e)
        {
            this.label6.Text=s.get_student_name();
            this.label5.Text=s.get_student_username();
            this.label4.Text=s.get_student_date_of_birth();
            try 
            {
            pictureBox1.Image=Image.FromFile(s.get_student_picture());
            }
            catch { }


            this.label4.Parent = pictureBox2;
            label4.BackColor = Color.Transparent;


            this.label5.Parent = pictureBox2;
            label5.BackColor = Color.Transparent;


            this.label5.Parent = pictureBox2;
            label6.BackColor = Color.Transparent;

            this.label6.Parent = pictureBox2;
            label6.BackColor =Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_form_3.admin_Form_3.count_student = 0;
           // admin_form_3.admin_Form_3.add_student(s);
            admin_form_3.admin_Form_3.f2.Controls.Add(this);
            admin_form_3.admin_Form_3.Refresh();
            int b = admin_form_3.admin_Form_3.get_count_student();
            admin_form_3.admin_Form_3.set_count_student(b++);
           
            

  


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            student v1 = new student();
            student_user_control_1[] v = new student_user_control_1[admin_form_3.admin_Form_3.f2.Controls.Count];
            admin_form_3.admin_Form_3.f2.Controls.CopyTo(v, 0);
        
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i].get_student_usercontrol().get_student_name() == s.get_student_name())
                {

                    admin_form_3.admin_Form_3.f2.Controls.Remove(v[i]);
                    admin_form_3.admin_Form_3.f1.Controls.Add(v[i]);
                }
            }


            /*
           
            admin_form_3.admin_Form_3.count_student = 0;
            admin_form_3.admin_Form_3.add_student(s);
            admin_form_3.admin_Form_3.f1.Controls.Add(this);
            admin_form_3.admin_Form_3.Refresh();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
