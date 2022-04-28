using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Rock
            //2 - scissors
            //3 - paper

            Random rnd = new Random();
            int cpuChoice = rnd.Next(1, 4);

            Console.WriteLine("Rock, paper or scissors?");
            string userChoice = Console.ReadLine().ToLower();

            if (cpuChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("Drow.");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("User wins!");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("Cpu wins!");
                }
                else
                {
                    Console.WriteLine("Invalid input from user, CPU wins.");
                }
            }
            else if (cpuChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("User wins");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("Cpu wins!");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("Drow!");
                }
                else
                {
                    Console.WriteLine("Invalid input from user, CPU wins.");
                }
            }
            else if (cpuChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("Cpu wins!");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("Drow!");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("User wins!");
                }
                
            else
            {
                Console.WriteLine("Invalid input from user, CPU wins.");
            }
            }
        }
    }
}
