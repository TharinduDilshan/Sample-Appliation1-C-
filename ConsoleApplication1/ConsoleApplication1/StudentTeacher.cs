using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //StuudentTeacher (Parent Class)
    class StudentTeacher
    {
        private string Name;//{ get; set; }
        private string Email;//{ get; set; }
        private string Contact;//{ get; set; }

        public StudentTeacher()
        {

        }

        public StudentTeacher(string Name, string Email, string Contact)
        {
            this.Name = Name;
            this.Email = Email;
            this.Contact = Contact;
        }


        public string getName()
        {
            return Name;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getContact()
        {
            return Contact;
        }

        public void setContact(string Contact)
        {
            this.Contact = Contact;
        }
    }
}
