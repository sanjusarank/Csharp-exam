using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = -1, f2 = 2, f3, i;

            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The Fibonacci Series is:");
            for (i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;

                Console.Write(f3 + " ");
            }

            Console.ReadLine();
        }
    }
}
