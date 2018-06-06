using System;
using System.Collections.Generic;

namespace DailyCode.Helpers
{
    internal class PrintDictionary
    {
        public void PrettyPrintDict(Dictionary<String, int> dict)
        {
            Console.WriteLine("  Key : Value  ");
            foreach (KeyValuePair<String, int> kvp in dict)
            {
                Console.WriteLine("{0}  :  {1}", kvp.Key, kvp.Value);
            }
        }
    }
}