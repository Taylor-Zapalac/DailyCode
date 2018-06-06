using System.Collections.Generic;
using System.Linq;

namespace DailyCode
{
    internal class MergeLinkedLists
    {
        private LinkedList<int> one = new LinkedList<int>();
        private LinkedList<int> two = new LinkedList<int>();

        public LinkedList<int> mergeTwoLinkedLists(LinkedList<int> one, LinkedList<int> two)
        {
            return new LinkedList<int>(one.Union(two).OrderBy(x => x));
        }
    }
}