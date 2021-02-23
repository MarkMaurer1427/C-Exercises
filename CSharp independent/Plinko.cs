using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_independent
{
    class Plinko
    {
       static int position = 4;
        public static void drop()
        {
            Random p = new Random();
            int decider; 

            for (int i=0; i < 7; i++)
            { 
               decider = p.Next(1, 3);
                if (decider == 1) 
                {
                   if (position>1) {position--;}
                }
                else if (decider == 2)
                {
                    if (position<7) {position++;}
                }
            }

            switch (position)
            {
                case 1:
                    Console.WriteLine("Landed in position 1");
                    Console.WriteLine("Your prize: Udemy credit.");
                    break;

                case 2:
                    Console.WriteLine("Landed in position 2");
                    Console.WriteLine("Your prize: An iPhone.");
                    break;

                case 3:
                    Console.WriteLine("Landed in position 3");
                    Console.WriteLine("Your prize: Free LinkedIn premium for one year.");
                    break;

                case 4:
                    Console.WriteLine("Landed in position 4");
                    Console.WriteLine("Your prize: 5 bucks");
                    break;

                case 5:
                    Console.WriteLine("Landed in position 5");
                    Console.WriteLine("Your prize: $50 Best Buy gift card");
                    break;

                case 6:
                    Console.WriteLine("Landed in position 6");
                    Console.WriteLine("Your prize: An android phone");
                    break;

                case 7:
                    Console.WriteLine("Landed in position 2");
                    Console.WriteLine("Your prize: An alienware gaming laptop. WOOHOO!!");
                    break;
            }

        }
    }
}
