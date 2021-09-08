using System;
using System.Collections.Generic;
using System.Linq;

namespace TandemBicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] redShirtSpeeds = {5, 5, 3, 9, 2};
            int[] blueShirtSpeeds = { 3, 6, 7, 2, 1 };
            Console.WriteLine(TandemBicycle(redShirtSpeeds,blueShirtSpeeds,true));
            Console.ReadKey();
        }

        static int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            // Write your code here.

            Array.Sort(redShirtSpeeds);
            Array.Sort(blueShirtSpeeds);
            Array.Reverse(redShirtSpeeds);
            var sum = 0;
            for (int i = 0; i < redShirtSpeeds.Length; i++)
            {
                var findMax = Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]);
                sum += findMax;
            }
            return sum;
        }

        static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // Write your code here.
            int tracker = 0;
            return null;
        }

        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }
    }
}
