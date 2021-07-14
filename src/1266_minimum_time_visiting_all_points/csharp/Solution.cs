using System;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int minimumTime = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                int xDistance = Math.Abs(points[i + 1][0] - points[i][0]);
                int yDistance = Math.Abs(points[i + 1][1] - points[i][1]);

                minimumTime += Math.Max(xDistance, yDistance);
            }

            return minimumTime;
        }
    }
}