using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Teacher : StudentTeacher
    {
        private string EmployeeID;//{ get; set; }

        public Teacher(string Name, string Email, string Contact, string EmployeeID)
            : base(Name, Email, Contact)
        {
            this.EmployeeID = EmployeeID;
        }

        public string getEmployeeID()
        {
            return EmployeeID;
        }

        public void setEmployeeID(string EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }
    }
}
