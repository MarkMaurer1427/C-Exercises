using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_independent
{
    class MethodOverload
    {
        public static void TypeOut(int x)
        {
            Console.WriteLine("You input an INT parameter");
        }

        public static void TypeOut(double x)
        {
            Console.WriteLine("You input a DOUBLE parameter");
        }

        public static void TypeOut(string x)
        {
            Console.WriteLine("You input a STRING parameter");
        }

        public static void TypeOut(int[] x)
        {
            Console.WriteLine("You input an INT array");
        }

        public static void TypeOut(double[] x)
        {
            Console.WriteLine("You input a DOUBLE array");
        }
        public static void TypeOut(string[] x)
        {
            Console.WriteLine("You input a STRING array");
        }
    }
}
