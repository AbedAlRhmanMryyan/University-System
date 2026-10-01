using ClassLibrary1.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.forms
{
    public partial class teacher_form_2 : Form
    {
        teacher t;
        course c; 
        public static teacher_form_2 t2_form;
        public FlowLayoutPanel fl;
        public teacher_form_2()
        {
            InitializeComponent();
            t2_form = this;
            fl = flowLayoutPanel2;
        }
        public void set_course_teacher_form_2(course cv) 
        {
        
        c= cv;
        }

        public void set_teacher_form_2(teacher t1) { t = t1; }
        public teacher get_teacher() { return t; }

        private void teacher_form_2_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Add(Form1.here1.panel13);
            Form1.here1.panel13.Dock = DockStyle.Top;
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

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            teacher te = new teacher();
            course vb= new course();
            course[] v = new course[vb.get_count_teacher_from_course_fromfile(t.get_teacher_name())];
            v = vb.get_teacher_from_course_fromfile(t.get_teacher_name());
            if (v != null) 
            {
                for (int i = 0; i < v.Length; i++)
                {
                    course_user_control_3 c3 = new course_user_control_3();
                    c3.set_course_cuc3(v[i]);
                    flowLayoutPanel2.Controls.Add(c3);  
                }
            }
            else { MessageBox.Show("You Dont Have Any Courses"); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
      
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            messages m = new messages();
            m.set_message(textBox1.Text);
            m.set_course_messages(c.get_course_name());
            m.set_teacher_massages(c.get_teacher_name());
            m.send_message_tofile();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
          
            if (flowLayoutPanel2.Controls.Count != 0 || flowLayoutPanel2.Controls.Count > 1)
            {
                if (c != null)
                {
                    messages m = new messages();
                    m.set_message(richTextBox1.Text);
                    m.set_course_messages(c.get_course_name());
                    m.set_teacher_massages(c.get_teacher_name());
                    m.send_message_tofile();
                    MessageBox.Show("Message Send Succeed");
                }
                else MessageBox.Show("You Must Select Course");
            }
            else MessageBox.Show("You Must Select Course");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();  
            course[] p;
            course b=new course();
            p = b.get_teacher_from_course_fromfile(t.get_teacher_name());
            if (p != null)
            {
                for (int i = 0; i < b.get_count_teacher_from_course_fromfile(t.get_teacher_name()); i++)
                {
                    if (p[i].get_course_name() == textBox1.Text)
                    {
                        course_user_control_3 s3 = new course_user_control_3();
                        s3.set_course_cuc3(p[i]);
                        flowLayoutPanel2.Controls.Add(s3);
                    }
              
                }
            }
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
           
            teacher_form_1 t1=new teacher_form_1();
            t1.set_teacher_form(t);
            t1.TopLevel = false;
            t1.TopMost = false;
            t1.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(t1);
            
            t1.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            teacher te = new teacher();
            course vb = new course();
            course[] v = new course[vb.get_count_teacher_from_course_fromfile(t.get_teacher_name())];
            v = vb.get_teacher_from_course_fromfile(t.get_teacher_name());
            if (v != null)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    course_user_control_3 c3 = new course_user_control_3();
                    c3.set_course_cuc3(v[i]);
                    flowLayoutPanel2.Controls.Add(c3);
                }
            }
            else { MessageBox.Show("You Dont Have Any Courses"); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
