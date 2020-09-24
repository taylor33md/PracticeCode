using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing_Pond
{
    public interface IStats
    {
        public int NumFish { get; set; }

        public int NumFisherman { get; set; }

        public int DaysFished { get; set; }

        public void StockPond(int numFish);

        public int FishPond(int NumFish, int NumFisherman, int DaysFished);
    }
}
