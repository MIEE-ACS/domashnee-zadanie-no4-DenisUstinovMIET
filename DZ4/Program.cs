
/*
 * Вариант 17
Одномерные массивы
В одномерном массиве, состоящем из n-целочисленных элементов, вычислить:
 количество положительных элементов массива;
 сумму элементов массива, расположенных после последнего элемента, равного нулю.
Преобразовать массив таким образом, чтобы сначала располагались все элементы, 
целая часть которых не превышает единицу, а потом — все остальные.*/

using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, positive_sum = 0, last_zero = 0, last_zero_sum = 0;
            Console.Write("Введите количество элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Введите количество элементов массива в виде натурального числа:");

            Console.WriteLine("Значение начального массива:");
            int[] Array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Array[i] = rand.Next(-5, 5);
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (Array[i] > 0) positive_sum++;
                if (Array[i] == 0) last_zero = i;
            }

            for (int i = last_zero; i < n; i++)
            {
                last_zero_sum = last_zero_sum + Array[i];
            }

            Console.WriteLine("Количество положительных элементов массива: " + positive_sum);
            Console.WriteLine("Сумму элементов массива, расположенных после последнего элемента, равного нулю: " + last_zero_sum);
        }
    }
}
