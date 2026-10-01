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
    public partial class admin_form_1 : Form
    {
       public static admin_form_1 admin_form;
        public Panel admin_panel;
        public admin_form_1()
        {
            admin_form = this;
         
            InitializeComponent();
        }

        private void admin_form_1_Load(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            admin_form_2 a2=new admin_form_2();
            a2.TopLevel = false;
            a2.TopMost= false;
            Form1.here1.panel222.Controls.Add(a2);
            a2.Dock = DockStyle.Fill;
            a2.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           admin_form_4 a4=new admin_form_4();
            Form1.here1.panel222.Controls.Clear();
            a4.TopLevel = false;
            a4.TopMost = false;
            a4.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(a4);
            a4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.here1.panel222.Controls.Clear();
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.TopMost = false;
            Form1.here1.panel222.Controls.Add(f2);
            f2.Dock = DockStyle.Fill;
            f2.Show();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
           admin_form_5 a5=new admin_form_5();
            a5.TopLevel = false;
            a5.TopMost = false;
            a5.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a5);
            a5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_form_6 a6=new admin_form_6();
            a6.TopLevel = false;
            a6.TopMost = false;
            a6.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Clear();
            Form1.here1.panel222.Controls.Add(a6 );
            a6.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            admin_form_4 a4 = new admin_form_4();
            Form1.here1.panel222.Controls.Clear();
            a4.TopLevel = false;
            a4.TopMost = false;
            a4.Dock = DockStyle.Fill;
            Form1.here1.panel222.Controls.Add(a4);
            a4.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

