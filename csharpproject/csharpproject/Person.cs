using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
   public class Person
    {
        public string username;
        public string email;
        public string password;
        public string nid;
        public string passportid;
        public int age;
        public string gender;

        public Person(string username, string email, string password, string nid, string passportid, int age, string gender)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.nid = nid;
            this.passportid = passportid;
            this.age = age;
            this.gender = gender;

        }

    }
}
