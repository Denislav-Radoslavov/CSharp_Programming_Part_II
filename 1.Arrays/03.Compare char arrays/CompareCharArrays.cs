//Problem 3. Compare char arrays
//
//    Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Text;

class CompareCharArrays
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Enter first array length: ");
        int length1 = int.Parse(Console.ReadLine());
        char[] arr1 = new char[length1];
        for (int i = 0; i < length1; i++)
        {
            Console.Write("Enter Arr1[{0}]: ", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array length: ");
        int length2 = int.Parse(Console.ReadLine());
        char[] arr2 = new char[length2];
        for (int i = 0; i < length2; i++)
        {
            Console.Write("Enter Arr2[{0}]: ", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }

        int index = 0;
        for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
        {
            index = i;
            if (arr1[i] != arr2[i])
            {
                break;
            }
        }
        if (arr1[index] < arr2[index])
        {
            Console.WriteLine("The first array is before the second.");
        }
        else if (arr1[index] > arr2[index])
        {
            Console.WriteLine("The second array is before the first.");
        }
        else if (index != arr1.Length - 1)
        {
            Console.WriteLine("The second array is before the first.");
        }
        else if (index != arr2.Length - 1)
        {
            Console.WriteLine("The first array is before the second.");
        }
        else
        {
            Console.WriteLine("The two arrays are equal.");
        }
    }
}