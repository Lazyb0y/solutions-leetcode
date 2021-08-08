namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            int columnToDelete = 0;

            for (int j = 0; j < strs[0].Length; j++)
            {
                int charVal = -1;
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i][j] < charVal)
                    {
                        columnToDelete++;
                        break;
                    }

                    charVal = strs[i][j];
                }
            }

            return columnToDelete;
        }
    }
}