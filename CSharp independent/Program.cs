using System;

namespace CSharp_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion(10);
        }

        public static void Recursion(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("A for loop is easier than this.");
                Console.WriteLine("Recursion done.");
            }
            else
            {
                Console.WriteLine("A for loop is easier than this.");
                x--;
                Recursion(x);
            }
        }
    }
}