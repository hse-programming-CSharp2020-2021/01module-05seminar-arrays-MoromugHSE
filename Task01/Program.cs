using System;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());
            
            int[] array = new int[numOfItems];
            // TODO: считайте массив
            for (int i=0; i < numOfItems; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
            int newValue; // значение, которым нужно заменить все максимальные элементы
            // TODO: считайте новое значение
            newValue = int.Parse(Console.ReadLine());

            ReplaceMaxElem(ref array, newValue);

            // TODO: реализуйте вывод необходимых данных
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

        static void ReplaceMaxElem(ref int[] arr, int val)
        {
            // TODO: реализуйте замену всех вхождений максимального элемента массива arr на значение val
            int max = arr[0];
            for (int i=1; i < arr.Length; ++i)
            {
                max = Math.Max(max, arr[i]);
            }
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = arr[i] == max ? val : arr[i];
            }
        }
    }
}