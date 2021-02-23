using System;

class Voting{

    public static void VoteCheck()
    {
        int age = 0;
        string citizen;
        string felony;
        string eval;

        Console.WriteLine("How old are you?");
        Console.Write("Enter age here: ");
        age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Are you a legal US citizen?");
        Console.Write("Type Y or N: ");
        citizen = Console.ReadLine().ToLower();

        Console.WriteLine("Have you been convicted of a felony?");
        Console.Write("Type Y or N: ");
        felony = Console.ReadLine().ToLower();

        eval = Evaluation(age,citizen,felony);

        if (eval == "eligible")
        {Console.WriteLine("You are eligible to vote");}
        else
        {
         Console.WriteLine("You are not eligible to vote.");
         Console.WriteLine("Reason: " + eval);
        }
    }

    static string Evaluation(int x, string c, string f)
    {
        if (x<18)
        {return "Not old enough to vote";}
        else if (c == "n")
        {return "Not a legal US citizen";}
        else if (f == "y")
        {return "Felony record";}
        else 
        {return "eligible";}

    }

}