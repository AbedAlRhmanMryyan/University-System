using ClassLibrary1.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;



namespace ClassLibrary1
{
    public class Class1
    {

        [STAThread]
        static void Main(string[] args)
        {
            splash_screen sp=new splash_screen();
            sp.ShowDialog();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

    }

    [Serializable]
    public class student
    {
        string student_name = "";
        string student_username = "";
        string student_password = "";
        string student_picture = "";
        string student_file = "student.txt";
        int student_total_ch = 0;
        float student_GPA;
        bool student_is_active = true;
        string date_of_birth = "";

        //************************ setters ***************************
        public void set_student_name(string student_name) { this.student_name = student_name; }
        public void set_student_picture(string picture) { this.student_picture = picture; }
        public void set_student_username(string student_username) { this.student_username = student_username; }
        public void set_student_password(string student_password) { this.student_password = student_password; }
        public void set_student_file(string student_file) { this.student_file = student_file; }
        public void set_student_total_ch(int total_ch) { this.student_total_ch += total_ch; }
        public void set_student_total_ch2(int total_ch) { this.student_total_ch = total_ch; }
        public void set_student_GPA(float GPA) { this.student_GPA = GPA; }
        
        public void set_student_active(bool student) { this.student_is_active = student; }
        public void set_student_date_of_birth(string date) { this.date_of_birth = date; }

        //************************ getters ***************************
     
        public bool comparestudent(student student1, student student2) 
        {
            if (student1.get_student_name() != student2.get_student_name()) 
            { return true; }
            return false;
        }
      
        public string get_student_date_of_birth() { return this.date_of_birth; }
        public string get_student_name() { return student_name; }
        public string get_student_username() { return student_username; }
        public string get_student_password() { return student_password; }
        public string get_student_username_1() { return student_username; }
        public string get_student_password_1() { return student_password; }
        public float get_student_GPA() { return student_GPA; }
        public bool get_student_active() { return student_is_active; }
        public int get_student_total_ch() { return student_total_ch; }
        public string get_student_filename() { return student_file; }
        public string get_student_picture() { return student_picture; }

        //************************ send to file ***********************
        public void send_student_tofile()
        {
            FileStream fs1 = new FileStream(student_file, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs1, this);
            fs1.Close();
        }
        //************************ get from file **********************
        public student get_student_fromfile(string student_name)
        {
            FileStream fs1 = new FileStream(student_file, FileMode.Open, FileAccess.Read);
            student[] s1 = new student[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                s1[i++] = (student)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (s1[y].get_student_name() == student_name) { return s1[y]; }
            }
            return null;


        }
        //************************ EDIT S **********************

