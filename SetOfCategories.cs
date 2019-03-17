using System.Collections.Generic;
using System.Text;

namespace permutations
{
    public class SetOfCategories
    {
        public List<Category> Categories { get; set; }
        public List<string> CategoriesCombinations {get; set; }

        public SetOfCategories(params int[] subcategoriesCount)
        {
            Categories = new List<Category>();
            foreach (var item in subcategoriesCount)
            {
                Categories.Add(new Category(item));
            }
        }

        public void BuildCombinations()
        {
            BuildPermutations();
            this.CategoriesCombinations = Combinations.BuildCombinations(this);
        }

        private void BuildPermutations()
        {
            foreach (var item in Categories)
            {
                item.BuildPermutations();
            }
        }

        public void PrintCombinations()
        {
            foreach (var item in CategoriesCombinations)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}