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
    public partial class student_form_2 : Form
    {
        student s;
        string picture_box_address = "";
        public student_form_2()
        {
            InitializeComponent();
    
      


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void set_student_form_2(student st) { this.s = st; }
        public student get_student_form_2() { return this.s; }

        private void button5_Click(object sender, EventArgs e)
        {
         
          
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picture_box_address = openFileDialog1.FileName;
                }
            
                pictureBox1.Image = Image.FromFile(picture_box_address);
                s.set_student_picture(picture_box_address);
                s.edit_student_v3(s);
       
                MessageBox.Show("Edit Complete");
                this.Refresh();

            }
            catch (Exception ex) { MessageBox.Show("No Picture Selected"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            student_form_1 s1=new student_form_1();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock= DockStyle.Fill;
            student_form_1.s_form.set_student_form(s);
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            Form2 s1 = new Form2();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock = DockStyle.Fill;
   
            s1.Show();
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.BackColor = Color.Transparent;
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int u = 0;
         
            if (pictureBox1.Tag != null)
            {
                u++;
            s.set_student_picture(picture_box_address);
                s.edit_student_v3(s);
            }
            if ( textBox1.Text != "") 
            {
                u++;
            s.set_student_name(textBox1.Text);
                s.edit_student_v3(s);
            }
            if(textBox2.Text!="")
            {
                u++;
                s.set_student_username(textBox2.Text);
                s.edit_student_v3(s);

            }
            if(textBox3.Text!="")
            {
                u++;
                s.set_student_date_of_birth(textBox3.Text);
                s.edit_student_v3(s);
            }
           
            if (u > 0) 
            {
                

                MessageBox.Show("edit complete");
            }
            else
            {
                MessageBox.Show("You Dont Change Any Thing");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void student_form_2_Load(object sender, EventArgs e)
        {
    

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
        

            this.label3.Parent = pictureBox2;
            this.label3.BackColor = Color.Transparent;

            this.label4.Parent = pictureBox2;
            this.label4.BackColor = Color.Transparent;

            this.label5.Parent = pictureBox2;
            this.label5.BackColor = Color.Transparent;


            this.label7.Parent = pictureBox2;
            this.label7.BackColor = Color.Transparent;

       

            this.label9.Parent = pictureBox2;
            this.label9.BackColor = Color.Transparent;

 

            this.label12.Parent = pictureBox2;
            this.label12.BackColor = Color.Transparent;
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock = DockStyle.Top;
            Form1.here1.panel13.Parent = pictureBox2;
            Form1.here1.panel13.BackColor = Color.Transparent;
            Form1.here1.panel13.BringToFront();
            Form1.here1.panel222.Controls.Add(this);
            Form1.here1.panel222.Controls.Add(Form1.here1.Button1);
            Form1.here1.Button1.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button2);
            Form1.here1.Button2.BringToFront();
            Form1.here1.panel222.Controls.Add(Form1.here1.Button3);
            Form1.here1.Button3.BringToFront();

            try
            {
                s = student_form_1.s_form.get_student_form();
                label3.Text = s.get_student_name();
                label4.Text = s.get_student_username();
                label5.Text = s.get_student_GPA().ToString();
                label7.Text = s.get_student_active().ToString();
                label12.Text = s.get_student_date_of_birth();
                label9.Text = s.get_student_total_ch().ToString();

                try
                {
                    if (s.get_student_picture() != null)
                    {
                        pictureBox1.Image = Image.FromFile(s.get_student_picture());
                    }
                }
                catch { }
            }
            catch { }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            textBox2.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            student_form_1 s1 = new student_form_1();
            s1.TopLevel = false;
            s1.TopMost = false;
            Form1.here1.panel222.Controls.Add(s1);
            s1.Dock = DockStyle.Fill;
            student_form_1.s_form.set_student_form(s);
            s1.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            textBox2.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            textBox3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
