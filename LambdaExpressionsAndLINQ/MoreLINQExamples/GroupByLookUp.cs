using System;
using System.Collections.Generic;
using System.Linq;



class GroupByLookUp
{
    public void GroupByAge(List<Students> result)
    {
        var tmp = result.GroupBy(x => x.Age);
        Print(tmp);
    }

    private void Print(IEnumerable<IGrouping<int, Students>> tmp)
    {
        Console.WriteLine("Group By");
        foreach (var item in tmp)
        {
            Console.WriteLine("Group: " + item.Key);
            foreach (var val in item)
            {
                Console.WriteLine("Student: " + val.StudentName);
            }
        }
    }

    internal void LookUp(List<Students> result)
    {
        Console.WriteLine("Look Up");
        var tmp = result.GroupBy(x => x.Age);
        Print(tmp);
    }
}

