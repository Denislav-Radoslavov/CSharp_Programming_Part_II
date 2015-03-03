//Problem 8. Extract sentences
//
//    Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text.RegularExpressions;


class ExtractSentences
{
    static void Main(string[] args)
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
            Console.WriteLine(sentence.Groups[1]);
    }
}