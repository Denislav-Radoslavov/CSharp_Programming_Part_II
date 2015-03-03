//Problem 24. Order words
//
//    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class OrderWords
{
    static void Main(string[] args)
    {
        Console.Write("Enter some words separated by space: ");
        string words = Console.ReadLine();

        char[] separators = new char[] { ' ', ',' };

        List<string> list = new List<string>(words.Split(separators));
        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}