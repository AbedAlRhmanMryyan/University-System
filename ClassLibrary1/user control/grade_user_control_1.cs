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
    public partial class grade_user_control_1 : UserControl
    {
        grade g;
        public void set_grade_uc1(grade g1) { g= g1; }
        public grade get_grade_uc1(){ return g; }
        public grade_user_control_1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grade_user_control_1_Load(object sender, EventArgs e)
        {
            coursename.Text=g.get_course_name();
            teacher.Text=g.get_teacher_name();
            grade.Text=g.get_grade_2().ToString();

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;

            grade.Parent = pictureBox1;
            grade.BackColor = Color.Transparent;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
