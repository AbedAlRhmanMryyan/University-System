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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
          
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.here1.Button1.Enabled = true;
            Form1.here1.Button1.Select();
            Form1.here1.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Hide();
            Form5 v = new Form5();
            v.TopLevel = false;
            v.TopMost = false;
            this.panel2.Controls.Add(v);
            v.Show();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
