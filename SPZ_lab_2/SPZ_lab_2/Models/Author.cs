using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_lab_2.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public static bool operator ==(Author obj1, Author obj2)
        {
            return obj1.FirstName == obj2.FirstName && obj1.LastName == obj2.LastName;
        }
        public static bool operator !=(Author obj1, Author obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
