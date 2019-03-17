using System.Collections.Generic;
using System.Linq;

namespace permutations
{
    public static class Combinations
    {
        public static List<string> BuildCombinations(SetOfCategories set, char? separator = null)
        {
            var list = new List<string>();

            var categories = set.Categories;

            int numberOfCombinations = NumberOfCombinations(set);
            string tmp = "";
            while(list.Count < numberOfCombinations)
            {
                foreach (var item in categories)
                {
                    tmp += item.GetCurrent();
                    tmp += separator;
                }
                list.Add(tmp);
                tmp = "";

                for (int i = 0; i < categories.Count; i++)
                {
                    categories[i].MoveForward();
                    if(!categories[i].IsNextMoveReset())
                        break;
                }
            }

            return list;
        }

        private static int NumberOfCombinations(SetOfCategories set)
        {
            int number = 1;
            foreach (var item in set.Categories)
            {
                number *= item.SubCategories.Count;
            }
            return number;
        }
    }
}