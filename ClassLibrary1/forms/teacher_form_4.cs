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
    public partial class teacher_form_4 : Form
    {
        teacher t;
        public void set_teacher_f4(teacher t2) { t = t2; }
        public teacher get_teacher_f4(){ return t; }
        
        public teacher_form_4()
        {
            InitializeComponent();
        }

        private void teacher_form_4_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock = DockStyle.Top;
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
            teacher_form_1 t3= new teacher_form_1();
            t3.TopLevel = false;
            t3.TopMost = false;
            t3.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t3 );
            t3.set_teacher_form(t);
            t3.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            grade v= new grade();
            if (File.Exists(v.get_grade_file()))
            {
            
                grade[] b = v.get_grade_fromfile_t(t.get_teacher_name());
          
                for (int i = 0; i < v.get_grade_fromfile_t(t.get_teacher_name()).Length; i++)
                {
                    grade_user_control_1 g1 = new grade_user_control_1();
                    g1.set_grade_uc1(b[i]);
                    flowLayoutPanel1.Controls.Add(g1);
                }
                if (v.get_grade_fromfile_t(t.get_teacher_name()).Length == 0) 
                {
                    MessageBox.Show("You dont have any grade");
                }
            }
            else { MessageBox.Show("There is no grades for you"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
