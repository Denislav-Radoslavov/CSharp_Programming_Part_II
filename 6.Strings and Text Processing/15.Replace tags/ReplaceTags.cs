//Problem 15. Replace tags
//
//    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text;

class ReplaceTags
{
    static void Main(string[] args)
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string result = text.Replace("<a href=\"", "[URL=").Replace("</a>", "[/URL]").Replace("\">", "]");

        Console.WriteLine("Result: \n" + result);
        Console.WriteLine();
    }
}