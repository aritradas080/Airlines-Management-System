using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
     abstract class Employee
    {
        public string name;
        public int id;
        public int age;
        public string Gender;
        public string bloodGroup;
        public string shift;

        public Employee(string name, int id, int age, string Gender, string bloodGroup, string shift)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.Gender = Gender;
            this.bloodGroup = bloodGroup;
            this.shift = shift;
        }
    }
}
