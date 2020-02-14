using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftTutorialLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                 new Student {First="Svetlana",
                     Last="Omelchenko",
                     ID=111,
                     Street="123 Main Street",
                     City="Seattle",
                     Scores= new List<int> {97, 92, 81, 60}},
                 new Student {First="Claire",
                     Last="O’Donnell",
                     ID=112,
                     Street="124 Main Street",
                     City="Redmond",
                     Scores= new List<int> {75, 84, 91, 39}},
                 new Student {First="Sven",
                     Last="Mortensen",
                     ID=113,
                     Street="125 Main Street",
                     City="Lake City",
                     Scores= new List<int> {88, 94, 65, 91}},
                 new Student {First="MIncho",
                     Last="Balaliev",
                     ID=113,
                     Street="Seattle",
                     City="Lake City",
                     Scores= new List<int> {88, 94, 65, 91}},
                 new Student {First="Ivan",
                     Last="Arabadjiev",
                     ID=113,
                     Street="125 Main Street",
                City="Seattle",
                Scores= new List<int> {88, 94, 65, 91}},
         };



            // Create the second data source.
            List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher {First="Ann", Last="Beebe", ID=945, City = "Seattle"},
            new Teacher {First="Alex", Last="Robinson", ID=956, City = "Redmond"},
            new Teacher {First="Michiyo", Last="Sato", ID=972, City = "Tacoma"},
            new Teacher {First="Ant", Last="Brat", ID=972, City = "Seattle"},
            new Teacher {First="Michiyo", Last="Sato", ID=972, City = "Tacoma"}
            
        };

            var query = (from s in students
                         where s.City == "Seattle"
                         select s.Last).
                         Concat(from t in teachers
                                  where t.City == "Seattle"
                                  select t.Last);

            var subSet = from s in students
                         where s.City == "Seattle"
                         select new { s.First, s.Last, s.Street, s.City, s.Scores };

            double[] radii = { 1, 2, 3 };

            var FormatQuery = from rad in radii
                              select String.Format("Area = {0}", (rad * rad) * 3.14);

            var group = from s in students
                        group s by s.Last[0] into studentGroup
                        orderby studentGroup.Key
                        select studentGroup;


        }
    }

    class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public List<int> Scores;
    }

    class Teacher
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public string City { get; set; }
    }
}
