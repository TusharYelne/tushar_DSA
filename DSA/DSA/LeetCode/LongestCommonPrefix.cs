using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DSA.LeetCode
{
    class LongestCommonPrefix
    {
        public static string GetLongestCommonPrefix(string[] strs)
        {
            //int Size = strs.Length;
            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }
            Array.Sort(strs);
            int PrefixLen;
            //Single Liner if else 
            PrefixLen = strs[0].Length > strs[strs.Length - 1].Length ? strs[strs.Length - 1].Length:strs[0].Length;
            int i = 0;
            while (i < PrefixLen && strs[0][i] == strs[strs.Length - 1][i])
            {
                i++;
            }
            return strs[0].Substring(0, i);
        }
    }
}
