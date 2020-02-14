using DependencyInversion.P03._Database_After.Contracts;

namespace DependencyInversion.P03._Database_After
{
    public class Courses
    {
        private readonly IDatebase database;

        public Courses(IDatebase database)
        {
            this.database = database;
        }
        public void PrintAll()
        {
            var courses = database.CourseNames();

            //print courses
        }

        public void PrintIds()
        {
            
            var courseIds = database.CourseIds();

            //print course ids
        }

        public void PrintById(int id)
        {
            
            var course = database.GetCourseById(id);

            // print course
        }

        public void Search(string substring)
        {
            
            var courses = database.Search(substring);

            // print courses
        }
    }
}
