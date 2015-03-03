//Problem 12. Parse URL
//
//    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Text.RegularExpressions;


namespace _12.Parse_URL
{
    class ParseURL
    {
        static void Main()
        {
            string uri = "http://www.denislav.com/article/index.html";
            var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;
            Console.WriteLine(fragments[1]);
            Console.WriteLine(fragments[2]);
            Console.WriteLine(fragments[3]);
        }
    }
}
