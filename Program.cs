using System;
using System.Collections.Generic;
using System.Linq;

namespace permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new SetOfCategories(3,3,3,4);
            // mySet = new SetOfCategories(4,3,3);
            // mySet = new SetOfCategories(1,4);
            // mySet = new SetOfCategories(2,3,3,2,2,2);
            mySet.BuildCombinations();
            mySet.PrintCombinations();
        }
    }
}
