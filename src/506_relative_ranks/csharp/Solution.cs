using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < score.Length; i++)
            {
                dic.Add(score[i], i);
            }

            var sorted = dic.OrderByDescending(k => k.Key).ToArray();

            string[] ranks = new string[score.Length];

            for (int i = 0; i < score.Length; i++)
            {
                if (i == 0)
                {
                    ranks[sorted[i].Value] = "Gold Medal";
                }
                else if (i == 1)
                {
                    ranks[sorted[i].Value] = "Silver Medal";
                }
                else if (i == 2)
                {
                    ranks[sorted[i].Value] = "Bronze Medal";
                }
                else
                {
                    ranks[sorted[i].Value] = (i + 1).ToString();
                }
            }

            return ranks;
        }
    }
}