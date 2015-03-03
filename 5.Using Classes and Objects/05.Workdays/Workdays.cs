//Problem 5. Workdays
//
//    Write a method that calculates the number of workdays between today and given date, passed as parameter.
//    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    private static DateTime today;
    private static DateTime lastDay;
    private static int allDays;

    static void CalculateWokrdays(DateTime lastDay)
    {
        DateTime[] holidays =
          {
              new DateTime(2015, 1, 1),
              new DateTime(2015, 1, 2),
              new DateTime(2015, 3, 2),
              new DateTime(2015, 3, 3),
              new DateTime(2015, 4, 10),
              new DateTime(2015, 4, 13),
              new DateTime(2015, 5, 1),
              new DateTime(2015, 5, 6),
              new DateTime(2015, 5, 24),
              new DateTime(2015, 9, 21),
              new DateTime(2015, 9, 22),
              new DateTime(2015, 12, 24),
              new DateTime(2015, 12, 25),
              new DateTime(2015, 12, 31)
          };

        DateTime[] workdayseOfWeek =
          {
              new DateTime(2015, 1, 24),
              new DateTime(2015, 3, 21),
              new DateTime(2015, 9, 12),
              new DateTime(2015, 12, 12)
          };

        today = DateTime.Today;
        allDays = (lastDay - today).Days;

        while (lastDay >= today)
        {
            if ((today.DayOfWeek == DayOfWeek.Saturday) || (today.DayOfWeek == DayOfWeek.Sunday))
            {
                for (int m = 0; m < workdayseOfWeek.Length; m++)
                {
                    if (today == workdayseOfWeek[m])
                    {
                        allDays++;
                    }
                }
                allDays--;
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (today == holidays[i])
                    {
                        allDays--;
                    }
                }

                for (int j = 0; j < workdayseOfWeek.Length; j++)
                {
                    if (today == workdayseOfWeek[j])
                    {
                        allDays++;
                    }
                }
            }
            today = today.AddDays(1);
        }
        Console.WriteLine("All days are: " + allDays);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter last day (Year.Month.Day) : ");
        lastDay = DateTime.Parse(Console.ReadLine());

        CalculateWokrdays(lastDay);
    }
}