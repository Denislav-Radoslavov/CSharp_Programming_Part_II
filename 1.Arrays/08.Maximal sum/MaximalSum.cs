//Problem 8. Maximal sum
//
//    Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        int maxSum = arr[0], currentSum = arr[0];
        int start = 0, startTemp = 0, end = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if (currentSum < arr[i])
            {
                currentSum = arr[i];
                startTemp = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.Write("The sequence with maximal sum is: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}