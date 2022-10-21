using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Let me introduse myself!)");
            int a = 0;
            while (a != 6) 
            {
                Console.WriteLine("\n1. My name");
                Console.WriteLine("2. My age");
                Console.WriteLine("3. My hobby");
                Console.WriteLine("4. My skills");
                Console.WriteLine("5. My pet");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\nChoose the option");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine($"My name is {person.Name}");
                        break;
                    case 2:
                        Console.WriteLine($"I am {person.Age} years old");
                        break;
                    case 3:
                        Console.WriteLine($"My hobby is {person.Hobby}");
                        break;
                    case 4:
                        Console.WriteLine(person.Skills);
                        break;
                    case 5:
                        Console.WriteLine($"My pet is {person.Pet}");
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
