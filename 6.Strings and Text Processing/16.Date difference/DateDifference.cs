//Problem 16. Date difference
//
//    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class DateDifference
{
    static void Main(string[] args)
    {
        string format = "d.MM.yyyy";

        Console.Write("Enter first date in format - dd.MM.yyyy : ");
        string firstDate = Console.ReadLine();

        DateTime dateOne = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);

        Console.Write("Enter second date in format - dd.MM.yyyy : ");
        string secondDate = Console.ReadLine();

        DateTime dateTwo = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);

        Console.WriteLine("Number of days between {0} and {1} are {2}", firstDate, secondDate, (dateTwo - dateOne).TotalDays);
    }
}