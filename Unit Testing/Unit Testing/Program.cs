using System;

namespace Fishing_Pond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many fish are in this pond?");

            int fishes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many fisherman are allowed to fish this pond?");

            int fisherman = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many days will you allow them to fish?");

            int days = Convert.ToInt32(Console.ReadLine());

            Pond newPond = new Pond(fishes, fisherman, days);

            int remainingFish = newPond.FishPond(fishes, fisherman, days);

            Console.WriteLine("Would you like to try restocking the pond? (y/n)");

            string answer = Console.ReadLine();

            if(answer == "y" | answer == "Y")
            {
                newPond.StockPond(remainingFish);
            }
            else
            {
                Console.WriteLine("Alright, we'll leave it as is then.");
            }

            

            
        }
    }
}
