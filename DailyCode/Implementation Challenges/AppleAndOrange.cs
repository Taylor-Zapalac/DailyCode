using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode.Implementation_Challenges
{
    class AppleAndOrange
    {
        // The problem on hackerrank is overexplained
        // Given a range on a line, a is apple tree location, b is orange tree location
        // s is start of area, t is end of area.
        // given m, number of apples fell, apples - location of apples
        // given n number of oranges fell, oranges - location of oranges
        // how many fell between s and t

        public void count(int startArea, int endArea, int appleTreeLocation, int orangeTreeLocation, int[] apples, int[] oranges)
        {
            int appleHitCount = 0;
            int orangeHitCount = 0;

            foreach(int i in apples)
            {
                int dropPoint = i + appleTreeLocation;
                if(dropPoint >= startArea && dropPoint <= endArea)
                {
                    appleHitCount++;
                }
            }

            foreach (int j in oranges)
            {
                int dropPoint = j + orangeTreeLocation;
                if (dropPoint >= startArea && dropPoint <= endArea)
                {
                    orangeHitCount++;
                }
            }

            Console.WriteLine(appleHitCount);
            Console.WriteLine(orangeHitCount);

        }
    }
}
