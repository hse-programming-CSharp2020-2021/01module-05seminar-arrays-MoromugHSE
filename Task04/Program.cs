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
            int N = int.Parse(Console.ReadLine());

            int A, D;
            // TODO: считайте необходимые значения A и D
            A = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            // TODO: инициализируйте массив и передайте его в соответствующий метод вместе с необходимыми значениями 
            int[] array = new int[N];
            FillArray(array, A, D);
            // TODO: выведите массив на экран
            PrintArray(array);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        static void FillArray(int[] arr, int A, int D)
        {
            // TODO: заполните массив соответствующими данными
            arr[0] = A;
            for (int i=1; i < arr.Length; ++i)
            {
                arr[i] = arr[i - 1] + D;
            }
        }
    }
}