        public void edit_student(string student_name = "", string student_username = "", string student_password = "", float student_gpa = 0,
            int student_total_ch = 0, string student_filename = "", bool student_active = false)
        {

            FileStream fs1 = new FileStream(student_file, FileMode.Open, FileAccess.Read);
            student[] s1 = new student[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                s1[i++] = (student)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (s1[y].get_student_name() == student_name)
                {
                    if (student_name != "")
                    {
                        s1[y].set_student_name(student_name);
                    }
                    else if (student_username != "")
                    {
                        s1[y].set_student_username(student_username);
                    }
                    else if (student_password != "")
                    {
                        s1[y].set_student_password(student_password);
                    }
                    else if (student_file != "")
                    {
                        s1[y].set_student_file(student_filename);
                    }
                    else if (student_active != false)
                    {
                        s1[y].set_student_active(student_active);
                    }
                    else if (student_gpa != 0)
                    {
                        s1[y].set_student_GPA(student_gpa);
                    }
                    else if (student_total_ch != 0)
                    {
                        s1[y].set_student_total_ch(student_total_ch);
                    }

                }
            }
            FileStream fs2 = new FileStream(student_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf1 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf.Serialize(fs2, s1[y]);
            }
            fs2.Close();

        }
        public void edit_student_v3(student sg)
        {
            FileStream fs1 = new FileStream(student_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            student[] v = new student[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                v[i++] = (student)bf1.Deserialize(fs1);

            }
            fs1.Close();
            int o = 0;
            student[] v1 = new student[i];
            for (int y = 0; y < i; y++)
            {
                if (sg.get_student_username() != v[y].get_student_username())
                {
                    v1[y] = v[y];
                    o++;
                }
                else
                {
                    v1[o] = sg;
                }
            }
            FileStream fs2 = new FileStream(student_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf2.Serialize(fs2, v1[y]);
            }
            fs2.Close();

        }
        public student[] ReturnAllStudentFromFile() 
        {
            if (File.Exists(student_file))
            {
                FileStream fs1 = new FileStream(get_student_filename(), FileMode.Open, FileAccess.Read);
                BinaryFormatter bf1 = new BinaryFormatter();
                int i = 0;
                student[] s = new student[fs1.Length];
                while (fs1.Position < fs1.Length)
                {
                    s[i++] = (student)bf1.Deserialize(fs1);
                }
                fs1.Close();

                return s;
            }
            else { return null; }
        }
        public int ReturnAllStudentCountFromFile()
        {
            if (File.Exists(student_file)) { 
                FileStream fs1 = new FileStream("student.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            int i = 0;
            student[] s = new student[fs1.Length];
            while (fs1.Position < fs1.Length)
            {
                s[i++] = (student)bf1.Deserialize(fs1);
            }
            fs1.Close();

            return i;
        }
            else { return 0; }
          
        }


    }


    [Serializable]
    public class teacher
    {
        string teacher_name;
        string teacher_username;
        string teacher_password;
        string teacher_file = "teacher.txt";
        //************************ setters ***************************
        public void set_teacher_name(string teacher_name) { this.teacher_name = teacher_name; }
        public void set_teacher_username(string teacher_username) { this.teacher_username = teacher_username; }
        public void set_teacher_password(string teacher_password) { this.teacher_password = teacher_password; }
        public void set_teacher_file(string teacher_file) { this.teacher_file = teacher_file; }

        //************************ getters ***************************
        public string get_teacher_name() { return this.teacher_name; }
        public string get_teacher_username() { return this.teacher_username; }
        public string get_teacher_password() { return this.teacher_password; }
        public string get_teacher_file() { return this.teacher_file; }
        //************************ send to file *************************
        public void send_teacher_tofile()
        {
            FileStream fs1 = new FileStream(teacher_file, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs1, this);
            fs1.Close();

        }
        //************************ get from file *************************
        public teacher get_teacher_fromfile(string teacher_name)
        {
            FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
            teacher[] t1 = new teacher[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                t1[i++] = (teacher)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (t1[y].get_teacher_username() == teacher_name) 
                { return t1[y]; }
                
            }
            return null;
        }
        public bool get_teacher_fromfile_v2(string teacher_name)
        {
            FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
            teacher[] t1 = new teacher[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                t1[i++] = (teacher)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (t1[y].get_teacher_username() == teacher_name)
                { return true; }

            }
            return false;
        }
        //************************ EDIT C **********************
        public void edit_teacher(string teacher_name = "", string teacher_username = "", string teacher_password = "", string teacher_file = "")
        {
            FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
            teacher[] t1 = new teacher[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                t1[i++] = (teacher)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (t1[y].get_teacher_username() == teacher_username)
                {
                    if (teacher_name != "")
                    {
                        t1[y].set_teacher_name(teacher_name);
                    }
                    else if (teacher_username != "")
                    {
                        t1[y].set_teacher_username(teacher_name);
                    }
                    else if (teacher_password != "")
                    {
                        t1[y].set_teacher_password(teacher_name);
                    }
                    else if (teacher_file != "")
                    {
                        t1[y].set_teacher_file(teacher_name);
                    }

                }

            }
            FileStream fs2 = new FileStream(teacher_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf1 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf.Serialize(fs2, t1[y]);
            }
            fs2.Close();
        }
        public teacher[] Return_all_teacher_array() 
        {
            if (File.Exists(teacher_file))
            {
                FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
                teacher[] t1 = new teacher[fs1.Length];
                BinaryFormatter bf = new BinaryFormatter();
                int i = 0;
                while (fs1.Position < fs1.Length)
                {

                    t1[i++] = (teacher)bf.Deserialize(fs1);
                }
                fs1.Close();
                return t1;
            }
          return null;
              
            
        }
        public int Return_all_teacher_array_count()
        {
            int i1 = 0;
            if (File.Exists(teacher_file))
            {
                FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
                teacher[] t1 = new teacher[fs1.Length];
                BinaryFormatter bf = new BinaryFormatter();
                int i = 0;
                while (fs1.Position < fs1.Length)
                {

                    t1[i++] = (teacher)bf.Deserialize(fs1);
                }
                fs1.Close();
                return i;
            }
            return i1;
        }
        public void edit_teacher_v2(teacher t) 
        {
            FileStream fs1 = new FileStream(teacher_file, FileMode.Open, FileAccess.Read);
            teacher[] t1 = new teacher[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                t1[i++] = (teacher)bf.Deserialize(fs1);
            }
            fs1.Close();
            teacher[] v1 = new teacher[i];
            int o=0;
            for (int y = 0; y < i; y++)
            {
                if (t.get_teacher_username() != t1[y].get_teacher_username())
                {
                    v1[y] = t1[y];
                    o++;
                }
                else
                {
                    v1[o] = t;
                }
            }

            FileStream fs2 = new FileStream(teacher_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf1 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf.Serialize(fs2, v1[y]);
            }
            fs2.Close();

        }
    }
    [Serializable]
    public class grade
    {
        string course_name;
        string grade_file = "grade.txt";
        string student_1;
        string teacher_1;
        double grade1=0;
        student s;
       
        //************************ setters ***************************
        public void set_course_name(string course_name1) 
        { course_name = course_name1;}
        public void set_student_name(string student_1) 
        { this.student_1 = student_1;}
        public void set_teacher_name(string teacher)
        { this.teacher_1 =   teacher;}
        public void set_grade_2(float grade_2) { grade1 = grade_2; }
        public void set_grade(float grade,student s,course c)
        {//(old GPA * old Total credit hours) + (new grade * credit hours of the new course) /
         //   accumulated total credit hours.
            if (grade > 0.5) 
            {
                float cf = ((s.get_student_GPA() * s.get_student_total_ch()) + (grade * c.get_ch_hours())) / (s.get_student_total_ch() + c.get_ch_hours());
                s.set_student_GPA(cf);
                s.set_student_total_ch(c.get_ch_hours()+s.get_student_total_ch());
                s.edit_student_v3(s);
            }
            else { MessageBox.Show("You cant add this grade because its below the 0.5"); }
        }
        //************************ getters ***************************
        public string get_course_name()
        { return course_name; }
        public string get_student_name()
        { return student_1; }
        public string get_teacher_name()
        { return teacher_1; }
        public double get_grade_2() { return grade1; }
        public string get_grade_file() { return grade_file; }
        //************************ send to file **********************
        public void send_grade_tofile() 
        {
            FileStream fs1=new FileStream(grade_file,FileMode.Append,FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs1,this);
            fs1.Close();
        }
        //************************ get from file ********************
        public grade[] get_grade_fromfile_t(string teacher_name) 
        {
            FileStream fs1=new FileStream(grade_file, FileMode.Open,FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            grade[] grades = new grade[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                grades[i++]=(grade)bf.Deserialize(fs1);
            }
            fs1.Close();
            int r = 0;
            for (int y = 0; y < i; y++) 
            {
                if (grades[y].get_teacher_name() == teacher_name) 
                {
                    r++;
                }
            }
            grade[] p = new grade[r];
            int r2=0;
            for (int y = 0; y < i; y++)
            {
                if (grades[y].get_teacher_name() == teacher_name)
                {
                    p[r2++] = grades[y];
                }
            }
           return p; 
         
        }
        public grade[] get_grade_fromfile_s(string studen) 
        {
            FileStream fs1 = new FileStream(grade_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            grade[] grades = new grade[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                grades[i++] = (grade)bf.Deserialize(fs1);
            }
            fs1.Close();
            int r = 0;
            for (int y = 0; y < i; y++)
            {
                if (grades[y].get_student_name() == studen)
                {
                    r++;
                }
            }
            grade[] p = new grade[r];
            int r2 = 0;
            for (int y = 0; y < i; y++)
            {
                if (grades[y].get_student_name() == studen)
                {
                    p[r2++] = grades[y];
                }
            }
            if (p != null) { return p; }
            return null;

        }
    }

    [Serializable]
    public class course
    {
        string course_name;
        int ch_hours;
        int capacity=0;
        string teacher_name;
        int num_of_students = 0;
        string course_file = "course.txt";
        List<student> students = new List<student>();
        //************************ setters ***************************\
        public void set_course_numofstudents(int numof_students) { num_of_students += numof_students; }
        public void set_course_name(string c_name) { course_name = c_name; ; }
        public void set_ch_hourse(int ch_hour) { ch_hours = ch_hour; }
        public void set_capacity(int capacity) { this.capacity = capacity; }
        public void set_array_of_student(student[] bh) 
        {
       students= bh.ToList();
        }
        public void set_students(student s) 
        { 
            if (students.Count >= capacity) 
            {
                MessageBox.Show("too many students");
            }
            else 
            {
            students.Add(s);
                capacity++;
            }
        }
   

        /*must edit this function with teacher class*/
        public void set_teacher_name(string t_name)
        {
            teacher t1 = new teacher();
         
              if (File.Exists(t1.get_teacher_file()))
              {
                  if (t1.get_teacher_fromfile_v2(t_name))
                  {
                 
                      teacher_name = t_name; 
                  }

              }
              else { MessageBox.Show("No Teacher Found"); }

        }
        public void set_course_file_name(string c_file_name) { course_file = c_file_name; }

        //************************ getters ***************************
        public int get_course_numofstudents() { return num_of_students; }
        public List<student> get_students() { return students; }
        public string get_course_name() { return course_name; }
        public int get_ch_hours() { return ch_hours; }
        public int get_capacity() { return capacity; }
        public string get_teacher_name() { return teacher_name; }
        public string get_course_file_name() { return course_file; }
        //************************ send to file ***********************
        public void send_course_tofile()
        {
            FileStream fs1 = new FileStream(course_file, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs1, this);
            fs1.Close();
        }
        //************************ get from file **********************
     

        
        public course get_course_fromfile(string course_name)
        {


            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            course[] c1 = new course[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                c1[i++] = (course)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (c1[y].get_course_name() == course_name) { return c1[y]; }
            }
            return null;
        }
        public course[] get_teacher_from_course_fromfile(string tech)
        {


            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            course[] c1 = new course[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                c1[i++] = (course)bf.Deserialize(fs1);
            }
            fs1.Close();
            int h = 0;
            int h2 = 0;
         
            for (int y = 0; y < i; y++)
            {
                if (c1[y].get_teacher_name() == tech) 
                {
                    h2++;
                }
            }

            if (h2 != 0) 
            {
                course[] cvb = new course[h2];
                for (int y = 0; y < i; y++)
                {
                    if (c1[y].get_teacher_name() == tech)
                    {
                        cvb[h++] = c1[y];
                    }
                }
                return cvb;
            }

            return null;
        }
        public int get_count_teacher_from_course_fromfile(string tech)
        {


            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            course[] c1 = new course[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                c1[i++] = (course)bf.Deserialize(fs1);
            }
            fs1.Close();
            int h = 0;
            int h2 = 0;

            for (int y = 0; y < i; y++)
            {
                if (c1[y].get_teacher_name() == tech)
                {
                    h2++;
                }
            }

            if (h2 != 0)
            {
                course[] cvb = new course[h2];
                for (int y = 0; y < i; y++)
                {
                    if (c1[y].get_teacher_name() == tech)
                    {
                        cvb[h++] = c1[y];
                    }
                }
                return h;
            }

            return 0;
        }
        public course[] get_student_from_course_fromfile(string studn)
        {


            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            course[] c1 = new course[fs1.Length];

            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                c1[i++] = (course)bf.Deserialize(fs1);
            }
            fs1.Close();
            int h = 0;
            int h2 = 0;
            int cx = 0;
            bool zxvv=false;
            for (int y = 0; y < i; y++)
            {
              
                student[] bv;
                bv= c1[y].get_students().ToArray();
                for (int u = 0; u < c1[y].get_students().Count; u++)
                {
                    zxvv = false;
                    if (bv[u].get_student_name() == studn)
                    {
                        zxvv = true;
                    }
                    if (zxvv == true) 
                    {
                        break;
                    }
                }
                if (zxvv == true)
                {
                    h2++;
                }

            }
            course[]m=new course[h2];
            int q = 0;
            for (int y = 0; y < i; y++)
            {

                student[] bv;
                bv = c1[y].get_students().ToArray();
                for (int u = 0; u < c1[y].get_students().Count; u++)
                {
                    zxvv = false;
                    if (bv[u].get_student_name() == studn)
                    {
                        zxvv = true;
                    }
                    if (zxvv == true)
                    {
                        break;
                    }
                }
                if (zxvv == true)
                {
                    m[q++] = c1[y];
                }

            }
            if (m != null) 
            {
                return m;
            }


            return null;
        }
        public course[] get_all_course_array_fromfile()
        {

            if (File.Exists(course_file))
            {
                FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
                course[] c1 = new course[fs1.Length];
                BinaryFormatter bf = new BinaryFormatter();
                int i = 0;
                while (fs1.Position < fs1.Length)
                {

                    c1[i++] = (course)bf.Deserialize(fs1);
                }
                fs1.Close();

                return c1;
            }
            return null;
        }
        public int get_all_course_array_count_fromfile()
        {

            if (File.Exists(course_file))
            {
                FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
                course[] c1 = new course[fs1.Length];
                BinaryFormatter bf = new BinaryFormatter();
                int i = 0;
                while (fs1.Position < fs1.Length)
                {

                    c1[i++] = (course)bf.Deserialize(fs1);
                }
                fs1.Close();

                return i;
            }
            return 0;
        }
        //************************ EDIT C **********************
        public void edit_course_v2(course sg)
        {
            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            course[] v = new course[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                v[i++] = (course)bf1.Deserialize(fs1);

            }
            fs1.Close();
            int o = 0;
            course[] v1 = new course[i];
            for (int y = 0; y < i; y++)
            {
                if (sg.get_course_name() != v[y].get_course_name())
                {
                    v1[y] = v[y];
                    o++;
                }
                else
                {
                    v1[o] = sg;
                }
            }
            FileStream fs2 = new FileStream(course_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf2.Serialize(fs2, v1[y]);
            }
            fs2.Close();

        }
        public void edit_course(string course_name, int i1 = 0, int i2 = 0, string s1 = "", string s2 = "")
        {
            FileStream fs1 = new FileStream(course_file, FileMode.Open, FileAccess.Read);
            course[] c1 = new course[fs1.Length];
            BinaryFormatter bf = new BinaryFormatter();
            int i = 0;
            while (fs1.Position < fs1.Length)
            {

                c1[i++] = (course)bf.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (c1[y].get_course_name() == course_name)
                {
                    if (i1 != 0)
                    {
                        c1[y].set_ch_hourse(i1);
                    }
                    else if (i2 != 0)
                    {
                        c1[y].set_capacity(i2);
                    }
                    else if (s1 != "")
                    {
                        c1[y].set_teacher_name(s1);
                    }
                    else if (s2 != "")
                    {
                        c1[y].set_course_name(s2);
                    }


                }
            }
            FileStream fs2 = new FileStream(course_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf1 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf.Serialize(fs2, c1[y]);
            }
            fs1.Close();

        }
    }



    [Serializable]
    /*
      
       7. Add new course =====================================
       8. Add student and teacher to a course ================
       9. View full information of all things ================
       10. Enable/Disable student account ====================

     */
    class admin
    {
        string admin_username = "";
        string admin_password = "";
        string admin_file = "admin.txt";
        //************************ setters ***************************
        public void set_admin_username(string user) { this.admin_username = user; }
        public void set_admin_password(string password) { this.admin_password = password; }
        //************************ getters ***************************
        public string get_admin_username() { return this.admin_username; }
        public string get_admin_password() { return this.admin_password; }
        public string get_admin_file() { return this.admin_file; }
        //************************ send to file ************************
        public void send_admin_to_file()
        {
            FileStream fs1 = new FileStream(this.admin_file, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs1, this);
            fs1.Close();
        }
        //************************ get from file ***********************
        public admin get_admin_fromfile(string admin_name)
        {
            FileStream fs1 = new FileStream(this.admin_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            admin[] a2 = new admin[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                a2[i++] = (admin)bf1.Deserialize(fs1);
            }
            fs1.Close();
            for (int y = 0; y < i; y++)
            {
                if (admin_name == a2[y].get_admin_username())
                { return a2[y]; }
            }
            return null;
        }
        //************************ edit admin ***********************
        public void edit_admin(admin a)
        {
            FileStream fs1 = new FileStream(this.admin_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            admin[] a2 = new admin[fs1.Length];
            admin[] a3 = new admin[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                a2[i++] = (admin)bf1.Deserialize(fs1);
            }
            fs1.Close();
            int p = 0;
            for (int y = 0; y < i; y++)
            {
                if (a2[y].get_admin_username() != a.get_admin_username())
                {
                    a3[y] = a2[y];
                }
                else if (a2[y].get_admin_username() == a.get_admin_username()) { p = y; }
            }
            if (p != 0)
            {
                a3[p] = a;
            }
            FileStream fs2 = new FileStream(this.admin_file, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();
            for (int y = 0; y < i; y++)
            {
                bf1.Serialize(fs2, a3[y]);
            }
            fs2.Close();

        }
    }
        [Serializable]
       public class messages 
        {
        string teacher_massages;
        string course_messages;
        string message;
        string message_file = "message.txt";
        //************************ setters ***************************
        public void set_teacher_massages(string teacher_m) 
        {
                teacher t1=new teacher();
            
                if(t1.get_teacher_fromfile(teacher_m) != null)
                teacher_massages = teacher_m;
                

           
        }
        public void set_message(string m) {  message = m; }
        public void set_course_messages(string c_m) {  course_messages = c_m; }
        //************************ getters ***************************
        public string get_teacher_massages() { return teacher_massages; }
        public string get_course_messages() { return course_messages; }
        public string get_message() { return message; }
        //************************ send to file **********************
        public void send_message_tofile() 
        {
            FileStream fs1=new FileStream(message_file, FileMode.Append, FileAccess.Write);
            BinaryFormatter bf1=new BinaryFormatter();
            bf1.Serialize(fs1, this);
            fs1.Close();
        
        }
        //************************ get from file *********************
        public messages[] get_message_fromfile() 
        {
            FileStream fs1 = new FileStream(message_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            messages[]m=new messages[fs1.Length];
            int i = 0;
            while(fs1.Position < fs1.Length) 
            {
                m[i++]=(messages)bf1.Deserialize(fs1);
            }
            fs1.Close();
            return m;
       
        }
        public messages[] get_message_fromfile(string course_name) 
        {
            FileStream fs1 = new FileStream(message_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            messages[] m = new messages[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                m[i++] = (messages)bf1.Deserialize(fs1);
            }
            fs1.Close();
            int k = 0;
            messages[] m1 = new messages[i]; 
            for (int y = 0; y < i; y++) 
            {
                if (m[y].get_course_messages() == course_name) 
                {
                    m1[k++]=m[y];
                }
            }
            if(k != 0) { return m1;}
            return null;
        }
        public int get_message_fromfile_count(string course_name)
        {
            FileStream fs1 = new FileStream(message_file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            messages[] m = new messages[fs1.Length];
            int i = 0;
            while (fs1.Position < fs1.Length)
            {
                m[i++] = (messages)bf1.Deserialize(fs1);
            }
            fs1.Close();
            int k = 0;
            messages[] m1 = new messages[i];
            for (int y = 0; y < i; y++)
            {
                if (m[y].get_course_messages() == course_name)
                {
                    m1[k++] = m[y];
                }
            }
            if (k != 0) { return k; }
            return 0;
        }
    }

    public class MakeMovable
        {
            private Form form;
            private bool _dragging = false;
            private Point _start_point = new Point(0, 0);

            public MakeMovable(Form form)
            {
                this.form = form;
            }

            public void SetMovable(params Control[] controls)
            {
                foreach (Control control in controls)
                {
                    control.MouseDown += new MouseEventHandler(_MouseDown);
                    control.MouseUp += new MouseEventHandler(_MouseUp);
                    control.MouseMove += new MouseEventHandler(_MouseMove);
                }
            }

            private void _MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    _dragging = true;
                    _start_point = new Point(e.X, e.Y);
                }

            }

            private void _MouseUp(object sender, MouseEventArgs e)
            {
                _dragging = false;
            }

            private void _MouseMove(object sender, MouseEventArgs e)
            {
                if (_dragging)
                {
                    Point p = form.PointToScreen(e.Location);
                    form.Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
                }
            }
        }
    }


