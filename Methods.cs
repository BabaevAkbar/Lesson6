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

        public static int MaxNumOfArray(int[] array)
        {
            int max = 0;
            foreach(int i in array)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public static int SumToNumN(int numN)
        {
            if(numN == 1) return numN;
            return numN + SumToNumN(numN - 1);
        }
    }
}