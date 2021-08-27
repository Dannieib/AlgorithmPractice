using Newtonsoft.Json;
using System;

namespace NumberSum
{

      /*
           Problem statement..

        Write a function that takes in a non-empty array of distinct integers and an
        integer representing a target sum. If any two numbers in the input array sum
        up to the target sum, the function should return them in an array, in any
        order. If no two numbers sum up to the target sum, the function should return
        an empty array.
      */

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 5, -4, 11, 1, -1, 6};
            int targetSum = 10;

            var output = TwoNumberSum(array, targetSum);
            Console.WriteLine("{0}", JsonConvert.SerializeObject(output));

            Console.ReadKey();
        }
     
        //0(n^2) Time and 0(1) Space.
        //For my every analysis, I am open to  be correction with proves if I am not right. 
        static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int firstNum = 0;
            int secondNum = 0;

            //can also be => int firstNum, secondNum;

            for(int i =0; i < array.Length; i++)
            {
                firstNum = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    secondNum = array[j];

                    if (firstNum + secondNum == targetSum)
                    {
                        return new int[] {firstNum, secondNum};
                    }
                }
            }
            return new int[]{0,0};
        }

    }
}
