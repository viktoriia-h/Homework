using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");

            Console.WriteLine("Введiть значення Х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть значення Y");
            double y = double.Parse(Console.ReadLine());

            double a = (-6* Math.Pow(x, 2)) + (5 * Math.Pow(x, 2)) + (10 * x) + 15; 
            decimal b = (decimal)Math.Abs(x)*(decimal)Math.Sin(x);
            double c = 2 * (Math.PI) * x;
            double d = Math.Max(x, y);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("\nЗавдання 2");
            DateTime date1 = DateTime.Today;
            DateTime date2 = new DateTime(2022, 01, 01);
            TimeSpan value = date1.Subtract(date2);
            DateTime date3 = new DateTime(2022, 12, 31);
            TimeSpan value1 = date3.Subtract(date1);

            Console.WriteLine("today: " + date1);
            Console.WriteLine("days left to New Year: " + value1.Days);
            Console.WriteLine("days passed from New Year: " + value.Days);

        }
    }
}
