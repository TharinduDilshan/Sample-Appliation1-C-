using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestProgram
    {

        public static void Main(string[] args)
        {

           // ArrayList studentList = new ArrayList();
            List<Teacher> teacherList = new List<Teacher>();
            List<Student> studentList = new List<Student>();


            Student st1 = new Student("Tharindu", "sample1@gmail.com", "071*******", "201*", "Software Engineering");
            Student st2 = new Student("Tharindu", "sample1@gmail.com", "071*******", "201*", "Software Engineering");
            Student st3 = new Student("Tharindu", "sample1@gmail.com", "071*******", "201*", "Software Engineering");
            Teacher t1 = new Teacher("Dilshan", "sample2@gmail.com", "071*******", "201*");
            Teacher t2 = new Teacher("Dilshan", "sample2@gmail.com", "071*******", "201*");
            Teacher t3 = new Teacher("Dilshan", "sample2@gmail.com", "071*******", "201*");

            studentList.Add(st1);
            studentList.Add(st2);
            studentList.Add(st3);

            teacherList.Add(t1);
            teacherList.Add(t2);
            teacherList.Add(t3);

            Console.WriteLine("Starting the application");
            System.Console.WriteLine("************************" + "\n");

           
            System.Console.WriteLine("************************");
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine("************************" + "\n");

            /*
            System.Console.WriteLine("Student ID: "+st1.getStudentID());
            System.Console.WriteLine("Student Name: "+st1.getName());
            System.Console.WriteLine("Student Email: "+st1.getEmail());
            System.Console.WriteLine("Student Contact: "+st1.getContact());
            System.Console.WriteLine("Student Course: "+st1.getCourse());
            System.Console.WriteLine("************************" + "\n");
            */

            for (int i = 0; i < studentList.Count; i++)
            {
                System.Console.WriteLine("Index: "+ i);
                System.Console.WriteLine("Student ID: "+ studentList[i].getStudentID());
                System.Console.WriteLine("Student Name: "+ studentList[i].getName());
                System.Console.WriteLine("Student Email: " + studentList[i].getEmail());
                System.Console.WriteLine("Student Contact: " + studentList[i].getContact());
                System.Console.WriteLine("Student Course: " + studentList[i].getCourse());
                System.Console.WriteLine("************************" + "\n");
            }

            

            System.Console.WriteLine("************************");
            System.Console.WriteLine("Teacher Details");
            System.Console.WriteLine("************************" + "\n");

            /*
            System.Console.WriteLine("Teacher Em ID: "+t1.getEmployeeID());
            System.Console.WriteLine("Teacher Name: "+t1.getName());
            System.Console.WriteLine("Teacher Email: "+t1.getEmail());
            System.Console.WriteLine("Teacher Contact: "+t1.getContact());
            System.Console.WriteLine("************************" + "\n");
            */

            for (int i = 0; i < teacherList.Count; i++)
            {
                System.Console.WriteLine("Index: " + i);
                System.Console.WriteLine("Teacher Em ID: " + teacherList[i].getEmployeeID());
                System.Console.WriteLine("Teacher Name: " + teacherList[i].getName());
                System.Console.WriteLine("Teacher Email: " + teacherList[i].getEmail());
                System.Console.WriteLine("Teacher Contact: " + teacherList[i].getContact());
                System.Console.WriteLine("************************" + "\n");
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();






        }
    }
}
