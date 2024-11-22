using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];

            Console.WriteLine("Enter the elements of the first 2x2 matrix:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the elements of the second 2x2 matrix:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe resultant matrix after addition is:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine(); // For new row
            }

            Console.ReadLine();
        }
    }
}
