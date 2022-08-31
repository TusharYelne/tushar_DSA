using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    public class Solution
    {
        int number = 0;
        Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanNumber = s[i];
                romanDictionary.TryGetValue(currentRomanNumber, out int num);
                if (i + 1 < s.Length && romanDictionary[s[i + 1]] > romanDictionary[s[i]])
                {
                    number -= num;
                }

                else
                {
                    number += num;
                }

            }
            return number;

        }
    }
}
