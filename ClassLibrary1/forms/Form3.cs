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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form4 form4 = new Form4();
       
            form4.TopLevel=false;
            form4.TopMost=false;
           this.Controls.Add(form4);
           form4.Show();
           form4.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { textBox3.UseSystemPasswordChar = false; }
            else { textBox3.UseSystemPasswordChar = true; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel12.Controls.Clear();
            Form2 form2 = new Form2();  
            form2.TopLevel=false;
            form2.TopMost=false;
            Form1.here1.panel12.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
         
            Form1.here1.panel12.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.BackColor = Color.White;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel12.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel12.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel12.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int b = 0;
            if (checkBox2.Checked) { b++; }
            if (checkBox3.Checked) { b++; }
            if (checkBox4.Checked) { b++; }
            teacher t1 = new teacher();
            student s1 = new student();
            course c1 = new course();
            admin a1 = new admin();
            if (b > 1) { MessageBox.Show("You Must Choose One Only"); }
            else
            {
                if (checkBox2.Checked) 
                { 
                  
                    if (File.Exists(t1.get_teacher_file()))
                    {
                        if (t1.get_teacher_fromfile(textBox1.Text) == null)
                        {
                            t1.set_teacher_name(textBox1.Text);
                            t1.set_teacher_username(textBox2.Text);
                            t1.set_teacher_password(textBox3.Text);
                            t1.send_teacher_tofile();
                            MessageBox.Show("Teacher regesterd succsess");
                         
                        }

                        else
                        {
                            MessageBox.Show("Teacher is already exsist");
                        }
                    }
                    else 
                    {

                        t1.set_teacher_name(textBox1.Text);
                        t1.set_teacher_username(textBox2.Text);
                        t1.set_teacher_password(textBox3.Text);
                        t1.send_teacher_tofile();
                        MessageBox.Show("Teacher regesterd succsess");
                    }
                }
                if (checkBox3.Checked)
                {

                    if (File.Exists(s1.get_student_filename()))
                    {
                        if (s1.get_student_fromfile(textBox1.Text) == null)
                        {
                            s1.set_student_name(textBox1.Text);
                            s1.set_student_username(textBox2.Text);
                            s1.set_student_password(textBox3.Text);
                            s1.send_student_tofile();
                            MessageBox.Show("Student regesterd succsess");

                        }

                        else
                        {
                            MessageBox.Show("Student is already exsist");
                        }
                    }
                    else
                    {

                        s1.set_student_name(textBox1.Text);
                        s1.set_student_username(textBox2.Text);
                        s1.set_student_password(textBox3.Text);
                        s1.send_student_tofile();
                        MessageBox.Show("Student regesterd succsess");
                    }
                }
                if (checkBox4.Checked) 
                {
                    if (File.Exists(a1.get_admin_file()))
                    {
                        if (a1.get_admin_fromfile(textBox1.Text) == null)
                        {
                            a1.set_admin_username(textBox1.Text);
                            a1.set_admin_password(textBox3.Text);
                            a1.send_admin_to_file();
                            MessageBox.Show("Admin regesterd succsess");

                        }

                        else
                        {
                            MessageBox.Show("Admin is already exsist");
                        }
                    }
                    else
                    {

                        a1.set_admin_username(textBox1.Text);
                        a1.set_admin_password(textBox3.Text);
                        a1.send_admin_to_file();
                        MessageBox.Show("Admin regesterd succsess");
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Parent = pictureBox1;
            Form1.here1.panel13.BackColor = Color.Transparent;
            checkBox1.Parent = pictureBox1;
            checkBox1.BackColor = Color.Transparent;
            checkBox2.Parent = pictureBox1;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.Parent = pictureBox1;
            checkBox3.BackColor = Color.Transparent;
            checkBox4.Parent = pictureBox1;
            checkBox4.BackColor = Color.Transparent;
            Form1.here1.panel13.Dock = DockStyle.None;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
