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
    public partial class student_form_4 : Form
    {
       public FlowLayoutPanel f1;
        public student_form_4()
        {
            InitializeComponent();
            f1 = this.flowLayoutPanel1;
            rjButton1.Parent = pictureBox1;
            rjButton1.BackColor = Color.Transparent;
         
        }

       private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
