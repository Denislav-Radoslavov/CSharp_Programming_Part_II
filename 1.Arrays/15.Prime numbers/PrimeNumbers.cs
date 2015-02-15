//Problem 15. Prime numbers
//
//    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] bigArr = new bool[10000000];
        for (int i = 0; i < bigArr.Length; i++)
        {
            bigArr[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
        {
            if (bigArr[i])
            {
                for (int j = i * i; j < bigArr.Length; j = j + i)
                {
                    bigArr[j] = false;
                }
            }
        }

        for (int i = 0; i < bigArr.Length; i++)
        {
            if (bigArr[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}