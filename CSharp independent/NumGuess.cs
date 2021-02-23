using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_independent
{
    class NumGuess
    {



        public static void Guess()
        {
            bool correct = false;
            Random r = new Random();
            int correctNum = r.Next(1, 1000);
            Console.WriteLine("Guess the Number!!");


            do
            {
                Console.Write("Enter guess: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == correctNum)
                {
                    correct = true;
                    Console.WriteLine("You guessed it.");
                }
                else if (guess > correctNum)
                {
                    Console.WriteLine("Too High.");
                }
                else if (guess < correctNum)
                { Console.WriteLine("Too Low."); }
            }
            while (correct == false);
        }


    }
}

