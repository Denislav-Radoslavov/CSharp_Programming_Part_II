//Problem 4. Maximal sequence
//
//    Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Text;

class MaximalSequence
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Въведете колко елемента да има: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        for (int index = 0; index < length; index++)
        {
            Console.Write("Въведете елемент {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (arr[index] == arr[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = index + 1 - maxCount;
                }
            }
        }

        Console.Write("Най-много елементи има от: ");
        for (int index = sequenceStart; index < sequenceStart + maxCount; index++)
        {
            Console.Write("{0} ", arr[index]);
        }
    }
}