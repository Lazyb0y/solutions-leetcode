using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class RecentCounter
    {
        private readonly List<int> _timeList = new List<int>();

        public RecentCounter()
        {
        }

        public int Ping(int t)
        {
            _timeList.Add(t);

            int count = 0;
            int lowerBound = t - 3000;

            for (int i = _timeList.Count - 1; i >= 0; i--)
            {
                if (lowerBound <= _timeList[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
}