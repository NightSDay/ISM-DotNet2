using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            n = Int32.Parse(Console.ReadLine());
            double s = 0, y;
            for (i = 1; i < n; i++)
            {
                y = i + 1;
                s += 1 / y;

                Console.Write("s=" + s + "\n");

            }
            Console.ReadKey();
        }

    }
}
