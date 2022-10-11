using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Data
{
    public class StudentCollection
    {
        public List<Student> Students { get; private set; }

        public StudentCollection()
        {
            Students = new List<Student>(Student.FillList());
          
        }
        public Student FindStudentByName(string name)
        {
            //Find method - used to search a list for specific object
            ////use this delegate as parameter:public delegate bool Predicate<T>(T obj)
            Student ss = this.Students.Find(x => x.Name == name);

            return ss;
        }

        public Student FindStudentByNameQuery(string name)
        {
            //Find method using a query syntax- used to search a list for specific object
            IEnumerable<Student> query = from s in this.Students
                                         where s.Name == name
                                         select s;
            Student ss = query.FirstOrDefault();
            return ss;
        }

        public List<Student> GetAllStudentsInCertainKita(int kita)
        {
            //Where method - used to search a list for all objects that match a criteria
            IEnumerable<Student> students = this.Students.Where(s => s.Kita == kita);
            List<Student> studentList = students.ToList();
            return studentList;
        }

        public List<Student> GetAllStudentsInCertainKitaQuery(int kita)
        {
            //Where method - used to search a list for all objects that match a criteria
            IEnumerable<Student> students = from s in this.Students
                                            where s.Kita == kita
                                            select s;

            List<Student> studentList = students.ToList();
            return studentList;
        }

        public bool IsThereAStudentWithTahtName(string name)
        {
            //Any method is a bollean method that checks if an object in the list math a criteria
            bool nameExist = this.Students.Any(s => s.Name == name);
            return nameExist;
        }

        public List<Student> GetStudentsOrderedByKitaAndName()
        {
            //OrderBy and ThenBy Methods are used to sort a list
            IEnumerable<Student> enumStudents = this.Students.OrderBy(s => s.Kita)
                                                             .ThenBy(s => s.Name);
            List<Student> list = enumStudents.ToList();
            return list;
        }

        public List<Student> GetStudentsOrderedByKitaAndNameQuery()
        {
            //OrderBy using a query style laungauge
            IEnumerable<Student> enumStudents = from s in this.Students
                                                orderby s.Kita, s.Name
                                                select s;
            List<Student> list = enumStudents.ToList();
            return list;
        }

        public void PrintCountOfStudentsPerKita()
        {
            //GroupBy Method - used to group several objects that share the same propery value
            //note that the select define an object structure on the fly!!
            //this is the reason that the only way is to use a "var" type.
            var list = this.Students.GroupBy(s => s.Kita)
                                    .Select(x => new { Kita = x.Key, NumStudents = x.Count() });

            foreach (var obj in list)
                Console.WriteLine($"Kita:{obj.Kita}, Students: {obj.NumStudents}");

            //Ido style example (do the same as above!)
            Dictionary<int, List<Student>> dic = this.Students.GroupBy(s => s.Kita)
                                                              .ToDictionary(s => s.Key, s => s.ToList());

            foreach (var item in dic)
                Console.WriteLine($"Kita:{item.Key}, Students: {item.Value.Count}");
        }

        public void PrintCountOfStudentsPerKitaQuery()
        {
            //Using the group by query style syntax
            //note that here we do not HAVE to use "var" type but it is easier
            //to use instead of the complex IGrouping interface declaration
            //also note that the result is a list of lists!

            var list = from s in this.Students
                       group s by s.Kita;

            foreach (var groupObj in list) //run per kita
            {
                Console.WriteLine($"Kita:{groupObj.Key}, Count:{groupObj.Count()}");
                foreach (Student s in groupObj) //run on all students in a specific kita
                    Console.WriteLine(s);
            }
        }


    }
}
