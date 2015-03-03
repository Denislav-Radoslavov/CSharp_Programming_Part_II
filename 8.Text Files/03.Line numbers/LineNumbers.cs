//Problem 3. Line numbers
//
//    Write a program that reads a text file and inserts line numbers in front of each of its lines.
//    The result should be written to another text file.

using System;
using System.Text;
using System.IO;

class LineNumbers
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("firstFile.txt", Encoding.GetEncoding("Windows-1251"));
        StreamWriter writer = new StreamWriter("secondFile.txt", false, Encoding.GetEncoding("Windows-1251"));

        string line = reader.ReadLine();
        int lineNumber = 1;

        using (reader)
        using (writer)
        {
            while (line != null)
            {
                writer.WriteLine("{0}. {1}", lineNumber, line);
                line = reader.ReadLine();
                lineNumber++;
            }
        }
        Console.WriteLine("Done!");
    }
}