using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int FindCenter(int[][] edges)
        {
            HashSet<int> edgePoint = new HashSet<int> {edges[0][0], edges[0][1]};

            if (edgePoint.Contains(edges[1][0]))
            {
                return edges[1][0];
            }
            else
            {
                return edges[1][1];
            }
        }
    }
}