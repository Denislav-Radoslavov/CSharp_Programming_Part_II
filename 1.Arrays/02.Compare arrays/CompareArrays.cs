//Problem 2. Compare arrays
//
//    Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Text;

class CompareArrays
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Въведете дължина на първия масив: ");
        int length1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length1];
        for (int index = 0; index < length1; index++)
        {
            Console.Write("Въведи масив едно[{0}]: ", index);
            arr1[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Въведете дължината на втория масив: ");
        int length2 = int.Parse(Console.ReadLine());
        int[] arr2 = new int[length1];
        for (int index = 0; index < length2; index++)
        {
            Console.Write("Веведи масив две[{0}]: ", index);
            arr2[index] = int.Parse(Console.ReadLine());
        }
        bool equal = true;

        if (length1 == length2)
        {
            for (int index = 0; index < length1; index++)
            {
                if (arr1[index] != arr2[index])
                {
                    equal = false;
                    break;
                }
            }
        }
        else
        {
            equal = false;
        }

        if (equal)
        {
            Console.WriteLine("Двата масива имат еднакви елементи.");
        }
        else
        {
            Console.WriteLine("Свата масива имат различни елементи.");
        }
    }
}
