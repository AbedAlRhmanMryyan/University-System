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

namespace ClassLibrary1
{
    public partial class admin_form_2 : Form
    {
        student[] st;
      public static admin_form_2 a2;

        public admin_form_2()
        {
            InitializeComponent();
            a2 = this;
        }
        public void set_admin_form2_st(student[] st) 
        {
        this.st = st;
        }
        public student[] get_admin_form2_st() 
        {
            return st;
        }

        private void admin_form_2_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_1 a1 = new admin_form_1();
            a1.TopLevel = false;
            a1.TopMost = false;
            Form1.here1.panel222.Controls.Add(a1);
            a1.Dock = DockStyle.Fill;
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_form_3 a3=new admin_form_3();
            a3.TopLevel = false;
            a3.TopMost = false;
            a3.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a3 );
            a3.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                course c = new course();
                teacher t = new teacher();
                
                c.set_course_name(textBox1.Text);
                c.set_ch_hourse(Convert.ToInt32(textBox2.Text));
                c.set_capacity(Convert.ToInt32(textBox3.Text));
                c.set_teacher_name(textBox4.Text); 
                 
                
                if (st != null)
                {
                    if (c.get_capacity() >= st.Length)
                    {
                        c.set_array_of_student(st);
                        c.send_course_tofile();
                        MessageBox.Show("course add sucsess");
                    }
                    else MessageBox.Show("the capacity is less than the number of student try again");
                }
                else { MessageBox.Show("You Dont Add Any Student"); }
            }
            catch 
            {
                MessageBox.Show("Somthing went wrong");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < st.Length; i++) { MessageBox.Show(st[i].get_student_name()); }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_1 a1 = new admin_form_1();
            a1.TopLevel = false;
            a1.TopMost = false;
            Form1.here1.panel222.Controls.Add(a1);
            a1.Dock = DockStyle.Fill;
            a1.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                course c = new course();
                teacher t = new teacher();

                c.set_course_name(textBox1.Text);
                c.set_ch_hourse(Convert.ToInt32(textBox2.Text));
                c.set_capacity(Convert.ToInt32(textBox3.Text));
                c.set_teacher_name(textBox4.Text);


                if (st != null)
                {
                    if (c.get_capacity() >= st.Length)
                    {
                        c.set_array_of_student(st);
                        c.send_course_tofile();
                        MessageBox.Show("course add sucsess");
                    }
                    else MessageBox.Show("the capacity is less than the number of student try again");
                }
                else { MessageBox.Show("You Dont Add Any Student"); }
            }
            catch
            {
                MessageBox.Show("Somthing went wrong");
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            admin_form_3 a3 = new admin_form_3();
            a3.TopLevel = false;
            a3.TopMost = false;
            a3.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a3);
            a3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
