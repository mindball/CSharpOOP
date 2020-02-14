using System;

namespace DependencyInversion.P03._Database_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses courses = new Courses(new DatabaseSql());
            //ето колко лесно добавяме новата база данни виж before
            Courses coursesNew = new Courses(new DatebaseMySql());
        }
    }
}
