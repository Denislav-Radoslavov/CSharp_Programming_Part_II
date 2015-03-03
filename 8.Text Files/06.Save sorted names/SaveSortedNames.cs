//Problem 6. Save sorted names
//
//    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader("sample.txt");
        StreamWriter writer = new StreamWriter("result.txt");

        string line = reader.ReadLine();
        List<string> list = new List<string>();

        using (reader)
        using (writer)
        {
            while (line != null)
            {
                list.Add(line);
                line = reader.ReadLine();
            }
            list.Sort();

            foreach (string element in list)
            {
                writer.WriteLine(element);
            }
        }
        Console.WriteLine("Done!");
    }
}