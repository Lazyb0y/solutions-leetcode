namespace LeetCodeSolutions
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int jewelCount = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                for (int j = 0; j < jewels.Length; j++)
                {
                    if (stones[i] == jewels[j])
                    {
                        jewelCount++;
                        break;
                    }
                }
            }

            return jewelCount;
        }
    }
}