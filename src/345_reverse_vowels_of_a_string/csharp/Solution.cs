using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            Dictionary<char, char> vowels = new Dictionary<char, char>
            {
                {'a', 'a'},
                {'e', 'e'},
                {'i', 'i'},
                {'o', 'o'},
                {'u', 'u'},
                {'A', 'A'},
                {'E', 'E'},
                {'I', 'I'},
                {'O', 'O'},
                {'U', 'U'}
            };

            char[] reverse = new char[s.Length];
            int head = 0;
            int tail = s.Length - 1;

            while (head <= tail)
            {
                if (vowels.ContainsKey(s[head]) && vowels.ContainsKey(s[tail]))
                {
                    reverse[head] = s[tail];
                    reverse[tail] = s[head];

                    head++;
                    tail--;
                }
                else
                {
                    if (!vowels.ContainsKey(s[head]))
                    {
                        reverse[head] = s[head];
                        head++;
                    }

                    if (!vowels.ContainsKey(s[tail]))
                    {
                        reverse[tail] = s[tail];
                        tail--;
                    }
                }
            }

            return new string(reverse);
        }
    }
}