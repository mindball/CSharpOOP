using System;
using System.Collections.Generic;
using System.Linq;

class MoreLINQExamples
{
    delegate bool FindStudent(Students std);

    class StudentExtension
    {
        public static List<Students> where(List<Students> stdArray, FindStudent del)
        {
            int i = 0;
            List<Students> result = new List<Students>();
            foreach (Students std in stdArray)
                if (del(std))
                {
                    result.Add(std);
                    i++;
                }

            return result;
        }
    }
    
    static void Main(string[] args)
    {
        List<Students> studentArray = new List<Students>{
            new Students() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Students() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Students() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Students() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Students() { StudentID = 5, StudentName = "Ron" , Age = 21 } ,
            new Students() { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
            new Students() { StudentID = 7, StudentName = "Rob",Age = 18  },
            new Students() { StudentID = 8, StudentName = "John",Age = 22  },
            new Students() { StudentID = 9, StudentName = "Ram" , Age = 55 } ,
        };

        //using delegate as parameter
        List<Students> st = StudentExtension.where(studentArray, delegate (Students std) {
            return std.Age > 12 && std.Age < 20;
        });
    
        foreach (var item in st)
        {
            if(item != null)
                Console.WriteLine(item.StudentName);
        }

        //same result using lambda expression
        var result = studentArray.Select(a => a).Where(a => a.Age > 12 && a.Age < 20);
        PrintCollection(result);

        //operator ofType
        var stringResult = studentArray.OfType<string>();

        Console.WriteLine("-----------OrderBy, ThenBy (ascending, descending)-----------");
        //OrderBy, ThenBy (ascending, descending). Sort first Name i ascendig then sort by Age
        var orderThenBy = studentArray.OrderBy(x => x.StudentName).ThenByDescending(x => x.Age);
        Console.WriteLine("OrderBy, ThenBy (ascending, descending)");
        PrintCollection(orderThenBy);

        Console.WriteLine("-----------Group by-----------");
        //GroupBy na Lookup
        //only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate
        GroupByLookUp grb = new GroupByLookUp();
        grb.GroupByAge(studentArray);
        grb.LookUp(studentArray);
        
        Console.WriteLine("-----------Join-----------");
        //Join outer and inner collection
        JoinStudents joins = new JoinStudents();
        List<Courses> course = new List<Courses>()
        {
            new Courses() {CourseName = "C#", ID = 1 },
            new Courses() {CourseName = "Java", ID = 2 },
            new Courses() {CourseName = "Perl", ID = 3 },
            new Courses() {CourseName = "Cplqs_plqs", ID = 4 },
        };

        joins.Joins(studentArray, course);
        
        Console.WriteLine("-----------GroupJoin-----------");
        GroupJoin groupJoinObject = new GroupJoin();
        groupJoinObject.GroupJopinInTwoCollection(studentArray);
        //more example
        groupJoinObject.SpeakLang();

        Console.WriteLine("-----------Aggregate-----------");
        List<string> ls = new List<string>() { "one", "two", "three", "four" };
        string aggregate = ls.Aggregate((str1, str2) => str1 + "," + str2);
        Console.WriteLine(aggregate);
        
        Console.WriteLine("-----------Extension method: Except-----------");
        OperatorExcept excObj = new OperatorExcept();
        var excResult = excObj.groupOneOfStudents.Except(excObj.groupTwoOfStudents, new OperatorExcept.StudentComparer());
        foreach (var item in excResult)
        {
            Console.WriteLine(item.StudentName);
        }

        Console.WriteLine("-----------Extension method: Skip/SkipWhile/Take/TakeWhile-----------");
        int[] arrs = { 5, 1, 3, 22, 30, 60, 44, 55, 59, 38 };
        var numbers = arrs.OrderBy(i => i).
                            SkipWhile(i => i < 30).
                            TakeWhile(i => i < 60);
        
        foreach (var number in numbers)            
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("-----------Extension method: ToDictionary-----------");
        List<Students> studentsToDict = new List<Students>()
        {
            new Students() { StudentID = 1, StudentName = "Peshko", Age = 3 },
            new Students() { StudentID = 2, StudentName = "Goshklo", Age = 4 },
            new Students() { StudentID = 3, StudentName = "Penio", Age = 5 },
            new Students() { StudentID = 4, StudentName = "Vladko", Age = 6 },
            new Students() { StudentID = 5, StudentName = "Bai ivan", Age = 1 }
        };

        var toDictionary = studentsToDict.ToDictionary<Students, int>(x => x.Age);
        List<string> list = new List<string>()
        {
            "cat",
            "dog",
            "animal"
        };
        var animals = list.ToDictionary(x => x, x => true);
        if (animals.ContainsKey("dog"))
        {
            // This is in the Dictionary.
            Console.WriteLine("dog exists");
        }
    }

    private static void PrintCollection(IEnumerable<Students> result)
    {
        foreach (var item in result)
        {
            Console.WriteLine($"{item.StudentName} {item.Age}");
        }
    }
}

