namespace LeetCodeSolutions
{
    public class Solution
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int consistentCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                bool isConsistent = true;

                for (int j = 0; j < words[i].Length; j++)
                {
                    bool found = false;
                    for (int k = 0; k < allowed.Length; k++)
                    {
                        if (words[i][j] == allowed[k])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        isConsistent = false;
                        break;
                    }
                }

                if (isConsistent)
                {
                    consistentCount++;
                }
            }

            return consistentCount;
        }
    }
}