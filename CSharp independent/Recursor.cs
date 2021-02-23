using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_independent
{
    class Recursor
    {
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
