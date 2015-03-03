﻿//Problem 23. Series of letters
//
//    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string text = "aaaaabbbbbcdddeeeedssaammcrryyoopppppppl";

        StringBuilder sb = new StringBuilder();
        char letter = text[0];

        for (int i = 1; i < text.Length; i++)
        {
            char nextLetter = text[i];

            if (letter != nextLetter)
            {
                sb.Append(letter);
                letter = nextLetter;
            }
            if (i == text.Length - 1)
            {
                sb.Append(nextLetter);
            }
        }
        Console.WriteLine("Result: " + sb);
    }
}