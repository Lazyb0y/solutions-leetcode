namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if ('A' <= word[0] && word[0] <= 'Z')
            {
                return IsAllLowercase(word.Substring(1)) || IsAllUppercase(word.Substring(1));
            }
            else
            {
                return IsAllLowercase(word.Substring(1));
            }
        }

        public bool IsAllUppercase(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < 'A' || 'Z' < word[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsAllLowercase(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < 'a' || 'z' < word[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}