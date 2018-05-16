using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCode.Helpers
{
    class FillRandomArray
    {

        public int[] fillWithRandom(int howMany)
        { 

            Random rand = new Random();
            int[] filledArray = Enumerable
                            .Repeat(0, howMany)
                            .Select(i => rand.Next(0, 1000))
                            .ToArray();

            return filledArray;
            
        }
    }
}
