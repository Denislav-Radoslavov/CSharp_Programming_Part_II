//Problem 5. Parse tags
//
//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.

using System;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
    }
}