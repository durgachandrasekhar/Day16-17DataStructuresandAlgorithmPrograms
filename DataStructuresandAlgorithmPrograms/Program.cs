using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresandAlgorithmPrograms
{
    class Binary

    {

        static public int binarySearch(String[] arr, String x)
        {
            int num = 0, r = arr.Length - 1;

            while ((num<=r))
            {
                int m = num + (r - num) / 2;
                int res = x.CompareTo(arr[m]);
                if (res == 0)
                    return m;
                if (res > 0)
                    num = m + 1;
                else 
                    r = m - 1;
            }
            return -num;

           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch");
            String[] arr = { "bugatti", "lamborgini", "ferrari", "porsche" };
            String x = "bugatti";
            int result = Binary.binarySearch(arr, x);
            if (result >= 0)
                Console.WriteLine("The word " + x + " is present at index :" + result);
            else
                Console.WriteLine(x + " is not present in list");
        }
    }
}