using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite n =");
            int n = Convert.ToInt32(Console.ReadLine());
            Double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + (n * m) + (m * m) - m);
            Double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.ReadKey();
        }
    }
}
