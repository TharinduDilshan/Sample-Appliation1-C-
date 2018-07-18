using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TestProgram
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Starting the application");
            System.Console.WriteLine("************************" + "\n");

            Student st1 = new Student("Tharindu", "sample1@gmail.com", "071*******", "201*", "Software Engineering");
            Teacher t1 = new Teacher("Dilshan", "sample2@gmail.com", "071*******", "201*");

            System.Console.WriteLine("************************");
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine("************************" + "\n");

            System.Console.WriteLine("Student ID: "+st1.getStudentID());
            System.Console.WriteLine("Student Name: "+st1.getName());
            System.Console.WriteLine("Student Email: "+st1.getEmail());
            System.Console.WriteLine("Student Contact: "+st1.getContact());
            System.Console.WriteLine("Student Course: "+st1.getCourse());

            System.Console.WriteLine("************************");
            System.Console.WriteLine("Teacher Details");
            System.Console.WriteLine("************************" + "\n");

            System.Console.WriteLine("Teacher Em ID: "+t1.getEmployeeID());
            System.Console.WriteLine("Teacher Name: "+t1.getName());
            System.Console.WriteLine("Teacher Email: "+t1.getEmail());
            System.Console.WriteLine("Teacher Contact: "+t1.getContact());

            System.Console.WriteLine("************************" + "\n");

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();






        }
    }
}
