namespace ClassLibrary1.user_control
{
    partial class message_user_control_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(message_user_control_1));
            this.teacher = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.White;
            this.teacher.Location = new System.Drawing.Point(135, 44);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(97, 17);
            this.teacher.TabIndex = 19;
            this.teacher.Text = "Course Name";
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.Color.White;
            this.coursename.Location = new System.Drawing.Point(135, 9);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(97, 17);
            this.coursename.TabIndex = 13;
            this.coursename.Text = "Course Name";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.SteelBlue;
            this.message.Location = new System.Drawing.Point(13, 115);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(67, 15);
            this.message.TabIndex = 21;
            this.message.Text = "Teacher :";
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // message_user_control_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.message);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "message_user_control_1";
            this.Size = new System.Drawing.Size(237, 215);
            this.Load += new System.EventHandler(this.message_user_control_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
