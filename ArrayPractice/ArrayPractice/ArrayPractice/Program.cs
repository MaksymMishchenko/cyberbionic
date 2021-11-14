﻿using System;

namespace ArrayPractice
{
    class Program
    {
        /// <summary>
        /// Сreates a one-dimensional array
        /// </summary>
        /// <param name="elOfNumbers"></param>
        /// <returns>Returns new array</returns>
        private static int[] CreateArray(int elOfNumbers)
        {
            int[] newArray = new int[elOfNumbers];
            return newArray;
        }

        /// <summary>
        /// Fills the array with random values
        /// </summary>
        /// <param name="arr"></param>
        private static void FillArray(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }
        /// <summary>
        /// Sorts items from smallest to largest
        /// </summary>
        /// <param name="arr"></param>
        private static void SortArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Displays array elements to the screen
        /// </summary>
        /// <param name="arr"></param>
        private static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr = CreateArray(10);
            FillArray(arr);
            Console.WriteLine("Random elements of array:");
            ShowArray(arr);
            Console.WriteLine(new string('-', 75));

            Console.WriteLine("Sorted array:");
            SortArray(arr);
            ShowArray(arr);
        }
    }
}
