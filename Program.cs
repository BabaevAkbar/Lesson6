using System;

namespace Program
{
    class Lesson6
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
        static void Main(string[] args)
        {
            //Задача 1
            Random rand = new Random();
            int[] array = new int[4];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            int resultOfMethod = SumArray(array);
            Console.WriteLine($"Сумма всех чисел в массиве: {resultOfMethod}");
        }
    }
}
