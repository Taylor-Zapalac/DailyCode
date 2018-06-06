using System;
using System.Collections.Generic;

namespace DailyCode.Helpers
{
    internal class PrintList
    {
        public void printList(List<String> incoming)
        {
            foreach (String s in incoming)
            {
                Console.WriteLine(s);
            }
        }

        public void printList(List<int> incoming)
        {
            foreach (int i in incoming)
            {
                Console.WriteLine(i);
            }
        }
    }
}