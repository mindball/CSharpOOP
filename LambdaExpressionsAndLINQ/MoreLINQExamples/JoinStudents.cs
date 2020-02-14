using System;
using System.Collections.Generic;
using System.Linq;

class JoinStudents
{
    public void Joins(List<Students> ls, List<Courses> cs)
    {
        var j = ls.Join(
            cs,
            student => student.StudentID,
            course => course.ID,
            (student, course) => new
            {
                StudentName = student.StudentName,
                CourseName = course.CourseName
            });

        foreach (var item in j)
        {
            Console.WriteLine(item.StudentName + " " + item.CourseName);
        }
    }
}

