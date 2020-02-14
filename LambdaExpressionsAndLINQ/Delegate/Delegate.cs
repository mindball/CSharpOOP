using System;
using System.Collections.Generic;
using System.Linq;

class Delegate
{
    static void Main(string[] args)
    {
        //Example 1
        PrintAndWriteIntoFile obj = new PrintAndWriteIntoFile();
        PrintAndWriteIntoFile.PrintAndWrite t = new PrintAndWriteIntoFile.PrintAndWrite(obj.WriteToFile);
        t += obj.PrintMessage;

        obj.SendMessage(t);

        //Example 2
        UpperCase upper = new UpperCase();
        upper.CallDel("perls", new UpperCase.UpperCaseDel(upper.MakeFirstUpperLetter));
        upper.CallDel("perls", new UpperCase.UpperCaseDel(upper.MakeLastUpperLetter));
        upper.CallDel("perls", new UpperCase.UpperCaseDel(upper.MakeAllUpper));




    }
}

