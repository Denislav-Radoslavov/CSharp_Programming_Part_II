//Problem 11. Prefix "test"
//
//    Write a program that deletes from a text file all words that start with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Text.RegularExpressions;
using System.IO;

class PrefixTest
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
                writer.WriteLine(Regex.Replace(line, @"\btest\w{1,}", " "));
                line = reader.ReadLine();
                //(\b)test((\d|\w|_)*)(\b)
            }
        }
        Console.WriteLine("Done!");
    }
}