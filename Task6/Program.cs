using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, i, S;
            Console.WriteLine("Vvedite  A i B: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            S = 1;
            for (i = A; i <= B; i++)
            {
                S *= B;
                Console.WriteLine($"Dobytok vid {i} do {B} = {S}");
            }
            Console.ReadKey();
        }
    }
}
