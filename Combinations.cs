using System.Collections.Generic;
using System.Linq;

namespace permutations
{
    public static class Combinations
    {
        public static List<string> BuildCombinations(SetOfCategories set)
        {
            var list = new List<string>();

            var categories = set.Categories;

            int numberOfCombinations = NumberOfCombinations(set);
            string tmp = "";
            while(list.Count < numberOfCombinations)
            {
                foreach (var item in categories)
                {
                    tmp += item.GetElement();
                }
                list.Add(tmp);
                tmp = "";

                for (int i = 0; i < categories.Count; i++)
                {
                    if(categories[i].WillRotate())
                    {
                        categories[i].Increment();
                    }
                    else
                    {
                        categories[i].Increment();
                        break;
                    }
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