using System;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 123;
            int B = 234;
            double X = 0.25;
            double Y = 0.5;
            bool C = (A < B) | (X > Y);
            Console.WriteLine(C);
        }
    }
}
