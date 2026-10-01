namespace ClassLibrary1.user_control
{
    partial class course_user_control_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course_user_control_3));
            this.teacher = new System.Windows.Forms.Label();
            this.credithours = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.rjButton2 = new ClassLibrary1.RJButton();
            this.rjButton1 = new ClassLibrary1.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.White;
            this.teacher.Location = new System.Drawing.Point(132, 67);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(97, 17);
            this.teacher.TabIndex = 19;
            this.teacher.Text = "Course Name";
            // 
            // credithours
            // 
            this.credithours.AutoSize = true;
            this.credithours.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credithours.ForeColor = System.Drawing.Color.White;
            this.credithours.Location = new System.Drawing.Point(132, 38);
            this.credithours.Name = "credithours";
            this.credithours.Size = new System.Drawing.Size(97, 17);
            this.credithours.TabIndex = 17;
            this.credithours.Text = "Course Name";
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.Color.White;
            this.coursename.Location = new System.Drawing.Point(132, 11);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(97, 17);
            this.coursename.TabIndex = 13;
            this.coursename.Text = "Course Name";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Pink;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Pink;
            this.rjButton2.BorderColor = System.Drawing.Color.White;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(132, 91);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(97, 25);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.Text = "SHOW";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(11, 134);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(219, 41);
            this.rjButton1.TabIndex = 23;
            this.rjButton1.Text = "SELECT";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // course_user_control_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.credithours);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "course_user_control_3";
            this.Size = new System.Drawing.Size(237, 191);
            this.Load += new System.EventHandler(this.course_user_control_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label credithours;
        private System.Windows.Forms.Label coursename;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
