using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SqauredArray
{
    /*
       Write a function that takes in a non-empty array of integers that are sorted
       in ascending order and returns a new array of the same length with the squares
       of the original integers also sorted in ascending order.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {1, 2, 3, 5, 6, 8, 9};
            Console.WriteLine(JsonConvert.SerializeObject(SquaredArray(input)));
            Console.ReadKey();
        }

        static int[] SquaredArray(int[] numbers)
        {
            int[] squared = new int[numbers.Length];
            for (int i = 0; i<numbers.Length ; i++)
            {
                squared[i] = numbers[i] * numbers[i];
            }
            return squared;
        }
    }
}
