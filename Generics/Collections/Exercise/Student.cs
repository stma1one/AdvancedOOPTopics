using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public int Kita { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Kita:{Kita}";

        }

        public static IEnumerable<Student> FillList()
        {
            List<Student> list=new List<Student>();
            list.Add(new Student()
            {
                Name = "Roni",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Jofir",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Yoav",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Ohad",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Yahali",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Shani",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Ofek",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Shani",
                Kita = 1    
            });
            list.Add(new Student()
            {
                Name = "Idan",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Ofek A.",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Barak",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Noa",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Omer",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Aviv",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Yael",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Yael H",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Yotam",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Maya",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Noga",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Avital",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Maya",
                Kita = 2
            });
            list.Add(new Student()
            {
                Name = "Niv",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Maya L.",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Aviv M.",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Roni N.",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Ori",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Aliya",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Eitan",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Alma",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Stav",
                Kita = 1
            });
            list.Add(new Student()
            {
                Name = "Omer K",
                Kita = 1
            });
            return list.AsEnumerable();
        }

    }


        
    
}
