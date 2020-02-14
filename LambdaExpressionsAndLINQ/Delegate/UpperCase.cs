using System;
using System.Collections.Generic;
using System.Linq;
public class UpperCase
{
    public delegate string UpperCaseDel(string str);

    public string MakeFirstUpperLetter(string str)
    {
        char[] buffer = str.ToCharArray();
        buffer[0] = char.ToUpper(buffer[0]);
        return new string(buffer);
    }

    public string MakeLastUpperLetter(string str)
    {
        char[] buffer = str.ToCharArray();
        buffer[str.Length - 1] = char.ToUpper(buffer[str.Length - 1]);
        return new string(buffer);
    }

    public string MakeAllUpper(string str)
    {
        return str.ToUpper();
    }

    public void CallDel(string str, UpperCaseDel del)
    {
        Console.WriteLine(str);
        Console.WriteLine(del(str));
    }
}

