using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        private static readonly Dictionary<char, string> MorseCodeMapping = new Dictionary<char, string>
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."}
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> uniqueCode = new HashSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string[] morseCode = new string[words[i].Length];

                for (int j = 0; j < words[i].Length; j++)
                {
                    morseCode[j] = MorseCodeMapping[words[i][j]];
                }

                uniqueCode.Add(string.Join("", morseCode));
            }

            return uniqueCode.Count;
        }
    }
}