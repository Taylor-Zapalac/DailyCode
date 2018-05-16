using System;
using System.Collections.Generic;

namespace DailyCode
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Helpers.FillRandomArray filler = new Helpers.FillRandomArray();
            SwapNoTemp swap = new SwapNoTemp();
            MajorityRules majority = new MajorityRules();
            MergeLinkedLists merge = new MergeLinkedLists();
            AreWeAnagrams anagram = new AreWeAnagrams();
            SumPairs sumPair = new SumPairs();

            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Console.WriteLine("Swapping! 5 and 10");
            swap.swap(5, 10);
            Console.ReadLine();

            Console.WriteLine("SumPairs!");
            int[] randies = filler.fillWithRandom(1000);
            sumPair.findSumPairs(randies, 1000);
            Console.ReadLine();


            Console.WriteLine("Majority rules!");
            int[] seed = { 1, 2, 1, 4, 1, 3, 1, 5, 1, 6, 1 };
            Console.WriteLine(majority.FindMajority(seed));
            Console.ReadLine();

            Console.WriteLine("Merging two linked lists!");
            LinkedList<int> one = new LinkedList<int>();
            LinkedList<int> two = new LinkedList<int>();
            Random rng = new Random();
            for(int i = 0; i <= 10000; i++)
            {
                one.AddLast(rng.Next(1, 1000000));
                two.AddLast(rng.Next(1, 1000000));
            }
            
            merge.mergeTwoLinkedLists(one, two);
            Console.ReadLine();

            Console.WriteLine("Give me two words! I'll tell you if they is anagram.");
            String input = Console.ReadLine();
            String[] split = input.Split(" ");
            Console.WriteLine(anagram.anagramCheck(split[0], split[1]));
            Console.ReadLine();

        }
    }
}
