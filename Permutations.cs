using System.Collections.Generic;

namespace permutations
{
    public static class Permutations
    { 
        private static List<string> list;
        public static List<string> BuildPermutations(this string categories)
        {
            list = new List<string>();

            StartGeneratingPermutations(categories);

            var toReturn = new List<string>(list);
            list = null;

            return toReturn;
        }

        private static void StartGeneratingPermutations(string text)
        {
            GeneratePermutations(text, text.Length - 1);
        }

        private static void GeneratePermutations(string text, int k)
        {
            if (k == 0)
            {
                list.Add(text);
            }
            else
            {
                for (int i = 0; i <= k; i++)
                {
                    Swap(ref text, k, i);
                    GeneratePermutations(text, k - 1);
                    Swap(ref text, k, i);
                }
            }
        }

        public static void Swap(ref string text, int index1, int index2)
        {
            string first = text[index1].ToString();
            string second = text[index2].ToString();
            text = text.Remove(index1, 1);
            text = text.Insert(index1, second);
            text = text.Remove(index2, 1);
            text = text.Insert(index2, first);
        }
    }
}