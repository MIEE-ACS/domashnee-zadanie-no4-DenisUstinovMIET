
/*
 * Вариант 17
Двумерные массивы
Путем перестановки элементов квадратной вещественной матрицы добиться того, 
чтобы ее максимальный элемент находился в левом верхнем углу, 
следующий по величине — в позиции (2, 2), следующий по величине — в позиции (3, 3) и т. д., 
заполнив таким образом всю главную диагональ.
Найти номер первой из строк, не содержащих ни одного положительного элемента.
 */
using System;

namespace DZ42
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 10;

            int n, buf = 0;
            Console.Write("Введите количество элементов массива: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Введите количество элементов массива в виде натурального числа:");

            Console.WriteLine("Значение начального массива:");
            int[,] Array = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Array[i, j] = rand.Next(min, max);
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] Array_index_i = new int[n], Array_index_j = new int[n];
            int[] Array_max = new int[n];
            for (int k = 0; k < n; k++)
            {
                Array_index_i[k] = k;
                Array_index_j[k] = k;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((Array[i, j] > Array[Array_index_i[k], Array_index_j[k]]) && i != j)
                        {
                            Array_index_i[k] = i;
                            Array_index_j[k] = j;
                        }
                    }
                }
                if (Array[k, k] < Array[Array_index_i[k], Array_index_j[k]])
                {
                    buf = Array[k, k];
                    Array[k, k] = Array[Array_index_i[k], Array_index_j[k]];
                    Array[Array_index_i[k], Array_index_j[k]] = buf;
                }
            }

            Console.WriteLine("Значение конечного массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
