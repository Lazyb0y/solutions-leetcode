namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maximumWealth = 0;

            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                int wealth = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    wealth += accounts[i][j];
                }

                if (maximumWealth < wealth)
                {
                    maximumWealth = wealth;
                }
            }

            return maximumWealth;
        }
    }
}