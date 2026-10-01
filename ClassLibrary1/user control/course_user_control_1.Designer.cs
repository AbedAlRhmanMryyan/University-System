namespace ClassLibrary1.user_control
{
    partial class course_user_control_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course_user_control_1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coursename = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.credithours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(472, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coursename.Location = new System.Drawing.Point(3, 38);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(117, 25);
            this.coursename.TabIndex = 6;
            this.coursename.Text = "course name";
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachername.ForeColor = System.Drawing.Color.SteelBlue;
            this.teachername.Location = new System.Drawing.Point(141, 33);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(75, 25);
            this.teachername.TabIndex = 7;
            this.teachername.Text = "teacher";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.ForeColor = System.Drawing.Color.SteelBlue;
            this.capacity.Location = new System.Drawing.Point(230, 33);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(82, 25);
            this.capacity.TabIndex = 8;
            this.capacity.Text = "capacity";
            // 
            // credithours
            // 
            this.credithours.AutoSize = true;
            this.credithours.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credithours.ForeColor = System.Drawing.Color.SteelBlue;
            this.credithours.Location = new System.Drawing.Point(330, 31);
            this.credithours.Name = "credithours";
            this.credithours.Size = new System.Drawing.Size(110, 25);
            this.credithours.TabIndex = 9;
            this.credithours.Text = "credit hours";
            // 
            // course_user_control_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.credithours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "course_user_control_1";
            this.Size = new System.Drawing.Size(564, 86);
            this.Load += new System.EventHandler(this.course_user_control_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Label teachername;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label credithours;
    }
}
