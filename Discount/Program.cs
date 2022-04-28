using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPurchase;
            Console.WriteLine("Enter the amount of purchase and we teel you your discount for next time:");
           sumPurchase = Convert.ToInt32(Console.ReadLine());

            if (sumPurchase  < 10 )
            {
                Console.WriteLine(" Minimum the amount of purchase for discount is 10 EURO!!!");

            }
             else if (sumPurchase >= 10 && sumPurchase <= 20)
            {
                Console.WriteLine(" Your discount for next purchase is 1 EURO!");

            }
            else if (sumPurchase >= 20 && sumPurchase <= 50)
            {
                Console.WriteLine("Your discount for next purchase is 5 EURO!");
            }
            else if (sumPurchase > 50 && sumPurchase <= 100)
            {
                Console.WriteLine("Your discount for next purchase is 10 EURO!");
            }
            
           
            else
            {
                Console.WriteLine("Your discount for next purchase is 15 EURO!") ;
            }
            Console.WriteLine("Have a nice day!");

        }
    }
}
