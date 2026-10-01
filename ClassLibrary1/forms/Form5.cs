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
    public partial class Form5 : Form
    {


        UserControl1[] a = new UserControl1[20];

        public Form5()
        {

            InitializeComponent();
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
          
       
                a[0] = new UserControl1();
                a[0].l1.Text = "sfsfs";
                a[0].l2.Text = "sfsssfsf";
                flowLayoutPanel1.Controls.Add(a[0]);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a[1] = new UserControl1();
            a[1].l1.Text = "s";
            a[1].l2.Text = "sf";
            flowLayoutPanel1.Controls.Add(a[1]);
        }
    }
}
