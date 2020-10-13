using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite b =");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Double y = 2.4 * Math.Abs(((x * x) + b) / (a)) + (a - b) *( Math.Pow(Math.Sin(a - b), 2)) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine(y);
            Console.ReadKey();



        }
    }
}
