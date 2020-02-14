using System;
using System.Collections.Generic;
using System.Linq;

class OperatorExcept
{

    public List<Students> groupOneOfStudents = new List<Students>()
    {
        new Students() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Students() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Students() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Students() { StudentID = 5, StudentName = "Ron" , Age = 19 }
    };

    public List<Students> groupTwoOfStudents = new List<Students>()
    {       
        new Students() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Students() { StudentID = 5, StudentName = "Ron" , Age = 19 }
    };




    public class StudentComparer : IEqualityComparer<Students>
    {
        public bool Equals(Students x, Students y)
        {
            if (x.StudentID == y.StudentID && 
                x.StudentName.ToLower().Equals(y.StudentName.ToLower()) &&
                x.Age == y.Age)
                    return true;

            return false;
        }

        public int GetHashCode(Students obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}

