using System;
using System.Globalization;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0, 1, 21, 33, 45, 45, 61, 71, 72, 73};

            Console.WriteLine(BinarySearchLogic(array,33));

            Console.ReadKey();

        }

        static int BinarySearchLogic(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
