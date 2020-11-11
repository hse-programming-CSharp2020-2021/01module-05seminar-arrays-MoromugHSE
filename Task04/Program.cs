using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            long N = long.Parse(Console.ReadLine());

            long A, D;
            // TODO: считайте необходимые значения A и D
            A = long.Parse(Console.ReadLine());
            D = long.Parse(Console.ReadLine());
            // TODO: инициализируйте массив и передайте его в соответствующий метод вместе с необходимыми значениями 
            long[] array = new long[N];
            FillArray(array, A, D);
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

        static void FillArray(long[] arr, long A, long D)
        {
            // TODO: заполните массив соответствующими данными
            arr[0] = A;
            for (long i=1; i < arr.Length; ++i)
            {
                arr[i] = arr[i - 1] + D;
            }
        }
    }
}