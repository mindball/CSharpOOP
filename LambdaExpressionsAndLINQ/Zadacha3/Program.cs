using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students2 = new List<Student>
            {
              new Student { FirstName="Ivan", LastName="Ivanov" },
              new Student { FirstName="Petar", LastName="Aleksandrov" },
              new Student { FirstName="Simona", LastName="Tomova" },
              new Student { FirstName="Alex", LastName="Petrov" }
            }; 

            List<Student> students = new List<Student>();
            students.Add(new Student() { FirstName = "Mincho", LastName = "Balaliev", Age = 36 });
            students.Add(new Student() { FirstName = "Ivanka", LastName = "Balalieva", Age = 30 });
            students.Add(new Student() { FirstName = "Tench", LastName = "Kosturov", Age = 22 });
            students.Add(new Student() { FirstName = "Mihalq", LastName = "Pelov", Age = 32 });
            students.Add(new Student() { FirstName = "Ivan", LastName = "Har", Age = 11 });
            students.Add(new Student() { FirstName = "Zubka", LastName = "Transoi", Age = 55 });

            var q = from s in students
                    where (s.FirstName.Length < s.LastName.Length)
                    select s;


            var q1 = from s in students
                     where s.Age >= 18 && s.Age <= 24
                     select s;

            var q2 = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);

            int[] number = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            var t = number.Where(s => s % 2 == 1);
           

        }
    }
}
