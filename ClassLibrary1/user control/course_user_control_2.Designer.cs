namespace ClassLibrary1.user_control
{
    partial class course_user_control_2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course_user_control_2));
            this.coursename = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.credithours = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.Color.White;
            this.coursename.Location = new System.Drawing.Point(129, 10);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(97, 17);
            this.coursename.TabIndex = 1;
            this.coursename.Text = "Course Name";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.ForeColor = System.Drawing.Color.White;
            this.capacity.Location = new System.Drawing.Point(129, 41);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(97, 17);
            this.capacity.TabIndex = 3;
            this.capacity.Text = "Course Name";
            // 
            // credithours
            // 
            this.credithours.AutoSize = true;
            this.credithours.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credithours.ForeColor = System.Drawing.Color.White;
            this.credithours.Location = new System.Drawing.Point(129, 73);
            this.credithours.Name = "credithours";
            this.credithours.Size = new System.Drawing.Size(97, 17);
            this.credithours.TabIndex = 5;
            this.credithours.Text = "Course Name";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.White;
            this.teacher.Location = new System.Drawing.Point(129, 105);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(97, 17);
            this.teacher.TabIndex = 7;
            this.teacher.Text = "Course Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // course_user_control_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.credithours);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "course_user_control_2";
            this.Size = new System.Drawing.Size(237, 219);
            this.Load += new System.EventHandler(this.course_user_control_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label credithours;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
