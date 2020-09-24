using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing_Pond
{
    public class Pond : IStats
    {
        public int NumFish { get; set; }
        public int NumFisherman { get; set; }

        public int DaysFished { get; set; }

        //constructor
        public Pond(int fish, int fisherman, int days)
        {
            NumFish = fish;
            NumFisherman = fisherman;
            DaysFished = days;
        }


        public void StockPond(int NumFish)
        {
            if(NumFish <= 25)
            {
                NumFish += 100;
                Console.WriteLine($"The pond has been stocked. There are now {NumFish} in the pond.");
            }
            else
            {
                Console.WriteLine($"There are still plenty of fish in this pond. Current estimates " +
                    $"show there are around {NumFish} of them. Probably don't need to restock.");
            }
            
        }

        public int FishPond(int NumFish, int NumFisherman, int DaysFished)
        {
            NumFish -= (NumFisherman * 6) * DaysFished;


            if(NumFish <= 0)
            {
                Console.WriteLine($"The pond has been fished for {DaysFished} days by {NumFisherman} fisherman and all of the fish " +
                    $"are gone :( We will need to restock the pond in order to do some more fishing.");
                NumFish = 0;
            }
            else
            {
                Console.WriteLine($"The pond has been fished for {DaysFished} days by {NumFisherman} fisherman. " +
               $"We'd guess theres probably around {NumFish} fish left in the pond.");
            }
           
            return NumFish;
        }



    }
}
