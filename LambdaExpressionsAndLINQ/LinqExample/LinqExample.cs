using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinqExample
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student("Baj", "Aergi", 22));
        students.Add(new Student("Hadji", "Bovcho", 58));
        students.Add(new Student("Kara", "Metodi", 38));
        students.Add(new Student("Stan", "Kolev", 18));
        students.Add(new Student("Car", "Sultan", 48));
        students.Add(new Student("Car", "Car", 24));

        //Get list of students whose first name is before their last name alphabetically
        SortStudent(students);

        Console.WriteLine();

        //Age range (18 between 24)
        AgeRange(students);

        Console.WriteLine();

        //Sort  FName and LName in desc. order by LINQ
        SortByDescOrderByLinq(students);
        Console.WriteLine();
        //Sort  FName and LName in desc. order with lambda expression
        SortByDescOrderByLamda(students);



    }

    //Sort  FName and LName in desc. order with lambda expression
    private static void SortByDescOrderByLamda(List<Student> students)
    {
        var sortedStudents = students.OrderByDescending(a => a.FirstName).ThenByDescending(a => a.LastName);

        foreach (var item in sortedStudents)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
        }
    }

    //Sort  FName and LName in desc. order by LINQ
    private static void SortByDescOrderByLinq(List<Student> students)
    {
        var sortedStudents = from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;

        foreach (var item in sortedStudents)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
        }
    }

    //Get list of students whose first name is before their last name alphabetically
    private static void SortStudent(List<Student> students)
    {
        var sortedStudent = from student in students
                            where String.CompareOrdinal(student.FirstName, student.LastName) >= 0
                            orderby student.FirstName
                            select student;
        
        //    var sortedStudent = students
        //.Where(s => String.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0) // Filter students whose FirstName is before LastName
        //.OrderBy(s => s.FirstName) // Order by FirstName
        //.ThenBy(s => s.LastName);

        foreach (var item in sortedStudent)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
        }


    }

    //Age range (18 between 24)
    private static void AgeRange(List<Student> students)
    {
        var ageRange = from student in students
                       where student.Age >= 18 && student.Age <= 24
                       select student;

        foreach (var item in ageRange)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
        }
    }
}

class Student
{
    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName { get; set; }

    public string  LastName { get; set; }

    public int Age { get; set; }
}



