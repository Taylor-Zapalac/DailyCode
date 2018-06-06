using System;

namespace DailyCode
{
    internal class SwapNoTemp
    {
        public void swap(int one, int two)
        {
            one = one + two;
            two = one - two;
            one = one - two;
            Console.WriteLine(one + " " + two);
        }
    }
}