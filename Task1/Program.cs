using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite b=");
            int b = Convert.ToInt32(Console.ReadLine());
            int S = a * b;
            int P = a + a + b + b;
            // Console.WriteLine("s=\nP=", S, P);
            Console.WriteLine(S);
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
