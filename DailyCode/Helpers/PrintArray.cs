using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode.Helpers
{
    class PrintArray
    {

        public void printOneDimension(String[] incoming)
        {
            foreach(String s in incoming)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
        }

        public void printOneDimension(int[] incoming)
        {
            foreach (int i in incoming)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
