using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.P03._Database_After.Contracts
{
    public interface IDatebase
    {
        IEnumerable<int> CourseIds();

        IEnumerable<string> CourseNames();

        IEnumerable<string> Search(string substring);

        string GetCourseById(int id);
    }
}
