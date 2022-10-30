using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Part 1");
            Console.WriteLine(FindSum(10, 12));
            Console.WriteLine(FindSum(5, 2));
            Console.WriteLine(FindSum(10, 10));

            Console.WriteLine("\nPart 2");
            Console.WriteLine("Введiть значення Х");
            string input1 = Console.ReadLine();
            bool isValidInput = int.TryParse(input1, out int parseResult);
            int x;
            int y;
            if (isValidInput) 
            {
                x = int.Parse(input1);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Введiть значення Y");
            string input2 = Console.ReadLine();
            if (isValidInput)
            {
                y = int.Parse(input2);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine(FindSum(x, y));


            /*
             int x1 = 10;
             int y1 = 12;
             int sum1 = 0;
             for (int i = x1; i <= y1; i++)
             {
                 sum1 += i;
             }
             Console.WriteLine(sum1);

             int x2 = 5;
             int y2 = 2;
             int sum2 = 0;
             while(x2 >= y2)
             {
                 sum2 += x2;
                 x2--;
             }
             Console.WriteLine("\n" + sum2);
                 */
        }
        static int FindSum(int x, int y)
        {
            int sum = 0;

            if (x > y)
            {
                int tempX = x;
                x = y;
                y = tempX;
            }
            else if (x == y)
            {
                return x; 
            }
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
