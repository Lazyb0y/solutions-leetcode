using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> ransomNoteCharDist = new Dictionary<char, int>();
            Dictionary<char, int> magazineCharDist = new Dictionary<char, int>();

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (ransomNoteCharDist.ContainsKey(ransomNote[i]))
                {
                    ransomNoteCharDist[ransomNote[i]]++;
                }
                else
                {
                    ransomNoteCharDist.Add(ransomNote[i], 1);
                }
            }

            for (int i = 0; i < magazine.Length; i++)
            {
                if (magazineCharDist.ContainsKey(magazine[i]))
                {
                    magazineCharDist[magazine[i]]++;
                }
                else
                {
                    magazineCharDist.Add(magazine[i], 1);
                }
            }

            foreach (var ransomChar in ransomNoteCharDist)
            {
                if (!magazineCharDist.ContainsKey(ransomChar.Key) ||
                    ransomChar.Value > magazineCharDist[ransomChar.Key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}