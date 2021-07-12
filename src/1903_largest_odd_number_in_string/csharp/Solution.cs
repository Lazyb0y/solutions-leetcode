namespace LeetCodeSolutions
{
    public class Solution
    {
        public string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                switch (num[i])
                {
                    case '1':
                    case '3':
                    case '5':
                    case '7':
                    case '9':
                        return num.Substring(0, i + 1);
                }
            }

            return string.Empty;
        }
    }
}