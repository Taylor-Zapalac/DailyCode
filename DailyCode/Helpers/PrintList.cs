using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode.Helpers
{
    class PrintList
    {

        public void printList(List<String> incoming)
        {
            foreach(String s in incoming)
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
