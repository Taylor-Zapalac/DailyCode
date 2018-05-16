using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode
{
    class SumPairs
    {
        //How to find all pairs of elements in an integer array, whose sum is equal to a given number? 

        public void findSumPairs(int[] incoming, int sum)
        {
            //Console.WriteLine("Incoming array: ");
            //Helpers.PrintArray printer = new Helpers.PrintArray();
            //printer.printOneDimension(incoming);

            List<String> pairs = new List<String>();

            for(int x = 0; x < incoming.Length; x++)
            {
                //Compare each number to the rest
                foreach(int i in incoming)
                {
                    if (incoming[x] + i == sum) pairs.Add(incoming[x] + ", " + i);
                }
            }

            Helpers.PrintList listPrinter = new Helpers.PrintList();
            listPrinter.printList(pairs);
        }
    }
}
