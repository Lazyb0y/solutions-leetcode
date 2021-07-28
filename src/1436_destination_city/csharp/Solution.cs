using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string DestCity(IList<IList<string>> paths)
        {
            string destination = null;
            Dictionary<string, string> pathMap = new Dictionary<string, string>();

            foreach (var path in paths)
            {
                pathMap.Add(path[0], path[1]);
            }

            destination = pathMap.ElementAt(0).Value;

            while (pathMap.ContainsKey(destination))
            {
                destination = pathMap[destination];
            }

            return destination;
        }
    }
}