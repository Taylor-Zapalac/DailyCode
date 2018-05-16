using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCode
{
    class MergeLinkedLists
    {
        LinkedList<int> one = new LinkedList<int>();
        LinkedList<int> two = new LinkedList<int>();

        public LinkedList<int> mergeTwoLinkedLists(LinkedList<int> one, LinkedList<int> two)
        {
            return new LinkedList<int>(one.Union(two).OrderBy(x=>x));

        }
    }
}
