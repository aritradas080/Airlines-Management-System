using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class pilot : Employee
    {
        public pilot(string name, int id, int age, string Gender, string bloodGroup, string shift) : base(name, id, age, Gender, bloodGroup, shift)
        {

        }
    }
}
