using System;

namespace ANDOperator
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

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Login failed. You tried to log in {i + 1} time");

                }


                Console.WriteLine("Hahe a nice day!");
            }

        }
    }
}
