using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string username, password;
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (username != "admin" && password != "1234")
                {
                    Console.WriteLine($"Login failed. You tried to log in {i + 1} time");
                    
                }
                else
                {
                    Console.WriteLine("Welcome!");

                    Console.WriteLine("Hahe a nice day!");
                    break;
                }


            }
        }
    }
}
