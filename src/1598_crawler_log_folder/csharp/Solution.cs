namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MinOperations(string[] logs)
        {
            int currentIndx = 0;

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] == "../")
                {
                    if (currentIndx > 0)
                    {
                        currentIndx--;
                    }
                }
                else if (logs[i] == "./")
                {
                    // Do nothing
                }
                else
                {
                    currentIndx++;
                }
            }

            return currentIndx;
        }
    }
}