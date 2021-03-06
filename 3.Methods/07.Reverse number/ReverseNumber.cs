﻿//Problem 7. Reverse number
//
//    Write a method that reverses the digits of given decimal number.

using System;
using System.Text;

class ReverseNumber
{
    static string Reverse(string reversedNumber)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = reversedNumber.Length - 1; i >= 0; i--)
        {
            sb.Append(reversedNumber[i]);
        }
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        string reversedNumber = Convert.ToString(number);
        string reversed = Reverse(reversedNumber);
        Console.WriteLine("The reversed number is: " + reversed);
    }      
}