using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCode
{
    class MajorityRules
    {
        //Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?

        

        public int FindMajority(int[] seed)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            int majority = seed.Length / 2;

            foreach(int i in seed)
            {
                if (numberCount.ContainsKey(i))
                {
                    numberCount[i]++;
                    if (numberCount[i] > majority)
                        return i;
                }
                else
                    numberCount.Add(i, 1);
            }


            throw new Exception("No Majority Found");
        }
    }
}
