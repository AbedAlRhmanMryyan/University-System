using ClassLibrary1.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class teacher_form_1 : Form
    {
       public static teacher_form_1 t_form;
         teacher t_teacher;

        public teacher_form_1()
        {
            InitializeComponent();
            t_form = this;

        }
        public void set_teacher_form(teacher t) 
        {
        t_teacher = t;
        }
        public teacher get_teacher() { return t_teacher; }

        private void teacher_form_1_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Parent = pictureBox1;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher_form_3 t3= new teacher_form_3();
            t3.TopLevel = false;
            t3.TopMost = false;
            t3.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t3);
            t3.set_teacher_tf3(t_teacher);
            t3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacher_form_2 t2= new teacher_form_2();
            t2.TopLevel = false;
            t2.TopMost = false;
            t2.Dock = DockStyle.Fill;
            t2.set_teacher_form_2(t_teacher);
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t2);
            t2.Show();
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacher_form_4 t4= new teacher_form_4();
            t4.TopLevel = false;
            t4.TopMost = false;
            t4.Dock = DockStyle.Fill;
            t4.set_teacher_f4(t_teacher);
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t4);
            t4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();  
            f2.TopLevel = false;
            f2.TopMost = false;
            f2.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(f2 );
            f2.Show();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
