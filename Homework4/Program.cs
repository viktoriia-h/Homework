using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var max = FindMax(1, 4);
            Console.WriteLine("Найбiльше значення серед 1, 4: " + max);
            var max1 = FindMax(3, 4, 9);
            Console.WriteLine("Найбiльше значення серед 3, 4, 9: " + max1);
            var max2 = FindMax(2, 4, 9, 3);
            Console.WriteLine("Найбiльше значення серед 3, 4, 9, 2: " + max2);
            var min = FindMin(1, 4);
            Console.WriteLine("Найменше значення серед 1, 4: " + min);
            var min1 = FindMin(4, 3, 9);
            Console.WriteLine("Найменше значення серед 3, 4, 9: " + min1);
            var min2 = FindMin(2, 4, 9, 3);
            Console.WriteLine("Найменше значення серед 3, 4, 9, 2: " + min2);
        }

        static int FindMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        static int FindMax(int num1, int num2, int num3)
        {
            var max = FindMax(num1, num2);
            return FindMax(max, num3);
        }
        static int FindMax(int num1, int num2, int num3, int num4)
        {
            var max = FindMax(num1, num2, num3);
            return FindMax(max, num4);
        }
        //public int FindMax(int num1, int num2, int num3)
        //{
        //    int max = num1;
        //    int[] nums = new int[3] { num1, num2, num3 };
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}
        //static int FindMax(int num1, int num2, int num3, int num4)
        //{
        //    int max = num1;
        //    int[] nums = new int[4] { num1, num2, num3, num4 };
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] > max)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}
        static int FindMin(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            return num2;
        }
        static int FindMin(int num1, int num2, int num3)
        {
            var min = FindMin(num1, num2);
            return FindMin(min, num3);
        }
        static int FindMin(int num1, int num2, int num3, int num4)
        {
            var min = FindMin(num1, num2, num3);
            return FindMin(min, num4);
        }
    }
}
