using ClassLibrary1.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.forms
{
    public partial class student_form_6 : Form
    {
        student vzxc;
        public void set_student_f6(student v1) { vzxc = v1; }
        public student get_student_f6(){ return vzxc; }
        public student_form_6()
        {
            InitializeComponent();
        }

        private void student_form_6_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Parent = pictureBox1;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.Dock = DockStyle.Top;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            student_form_1 s1 = new student_form_1();
            s1.TopMost = false;
            s1.TopLevel = false;
            s1.Dock = DockStyle.Fill;
            s1.set_student_form(vzxc);
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(s1);
            s1.Show();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            grade v = new grade();
            if (File.Exists(v.get_grade_file()))
            {
                grade[] b=new grade[0];
             
              
                    b = v.get_grade_fromfile_s(vzxc.get_student_name());
               
          
                if (b != null)
                { 
            
                for (int i = 0; i < v.get_grade_fromfile_s(vzxc.get_student_name()).Length; i++)
                {
                    grade_user_control_1 g1 = new grade_user_control_1();
                    g1.set_grade_uc1(b[i]);
                    flowLayoutPanel1.Controls.Add(g1);
                }
                if (v.get_grade_fromfile_s(vzxc.get_student_name()).Length == 0)
                {
                    MessageBox.Show("You dont have any grade");
                }

                }
            }
            else { MessageBox.Show("There is no grades for you"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
