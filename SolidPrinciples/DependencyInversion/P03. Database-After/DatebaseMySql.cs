using DependencyInversion.P03._Database_After.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.P03._Database_After
{
    public class DatebaseMySql : IDatebase
    {
        public IEnumerable<int> CourseIds()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> CourseNames()
        {
            throw new NotImplementedException();
        }

        public string GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Search(string substring)
        {
            throw new NotImplementedException();
        }
    }
}
