using System;

namespace CSharp_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1;
            double d1 = 1.5;
            string s1 = "string";
            int[] i2 = { 0, 1, 2, 3 };
            double[] d2 = { 1.5, 2.6, 3.7 };
            string[] s2 = { "Thing 1", "Thing 2" };

            //Voting.VoteCheck();
            //NumGuess.Guess();
            //Plinko.drop();
            MethodOverload.TypeOut(i1);
            MethodOverload.TypeOut(i2);
            MethodOverload.TypeOut(d1);
            MethodOverload.TypeOut(d2);
            MethodOverload.TypeOut(s1);
            MethodOverload.TypeOut(s2);
        }



    }
}