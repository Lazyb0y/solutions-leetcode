namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool SquareIsWhite(string coordinates)
        {
            if (((coordinates[0] - 'a' + 1) + (coordinates[1] - '0')) % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}