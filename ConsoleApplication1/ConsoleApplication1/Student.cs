using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student :StudentTeacher
    {
        public string StudentID;//{ get; set; }
        public string Course;//{ get; set; }

        public Student(string Name, string Email, string Contact, string StudentID, string Course)
            : base(Name, Email, Contact)
        {
            this.StudentID = StudentID;
            this.Course = Course;
        }

        public string getStudentID()
        {
            return StudentID;
        }

        public void setStudentID(string StudentID)
        {
            this.StudentID = StudentID;
        }

        public string getCourse()
        {
            return Course;
        }

        public void setCourse(string Course)
        {
            this.Course = Course;
        }


    }
}
