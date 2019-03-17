using System;
using System.Collections.Generic;
using System.Linq;

namespace permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new SetOfCategories(2,2,2,2);
            mySet.BuildCombinations();
            mySet.PrintCombinations();
        }
    }
}
