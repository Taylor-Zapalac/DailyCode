using System;

namespace DailyCode
{
    internal class StairCase
    {
        private static void staircase(int n)
        {
            int howMany = n;
            for (int i = n; i > 0; i--)
            {
                String row = "";
                for (int x = i - 1; x > 0; x--)
                {
                    row += " ";
                }
                for (int y = howMany - i; y >= 0; y--)
                {
                    row += "#";
                }
                Console.WriteLine(row);
            }
        }
    }
}