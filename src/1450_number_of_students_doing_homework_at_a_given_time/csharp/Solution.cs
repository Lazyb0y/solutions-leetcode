namespace LeetCodeSolutions
{
    public class Solution
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int studentCount = 0;

            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && queryTime <= endTime[i])
                {
                    studentCount++;
                }
            }

            return studentCount;
        }
    }
}