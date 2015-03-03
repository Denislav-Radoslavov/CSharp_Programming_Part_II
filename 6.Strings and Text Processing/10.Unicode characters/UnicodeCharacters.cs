//Problem 10. Unicode characters
//
//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.

using System;
using System.Text;

    class UnicodeCharacters
    {
        static string ConvertToUnicode(string str)
        {
            StringBuilder utf = new StringBuilder(str.Length * 6);
            foreach (char c in str)
                utf.AppendFormat("\\u{0:X4}", (int)c);
            return utf.ToString();
        }
        static void Main()
        {
            Console.WriteLine(ConvertToUnicode("Hi!"));
        }
    }