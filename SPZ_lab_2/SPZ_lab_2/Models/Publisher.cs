using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_lab_2.Models
{
    public class Publisher
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
