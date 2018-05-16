using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode
{
    class SwapNoTemp
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
