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
    public partial class message_user_control_1 : UserControl
    {
        messages ma;
        public void set_message_user_control_1(messages ma1) { ma = ma1; }
        public messages get_message_user_control_1() { return ma; }
        public message_user_control_1()
        {
            InitializeComponent();
        }

        private void message_user_control_1_Load(object sender, EventArgs e)
        {
            teacher.Text = ma.get_teacher_massages();
            coursename.Text=ma.get_course_messages();
            message.Text = ma.get_message();


            teacher.Parent = pictureBox1;
            teacher.BackColor = Color.Transparent;

            coursename.Parent = pictureBox1;
            coursename.BackColor = Color.Transparent;

            message.Parent=pictureBox1;
            message.BackColor = Color.Transparent;
        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
