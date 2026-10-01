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
    public partial class teacher_user_control_1 : UserControl
    {
        teacher t1;
        public teacher_user_control_1()
        {
            InitializeComponent();
        }

        public void set_teacher_usercontrol(teacher t) 
        {
        t1= t;
        }
        public teacher get_teacher() {return t1;}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacher_user_control_1_Load(object sender, EventArgs e)
        {
            this.name.Text=t1.get_teacher_name();
            this.username.Text=t1.get_teacher_username();

            name.Parent = pictureBox1;
            name.BackColor = Color.Transparent;

            username.Parent = pictureBox1;
            username.BackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("soon");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soon");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
