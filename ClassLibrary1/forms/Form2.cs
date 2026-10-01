using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form2 : Form
    {
      public PictureBox v;
        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            v = this.pictureBox1;
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
            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;
            checkBox2.Parent = pictureBox1;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.Parent = pictureBox1;
            checkBox3.BackColor = Color.Transparent;
            checkBox4.Parent = pictureBox1;
            checkBox4.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            teacher t = new teacher();
            teacher t2 = new teacher();
            student s = new student();
            student s2 = new student();
            course c = new course();
            course c2 = new course();
            admin a=new admin();
            admin a2= new admin();
            if (checkBox2.Checked == true) { ++i; }
            if (checkBox3.Checked == true) { ++i; }
            if (checkBox4.Checked == true) { ++i; }
            if (i >= 1)
            {
                try
                {
                    if (checkBox2.Checked == true)
                    {
                        if (File.Exists(t.get_teacher_file()))
                        {
                         
                            try
                            {
                                t2 = t.get_teacher_fromfile(textBox1.Text);
                                t = null;
                                if (t2 != null)
                                {
                                    if (t2.get_teacher_name() == textBox1.Text && t2.get_teacher_password() == textBox2.Text)
                                    {
                                        teacher_form_1 t22 = new teacher_form_1();
                                        t22.TopLevel = false;
                                        t22.TopMost = false;
                                        Form1.here1.panel222.Controls.Clear();
                                        Form1.here1.panel222.Controls.Add(t22);
                                        t22.Dock = DockStyle.Fill;
                                        teacher_form_1.t_form.set_teacher_form(t2);
                                        t22.Show();
                                    }
                                    else { MessageBox.Show("Teacher Not Found"); }
                                }
                                else { MessageBox.Show("Teacher Not Found"); }
                            }
                            catch { MessageBox.Show("error"); }
                        }
                        else
                        {
                            t2 = null;
                            MessageBox.Show("Wrong input");
                        }

                    }
                    else if (checkBox3.Checked == true)
                    {
                        MessageBox.Show("student");
                        if (File.Exists(s.get_student_filename()))
                        {
                            s2 = s.get_student_fromfile(textBox1.Text);
                            s = null;
                            if (s2 != null)
                            {
                                if (s2.get_student_name() == textBox1.Text && s2.get_student_password() == textBox2.Text)
                                {
                                    if (s2.get_student_active())
                                    {
                                        student_form_1 s22 = new student_form_1();
                                        s22.TopLevel = false;
                                        s22.TopMost = false;
                                        Form1.here1.panel222.Controls.Clear();
                                        Form1.here1.panel222.Controls.Add(s22);
                                        s22.Dock = DockStyle.Fill;
                                        student_form_1.s_form.set_student_form(s2);
                                        s22.Show();
                                        MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
                                    }
                                    else { MessageBox.Show("Student Not Active"); }
                                }
                                else { MessageBox.Show("Student Not Found"); }
                            }
                            else { MessageBox.Show("Studnet Not Found"); }
                        }
                        else
                        {
                            s2 = null;
                            MessageBox.Show("Wrong input");
                        }

                    }
                    else if (checkBox4.Checked == true)
                    {
                        if (File.Exists(a.get_admin_file()))
                        {
                            MessageBox.Show("admin");
                            a2 = a.get_admin_fromfile(textBox1.Text);
                            a = null;
                            if (a2 != null)
                            {
                                if (a2.get_admin_username() == textBox1.Text && a2.get_admin_password() == textBox2.Text)
                                {
                                    admin_form_1 a22 = new admin_form_1();
                                    a22.TopLevel = false;
                                    a22.TopMost = false;
                                    Form1.here1.panel222.Controls.Clear();
                                    Form1.here1.panel222.Controls.Add(a22);
                                    a22.Dock = DockStyle.Fill;
                                    //   student_form_1.s_form.set_student_form(s2); must add
                                    a22.Show();
                                }
                                else 
                                {
                                    MessageBox.Show("Admin Not Found");
                                }
                             //must add   MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
                            }
                            else { MessageBox.Show("Admin Not Found"); }
                        }
                        else
                        {
                            s2 = null;
                            MessageBox.Show("Wrong input");
                        }
                    }
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }

            else
            {
             
                MessageBox.Show("You Must Select One");

            }
                

            /*if (t2 != null) 
            {
         
                 teacher_form_1 s22=new teacher_form_1();
                 s22.TopLevel = false;
                 s22.TopMost = false;
                 Form1.here1.panel222.Controls.Clear();
                 Form1.here1.panel222.Controls.Add(s22);
                 s22.Dock = DockStyle.Fill;
                teacher_form_1.t_form.set_teacher_form(t2); 
                 s22.Show();
                MessageBox.Show(teacher_form_1.t_form.get_teacher().get_teacher_username());
            }
          else  if(s2 != null)
            {
            
                student_form_1 s22 = new student_form_1();
                s22.TopLevel = false;
                s22.TopMost = false;
            
                Form1.here1.panel222.Controls.Clear();
                
                Form1.here1.panel222.Controls.Add(s22);
                s22.Dock = DockStyle.Fill;
         
                student_form_1.s_form.set_student_form(s2);
         
                s22.Show();
                MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
        
            }*/
        } 
        public void addcontrolltoform1(Form s = null) 
        {
            Form1.here1.Controls.Clear();
            if (s != null) 
            {
                Form1.here1.Controls.Add(s);
                s.BringToFront();
                s.Show();
                
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true) {textBox2.UseSystemPasswordChar=false;}
            else {textBox2.UseSystemPasswordChar=true;}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel12.Controls.Clear();
            Form3 b = new Form3();
            b.TopLevel = true;
            b.TopLevel = false;
            Form1.here1.panel12.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.BackColor = Color.DarkViolet;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel12.Controls.Add(b);
            Form1.here1.panel12.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel12.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel12.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
          

            b.Dock = DockStyle.Fill;
            b.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            teacher t = new teacher();
            teacher t2 = new teacher();
            student s = new student();
            student s2 = new student();
            course c = new course();
            course c2 = new course();
            admin a = new admin();
            admin a2 = new admin();
            if (checkBox2.Checked == true) { ++i; }
            if (checkBox3.Checked == true) { ++i; }
            if (checkBox4.Checked == true) { ++i; }
            if (i >= 1)
            {
                try
                {
                    if (checkBox2.Checked == true)
                    {
                        if (File.Exists(t.get_teacher_file()))
                        {

                            try
                            {
                                t2 = t.get_teacher_fromfile(textBox1.Text);
                                t = null;
                                if (t2 != null)
                                {
                                    if (t2.get_teacher_name() == textBox1.Text && t2.get_teacher_password() == textBox2.Text)
                                    {
                                        teacher_form_1 t22 = new teacher_form_1();
                                        t22.TopLevel = false;
                                        t22.TopMost = false;
                                        Form1.here1.panel222.Controls.Clear();
                                        Form1.here1.panel222.Controls.Add(t22);
                                        t22.Dock = DockStyle.Fill;
                                        teacher_form_1.t_form.set_teacher_form(t2);
                                        t22.Show();
                                    }
                                    else { MessageBox.Show("Teacher Not Found"); }
                                }
                                else { MessageBox.Show("Teacher Not Found"); }
                            }
                            catch { MessageBox.Show("error"); }
                        }
                        else
                        {
                            t2 = null;
                            MessageBox.Show("Wrong input");
                        }

                    }
                    else if (checkBox3.Checked == true)
                    {
                        MessageBox.Show("student");
                        if (File.Exists(s.get_student_filename()))
                        {
                            s2 = s.get_student_fromfile(textBox1.Text);
                            s = null;
                            if (s2 != null)
                            {
                                if (s2.get_student_name() == textBox1.Text && s2.get_student_password() == textBox2.Text)
                                {
                                    if (s2.get_student_active())
                                    {
                                        student_form_1 s22 = new student_form_1();
                                        s22.TopLevel = false;
                                        s22.TopMost = false;
                                        Form1.here1.panel222.Controls.Clear();
                                        Form1.here1.panel222.Controls.Add(s22);
                                        s22.Dock = DockStyle.Fill;
                                        student_form_1.s_form.set_student_form(s2);
                                        s22.Show();
                                        MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
                                    }
                                    else { MessageBox.Show("Student Not Active"); }
                                }
                                else { MessageBox.Show("Student Not Found"); }
                            }
                            else { MessageBox.Show("Studnet Not Found"); }
                        }
                        else
                        {
                            s2 = null;
                            MessageBox.Show("Wrong input");
                        }

                    }
                    else if (checkBox4.Checked == true)
                    {
                        if (File.Exists(a.get_admin_file()))
                        {
                            MessageBox.Show("admin");
                            a2 = a.get_admin_fromfile(textBox1.Text);
                            a = null;
                            if (a2 != null)
                            {
                                if (a2.get_admin_username() == textBox1.Text && a2.get_admin_password() == textBox2.Text)
                                {
                                    admin_form_1 a22 = new admin_form_1();
                                    a22.TopLevel = false;
                                    a22.TopMost = false;
                                    Form1.here1.panel222.Controls.Clear();
                                    Form1.here1.panel222.Controls.Add(a22);
                                    a22.Dock = DockStyle.Fill;
                                    //   student_form_1.s_form.set_student_form(s2); must add
                                    a22.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Admin Not Found");
                                }
                                //must add   MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
                            }
                            else { MessageBox.Show("Admin Not Found"); }
                        }
                        else
                        {
                            s2 = null;
                            MessageBox.Show("Wrong input");
                        }
                    }
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }

            else
            {

                MessageBox.Show("You Must Select One");

            }


            /*if (t2 != null) 
            {
         
                 teacher_form_1 s22=new teacher_form_1();
                 s22.TopLevel = false;
                 s22.TopMost = false;
                 Form1.here1.panel222.Controls.Clear();
                 Form1.here1.panel222.Controls.Add(s22);
                 s22.Dock = DockStyle.Fill;
                teacher_form_1.t_form.set_teacher_form(t2); 
                 s22.Show();
                MessageBox.Show(teacher_form_1.t_form.get_teacher().get_teacher_username());
            }
          else  if(s2 != null)
            {
            
                student_form_1 s22 = new student_form_1();
                s22.TopLevel = false;
                s22.TopMost = false;
            
                Form1.here1.panel222.Controls.Clear();
                
                Form1.here1.panel222.Controls.Add(s22);
                s22.Dock = DockStyle.Fill;
         
                student_form_1.s_form.set_student_form(s2);
         
                s22.Show();
                MessageBox.Show(student_form_1.s_form.get_student_form().get_student_username());
        
            }*/
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel12.Controls.Clear();
            Form3 b = new Form3();
            b.TopLevel = true;
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            b.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
