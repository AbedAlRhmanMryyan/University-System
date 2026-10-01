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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 600) 
            {
                timer1.Stop();
                this.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
