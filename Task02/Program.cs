using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }

        public static void RunTask02()
        {
            long N = long.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            long[] array = new long[N];
            FillArray(ref array, N);

            // TODO: выведите массив на экран
            PrintArray(array);
        }

        private static void PrintArray(long[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        static void FillArray(ref long[] arr, long N)
        {
            // TODO: заполните массив соответствующими данными
            arr[0] = 1;
            for (long i = 1; i < N; ++i)
            {
                arr[i] = arr[i - 1] * 2;
            }
        }
    }
}