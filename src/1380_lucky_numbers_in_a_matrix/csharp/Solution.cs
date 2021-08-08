using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> minInRows = new List<int>();
            List<int> maxInColumns = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                minInRows.Add(FindMinimumInRow(matrix, i));
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                maxInColumns.Add(FindMaximumInColumn(matrix, i));
            }

            return minInRows.Intersect(maxInColumns).ToList();
        }

        private int FindMinimumInRow(int[][] matrix, int rowNumber)
        {
            int min = int.MaxValue;

            for (int i = 0; i < matrix[rowNumber].Length; i++)
            {
                if (min > matrix[rowNumber][i])
                {
                    min = matrix[rowNumber][i];
                }
            }

            return min;
        }

        private int FindMaximumInColumn(int[][] matrix, int columnNumber)
        {
            int max = int.MinValue;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (max < matrix[i][columnNumber])
                {
                    max = matrix[i][columnNumber];
                }
            }

            return max;
        }
    }
}