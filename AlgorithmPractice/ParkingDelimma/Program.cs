using System;

namespace ParkingDelimma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cars = { 2, 10, 08, 17 };
            Console.WriteLine(Parkingdelimma(cars, 3));

            Console.ReadKey();
        }

        public static int Parkingdelimma(int[] cars, int k)
        {
            Array.Sort(cars);

            int min = int.MaxValue;

            for (int i = 0; i < cars.Length - k + 1; i++)
            {
                min = Math.Min(min, cars[i + k - 1] - cars[i]);
            }
            return min + 1;
        }
    }
}
