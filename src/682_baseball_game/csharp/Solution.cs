using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            List<int> scores = new List<int>();

            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "+":
                        scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
                        break;

                    case "D":
                        scores.Add(2 * scores[scores.Count - 1]);
                        break;

                    case "C":
                        scores.RemoveAt(scores.Count - 1);
                        break;

                    default:
                        scores.Add(int.Parse(ops[i]));
                        break;
                }
            }

            return scores.Sum();
        }
    }
}