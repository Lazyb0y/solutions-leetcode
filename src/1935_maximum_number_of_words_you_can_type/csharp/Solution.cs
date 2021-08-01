namespace LeetCodeSolutions
{
    public class Solution
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            int count = 0;

            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (brokenLetters.Contains(words[i][j].ToString()))
                    {
                        count++;
                        break;
                    }
                }
            }

            return words.Length - count;
        }
    }
}