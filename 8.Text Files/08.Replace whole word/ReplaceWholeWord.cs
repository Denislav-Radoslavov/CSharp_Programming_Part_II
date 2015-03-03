//Problem 8. Replace whole word
//
//    Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader("sample.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        using (reader)
        using (writer)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                line = line.ToLower();
                writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                line = reader.ReadLine();
            }
        }
        Console.WriteLine("Done!");
    }
}