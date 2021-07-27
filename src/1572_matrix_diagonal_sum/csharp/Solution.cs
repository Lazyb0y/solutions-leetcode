namespace LeetCodeSolutions
{
    public class Solution
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;

            int left = 0;
            int right = mat[0].Length - 1;

            for (int i = 0; i < mat.Length; i++, left++, right--)
            {
                sum += mat[i][left];

                if (left != right)
                {
                    sum += mat[i][right];
                }
            }

            return sum;
        }
    }
}