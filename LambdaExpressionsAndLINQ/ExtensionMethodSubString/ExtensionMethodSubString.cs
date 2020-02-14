using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtensionMethodSubString
{
    static void Main(string[] args)
    {
        StringBuilder str = new StringBuilder();
        str.Append("123");
        str.Append("abc");
        str.Append("!@#");

        str = str.SubStringStringBuilder(8, 0);

    }
}

static class StringBuilderSubString
{
    /// <summary>Create SubString for StringBuilder       
    /// </summary>
    /// <param name="str"></param>
    /// <param name="index"></param>
    /// <param name="len"></param>
    /// <returns></returns>
    public static StringBuilder SubStringStringBuilder(this StringBuilder str, int index, int len)
    {
        if (index < 0 || 
            len < 0 ||
            (index + len) >= str.Length)
                return null;
        return str.Remove(index, len);
    }
}


