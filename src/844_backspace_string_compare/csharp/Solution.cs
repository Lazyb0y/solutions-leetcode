using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            List<char> sFiltered = new List<char>();
            List<char> tFiltered = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    if (sFiltered.Any())
                    {
                        sFiltered.RemoveAt(sFiltered.Count - 1);
                    }
                }
                else
                {
                    sFiltered.Add(s[i]);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    if (tFiltered.Any())
                    {
                        tFiltered.RemoveAt(tFiltered.Count - 1);
                    }
                }
                else
                {
                    tFiltered.Add(t[i]);
                }
            }

            return sFiltered.Count == tFiltered.Count &&
                   new string(sFiltered.ToArray()) == new string(tFiltered.ToArray());
        }
    }
}