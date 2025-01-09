using System;

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
            int resultOfMethod = Program.Methods.SumArray(array);
            Console.WriteLine($"Сумма всех чисел в массиве: {resultOfMethod}");

            
        }
    }
}
