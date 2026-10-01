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
    public partial class student_user_control_2 : UserControl
    {
    public static student_user_control_2 s2;
        student st;
        public student_user_control_2()
        {
            InitializeComponent();
            s2 = this;
        }
        public void set_student_usercontrol_2(student sf) 
        {
        st= sf;
        }
        public student get_student_usercontrol_2() 
        {
            return st;
        }

        private void student_user_control_2_Load(object sender, EventArgs e)
        {
            this.name.Text = st.get_student_name();
            this.username.Text = st.get_student_username();
            this.credithours.Text=st.get_student_total_ch().ToString();
            this.date.Text=st.get_student_date_of_birth();
            this.active.Text = st.get_student_active().ToString();
            this.gpa.Text = st.get_student_GPA().ToString();
            try 
            { 
                pictureBox1.Image = Image.FromFile(st.get_student_picture());
            }
            catch 
            { }


            this.name.Parent = pictureBox2;
            this.username.Parent = pictureBox2;
            this.credithours.Parent = pictureBox2;
            this.date.Parent = pictureBox2;
            this.active.Parent = pictureBox2;
            this.gpa.Parent = pictureBox2;

            this.name.BackColor = Color.Transparent;
            this.username.BackColor = Color.Transparent;
            this.credithours.BackColor = Color.Transparent;
            this.date.BackColor = Color.Transparent;
            this.active.BackColor = Color.Transparent;
            this.gpa.BackColor = Color.Transparent;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            st.set_student_active(false);
            st.edit_student_v3(st);

            MessageBox.Show("edited completed");
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.set_student_active(true);
            st.edit_student_v3(st);

            MessageBox.Show("edited completed");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
