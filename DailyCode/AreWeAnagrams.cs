using System;

namespace DailyCode
{
    internal class AreWeAnagrams
    {
        public Boolean anagramCheck(String one, String two)
        {
            char[] wordOne = one.ToLower().ToCharArray();
            char[] wordTwo = two.ToLower().ToCharArray();

            Array.Sort(wordOne);
            Array.Sort(wordTwo);

            String NewWordOne = new string(wordOne);
            String NewWordTwo = new string(wordTwo);

            if (NewWordOne.Equals(NewWordTwo)) return true;
            else return false;
        }
    }
}