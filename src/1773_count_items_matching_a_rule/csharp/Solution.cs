using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int martchCount = 0;

            foreach (var item in items)
            {
                switch (ruleKey)
                {
                    case "type":
                        if (item[0] == ruleValue)
                        {
                            martchCount++;
                        }

                        break;
                    case "color":
                        if (item[1] == ruleValue)
                        {
                            martchCount++;
                        }

                        break;
                    case "name":
                        if (item[2] == ruleValue)
                        {
                            martchCount++;
                        }

                        break;
                }
            }

            return martchCount;
        }
    }
}