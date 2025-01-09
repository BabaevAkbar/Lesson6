using System;

namespace Program
{
    class Methods
    {
        public static int SumArray(int[] array)
        {
            int sum = 0;
            int index = 0;
            foreach(int i in array)
            {
                sum += i;
                Console.WriteLine($"array[{index}] - {i}");
                index++;
            }
            return sum;
        } 
    }
}