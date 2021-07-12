using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        private static readonly Dictionary<char, int> Values = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToInt(string s)
        {
            int value = 0;

            int[] symbolValue = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                symbolValue[i] = Values[s[i]];
            }

            int lastValue = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (symbolValue[i] < lastValue)
                {
                    lastValue = Values[s[i]];
                    value -= lastValue;
                }
                else
                {
                    lastValue = Values[s[i]];
                    value += lastValue;
                }
            }

            return value;
        }
    }
}