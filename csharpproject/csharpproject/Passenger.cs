using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    public class Passenger : Person
    {
        public Passenger(string username, string email, string password, string nid, string passportid, int age, string gender) : base(username, email, password, nid, passportid, age, gender)
        {

        }
    }
}
