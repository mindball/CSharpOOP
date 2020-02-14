using System;
using System.Collections.Generic;
using System.Linq;

class GroupJoin
{
    public void GroupJopinInTwoCollection(List<Students> studentList)
    {
        List<Courses> courseList = new List<Courses>()
        {
             new Courses() {CourseName = "C#", ID = 1, StudentID = 1 },
             new Courses() {CourseName = "Java", ID = 1, StudentID = 2 },
             new Courses() {CourseName = "C plqs plqs", ID = 1, StudentID = 3 },
             new Courses() {CourseName = "Perl", ID = 1, StudentID = 2 },
             new Courses() {CourseName = "PHP", ID = 1, StudentID = 1 },
        };

        var gJoin = courseList.GroupJoin(studentList,
                                cId => cId.StudentID,
                                sId => sId.StudentID,
                                (courseListResult, studentGroup) => new
                                {
                                    Student = studentGroup,
                                    Course = courseListResult.CourseName
                                });

        var gJoin2 = courseList.GroupJoin(studentList,
                                cId => cId.ID,
                                sId => sId.StudentID,
                                (courseListResult, studentGroup) => new
                                {
                                    Student = studentGroup,
                                    Course = courseListResult.CourseName
                                });
    }

    //more example
    Language[] languages = new Language[]
   {
        new Language {Id = 1, Name = "English"},
        new Language {Id = 2, Name = "Russian"}
   };

    Person[] persons = new Person[]
    {
        new Person { LanguageId = 1, FirstName = "Tom" },
        new Person { LanguageId = 1, FirstName = "Sandy" },
        new Person { LanguageId = 2, FirstName = "Vladimir" },
        new Person { LanguageId = 2, FirstName = "Mikhail" },
    };

    public void SpeakLang()
    {
        var result = languages.GroupJoin(persons,
            lang => lang.Id, 
            pers => pers.LanguageId,
            (lang, ps) => new { Key = lang.Name, Persons = ps });

        foreach (var item in result)
        {
            Console.WriteLine($"Persons speaking {item.Key}: ");
            foreach (var pers in item.Persons)
            {
                Console.WriteLine(pers.FirstName);
            }
        }
    }


}

class Language
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Person
{
    public int LanguageId { get; set; }
    public string FirstName { get; set; }
}

