namespace LeetCodeSolutions
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int largestAltitude = 0;
            int currentAltitude = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                currentAltitude += gain[i];

                if (currentAltitude > largestAltitude)
                {
                    largestAltitude = currentAltitude;
                }
            }

            return largestAltitude;
        }
    }
}