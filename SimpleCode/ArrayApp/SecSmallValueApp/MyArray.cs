﻿using System;

namespace SecSmallValueApp
{
    public class MyArray
    {
        public int[] GetNewArray(int elemOfNumbers)
        {
            return new int[elemOfNumbers];
        }

        public void FilsArray(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 50);
            }
        }

        public void SortArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
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
    }
}
