//Problem 7. Replace sub-string
//
//    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//    Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstring
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
                line = line.ToLower().Replace("start", "finish");
                writer.WriteLine(line);
                line = reader.ReadLine();
            }
        }
        Console.WriteLine("Done!");
    }
}