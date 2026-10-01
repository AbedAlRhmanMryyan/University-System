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
  
    public partial class UserControl1 : UserControl
    {
        public bool b1=false;

        public static UserControl1 usercontrol;
        public Label l1;
        public  Label l2;
        public Label l3;
        public Panel p1;
        public Panel p2;
        public Panel p3;
        public UserControl1()
        {
            InitializeComponent();

            usercontrol = this;
            l1 = this.label1;
            l2 = this.label3;
            l3 = this.label2;
            p1 = this.panel1;
            p2 = this.panel2;
            p3 = this.panel3;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1 = true;   
        }
    }
}
