using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Data
{
    public class Student
    {
        public string Name { get; set; }
        public int Kita { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Kita:{Kita}";
        }
    }
}
