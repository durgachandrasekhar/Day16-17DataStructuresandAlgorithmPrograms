﻿using System;

namespace DataStructuresandAlgorithmPrograms
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] a = { 54, 35, 8, 6, 41 };
            int t;
            Console.WriteLine("The Array is :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            for (int j = 0; j < a.Length - 2; j++)
            {
                for (int i = 0; i < a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
        }
    }
}




             