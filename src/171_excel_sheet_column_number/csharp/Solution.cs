namespace LeetCodeSolutions
{
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            int number = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                number = number * 26 + (columnTitle[i] - 'A' + 1);
            }

            return number;
        }
    }
}