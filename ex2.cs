using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long fact = 1;

            Console.Write("Enter the number to find its factorial: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"\nThe factorial is:");
            Console.WriteLine($"{n}! = {fact}");
            Console.ReadLine();
        }
    }
}
