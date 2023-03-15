using System;

namespace JobNimbusAssessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            BracketInString bs = new BracketInString();

            start:
            Console.WriteLine("Enter a text:");
            Console.WriteLine(bs.isValidBracket(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine("Press Y to continue, any key to exit.");

            var answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Console.WriteLine("");
                goto start;
            }
            else
            {
                System.Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
