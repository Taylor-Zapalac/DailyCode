using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode
{
    class Fibonacci
    {
        //Fibonacci is F(n) = F(n-1) + F(n-2)
        //Get n in sequence.

        public long gimmeDatFibo(int index)
        {
            long firstNumber = 0;
            long secondNumber = 1;
            long fiboNum = 0;

            for(int x = 0; x <= index; x++)
            {
                //F(n) = F(n-1) + F(n-2)
                fiboNum = firstNumber + secondNumber;
                //Make F(n-2) = F(n-1)
                firstNumber = secondNumber;
                //Make F(n-1) = F(n) for next round.
                secondNumber = fiboNum;
            }



            return fiboNum;

        }
    }
}
