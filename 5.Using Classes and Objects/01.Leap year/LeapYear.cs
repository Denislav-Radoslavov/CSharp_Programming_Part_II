﻿//Problem 1. Leap year
//
//    Write a program that reads a year from the console and checks whether it is a leap one.
//    Use System.DateTime.

using System;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}