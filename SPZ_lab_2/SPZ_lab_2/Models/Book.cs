using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_lab_2.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public int Year { get; set; }
    }
}
