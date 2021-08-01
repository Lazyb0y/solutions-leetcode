namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ConvertToTitle(int columnNumber)
        {
            string name = "";

            while (columnNumber != 0)
            {
                char c = (char)((columnNumber - 1) % 26 + 'A');
                name = c + name;
                columnNumber = (columnNumber - 1) / 26;
            }

            return name;
        }
    }
}