namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2)
            {
                return true;
            }

            int distanceX = coordinates[coordinates.Length - 1][0] - coordinates[0][0];
            int distanceY = coordinates[coordinates.Length - 1][1] - coordinates[0][1];

            for (int i = 1; i < coordinates.Length - 1; i++)
            {
                int distanceCX = coordinates[i][0] - coordinates[0][0];
                int distanceCY = coordinates[i][1] - coordinates[0][1];

                if (distanceCX * distanceY - distanceCY * distanceX != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}