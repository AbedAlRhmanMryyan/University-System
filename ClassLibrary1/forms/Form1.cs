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
   
    public partial class Form1 : Form
    {
  
        private MakeMovable _move;


        public static Form1 here1;
        public Panel panel12;
        public Button Button1;
        public Button Button2;
        public Button Button3;
        public Panel panel13;
        public Panel panel222;
        public Form1()
        {
            InitializeComponent();
            _move = new MakeMovable(this);
            _move.SetMovable(flowLayoutPanel1);
            DoubleBuffered = true;
            panel222 = this.panel3;
            panel13 = this.flowLayoutPanel1;
            here1 =this;
            panel12 = this.panel3;
            Button1 = this.button1;
            Button2 = this.button2;
            Button3 = this.button3;
            Form2 g=new Form2();
            g.TopLevel = false;
            g.TopMost = false;
            this.panel3.Controls.Add(g);
          
            g.Dock = DockStyle.Fill;
            g.Show();
        }
     
       /* protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        /* private const int cs_dropshodow = 0x00020000;
         protected override CreateParams CreateParams
         {
             get
             {
                 CreateParams cp = new CreateParams();
                 cp.ClassStyle |=cs_dropshodow;
                 return cp;
             }
         }*/
        public void hide_all() 
        {
            

        }
        public void load_form_into_panel(Form a) 
        {
         
            panel3.Controls.Clear();
            panel3.Controls.Add(a);
            
        
        }
        public void clear_panel()
        {

            panel3.Controls.Clear();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.TopMost = false;
            panel3.Controls.Add(form3);
            form3.Show();
          
        }

        public void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form3 form2 = new Form3();
            form2.TopLevel = false;
            form2.TopMost = false;

            panel3.Controls.Add(form2);

            form2.Show();
            
        }

        public void button7_Click(object sender, EventArgs e)
        {
          

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button6_Click(object sender, EventArgs e)
        {

        }

        public bool return_panel_status() 
        {
        if(panel3.Controls.Count == 0)  
                return true;
        return false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
