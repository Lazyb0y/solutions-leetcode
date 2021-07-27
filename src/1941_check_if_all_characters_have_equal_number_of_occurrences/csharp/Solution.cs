using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (occurrences.ContainsKey(s[i]))
                {
                    occurrences[s[i]]++;
                }
                else
                {
                    occurrences.Add(s[i], 1);
                }
            }

            if (occurrences.Count == 1)
            {
                return true;
            }

            int baseCount = occurrences.ElementAt(0).Value;
            for (int i = 1; i < occurrences.Values.Count; i++)
            {
                if (occurrences.ElementAt(i).Value != baseCount)
                {
                    return false;
                }
            }

            return true;
        }
    }
}