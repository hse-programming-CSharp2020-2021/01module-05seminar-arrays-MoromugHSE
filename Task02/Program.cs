﻿using System;

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
            int N = int.Parse(Console.ReadLine());

            // TODO: инициализируйте массив и передайте его в соответствующий метод
            int[] array = new int[N];
            FillArray(ref array, N);

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

        static void FillArray(ref int[] arr, int N)
        {
            // TODO: заполните массив соответствующими данными
            arr[0] = 1;
            for (int i = 1; i < N; ++i)
            {
                arr[i] = arr[i - 1] * N;
            }
        }
    }
}