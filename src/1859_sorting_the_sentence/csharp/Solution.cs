using System;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string SortSentence(string s)
        {
            string[] parts = s.Split(' ');

            string[] resultParts = new string[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                int index = Int32.Parse(parts[i][parts[i].Length - 1] + "") - 1;
                resultParts[index] = parts[i].Substring(0, parts[i].Length - 1);
            }

            return string.Join(" ", resultParts);
        }
    }
}