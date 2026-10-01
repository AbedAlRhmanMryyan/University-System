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
using System.Threading;

namespace ClassLibrary1
{
   
    public partial class admin_form_3 : Form
    {
      


        public admin_form_3()
        {
            
            InitializeComponent();
            admin_Form_3 = this;
            f2 = this.flowLayoutPanel2;
            f1 = this.flowLayoutPanel1;
            student s4 = new student();
            s333333 = new student[s4.ReturnAllStudentCountFromFile()];
            label4.Parent = pictureBox1;
            label4.BackColor=Color.Transparent;
       
           

        }
        public static admin_form_3 admin_Form_3;
        public FlowLayoutPanel f2;
        public FlowLayoutPanel f1;
     

        public int count_student = 0;
        public int count_student2 = 0;
        public void set_count_student(int count) { this.count_student2 += count; }
        public void resize_array_students(int count)
        {
            Array.Resize(ref s333333, count);
        }
       
        public int get_count_student() { return count_student; }
        public student[] get_student_array() 
        {
        return s333333;
        }
        public student[] s333333 ;

        public Label l1;
        public Label l2;
        public void add_student(student st) { s333333[count_student] = st; }
        public void set_students(student []st) { s333333 = st; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
           
        }
       
        private void admin_form_3_Load(object sender, EventArgs e)
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
            student s = new student();
            student_user_control_1[] u2 = new student_user_control_1[s.ReturnAllStudentCountFromFile()];

            int i1 = 0;
            if (File.Exists(s.get_student_filename()))
            {

                student[] s2 = new student[s.ReturnAllStudentCountFromFile()];
                s2 = s.ReturnAllStudentFromFile();
                if (s2[0] == null) { MessageBox.Show("no Student"); }
                else
                {
               
                    for (int i = 0; i < s.ReturnAllStudentCountFromFile(); i++)
                    {

                      
                        count_student++;
                        student_user_control_1 u1 = new student_user_control_1();
                        u1.set_student_usercontrol(s2[i]);
                        flowLayoutPanel1.Controls.Add(u1);
                    }
                    label4.Text=count_student.ToString();
                
            
                }
            }
            else { MessageBox.Show("There Is No Students In Data Base"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count == 0)
            { MessageBox.Show("you didnt add students to course"); }
            else
            {
                student_user_control_1[] h = new student_user_control_1[flowLayoutPanel2.Controls.Count];
        

                student[] b = new student[flowLayoutPanel2.Controls.Count];

               
                     flowLayoutPanel2.Controls.CopyTo(h, 0);
               
                for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
                {
                    b[i] = h[i].get_student_usercontrol();


                }
               
                s333333 = b;
                MessageBox.Show("students added sucsses ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_2 j6 = new admin_form_2();
            j6.TopLevel = false;
            j6.TopMost = false;
            j6.Dock= DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(j6);
            j6.Show();
            admin_form_2.a2.set_admin_form2_st(s333333);
          
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_2 j6 = new admin_form_2();
            j6.TopLevel = false;
            j6.TopMost = false;
            j6.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(j6);
            j6.Show();
            admin_form_2.a2.set_admin_form2_st(s333333);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count == 0)
            { MessageBox.Show("you didnt add students to course"); }
            else
            {
                student_user_control_1[] h = new student_user_control_1[flowLayoutPanel2.Controls.Count];


                student[] b = new student[flowLayoutPanel2.Controls.Count];


                flowLayoutPanel2.Controls.CopyTo(h, 0);

                for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
                {
                    b[i] = h[i].get_student_usercontrol();


                }

                s333333 = b;
                MessageBox.Show("students added sucsses ");
            }
        }
    }
}
