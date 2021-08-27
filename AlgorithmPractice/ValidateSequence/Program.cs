using System;
using System.Collections.Generic;

namespace ValidateSequence
{
    /*
     Problem statement..

       Given two non-empty arrays of integers, write a function that determines
       whether the second array is a subsequence of the first one.
    
       A subsequence of an array is a set of numbers that aren't necessarily adjacent
       in the array but that are in the same order as they appear in the array. For
       instance, the numbers [1, 3, 4]  form a subsequence of the array
        [1, 2, 3, 4] , and so do the numbers [2, 4] . Note
       that a single number in an array and the array itself are both valid
       subsequence of the array.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {5,1,22,25,6,-1,8,10};

            List<int> sequence = new List<int>
            {1,6,-1,10};
            Console.WriteLine("{0}", ValidateNumberSequence(numbers, sequence));

            Console.ReadKey();
        }

        static bool ValidateNumberSequence(List<int> array, List<int> sequence)
        {
            int arrayIndex = 0;
            int sequenceIndex = 0;

            while (arrayIndex < array.Count  && sequenceIndex < sequence.Count )
            {
                arrayIndex += 1;
                if (array[arrayIndex] == sequence[sequenceIndex])
                {
                    sequenceIndex += 1;
                }
            }
            return sequenceIndex == sequence.Count;
        }
    }
}
