namespace LeetCodeSolutions
{
    public class Solution
    {
        public string MaximumTime(string time)
        {
            char[] maxTime = new char[time.Length];
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == '?')
                {
                    switch (i)
                    {
                        case 0:
                            if (time[1] == '?' || int.Parse(time[1].ToString()) < 4)
                            {
                                maxTime[0] = '2';
                            }
                            else
                            {
                                maxTime[0] = '1';
                            }

                            break;
                        case 1:
                            if (maxTime[0] == '2')
                            {
                                maxTime[1] = '3';
                            }
                            else
                            {
                                maxTime[1] = '9';
                            }

                            break;
                        case 3:
                            maxTime[3] = '5';
                            break;
                        case 4:
                            maxTime[4] = '9';
                            break;
                        default:
                            maxTime[i] = time[i];
                            break;
                    }
                }
                else
                {
                    maxTime[i] = time[i];
                }
            }

            return new string(maxTime);
        }
    }
}