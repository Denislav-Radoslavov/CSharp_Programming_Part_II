//Problem 19. Dates from text in Canada
//
//    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        string dateFormat = "dd.MM.yyyy";
        string text = "01.03.2015 2013.23.12 ";

        foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
        {
            string extractedToString = Convert.ToString(extracted);
            DateTime date = DateTime.ParseExact(extractedToString, dateFormat, CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}