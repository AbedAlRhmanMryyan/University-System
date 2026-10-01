namespace ClassLibrary1.user_control
{
    partial class grade_user_control_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grade_user_control_1));
            this.teacher = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacher.Location = new System.Drawing.Point(320, 12);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(70, 25);
            this.teacher.TabIndex = 1;
            this.teacher.Text = "label2";
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coursename.Location = new System.Drawing.Point(153, 17);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(52, 18);
            this.coursename.TabIndex = 3;
            this.coursename.Text = "label4";
            this.coursename.Click += new System.EventHandler(this.label4_Click);
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grade.Location = new System.Drawing.Point(486, 12);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(70, 25);
            this.grade.TabIndex = 5;
            this.grade.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grade_user_control_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.grade);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.pictureBox1);
            this.Name = "grade_user_control_1";
            this.Size = new System.Drawing.Size(626, 51);
            this.Load += new System.EventHandler(this.grade_user_control_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
