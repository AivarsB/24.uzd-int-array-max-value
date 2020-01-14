using System;

namespace _24.uzd_int_array_max_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 14, 25, 66, 77, 88, 2, 3, 4, 9 };

            var maxValue = 0;

            foreach (var number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
