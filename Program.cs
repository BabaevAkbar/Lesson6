using System;
using Program;

namespace Program
{
    class Lesson6
    {
        static void Main(string[] args)
        {
            //Задача 1
            Random rand = new Random();
            int[] array = new int[4];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            int resultOfMethod = Methods.SumArray(array);
            int resultMaxOfMethod = Methods.MaxNumOfArray(array);
            Console.WriteLine($"Сумма всех чисел в массиве: {resultOfMethod}");
            Console.WriteLine($"Максимальное число в этом массиве: {resultMaxOfMethod}");

            
        }
    }
}
