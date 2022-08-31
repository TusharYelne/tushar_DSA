using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    /*Given an integer x, return true if x is palindrome integer.

    An integer is a palindrome when it reads the same backward as forward.

    For example, 121 is a palindrome while 123 is not.


    Example 1:

    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.
    Example 2:

    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.


    Constraints:

    -231 <= x <= 231 - 1



    Follow up: Could you solve it without converting the integer to a string?*/
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {

            if (x < 0)
            {
                return false;
            }
            if (x.ToString().Length == 1)
            {
                return true;
            }
            if (x % 2 == 0)
            {
                if (x.ToString().Substring(0, x.ToString().Length / 2) ==
                    x.ToString().Substring(x.ToString().Length / 2))
                {
                    return true;
                }
            }
            var str = x.ToString();
            var lBy2 = str.Length / 2;

            if (str.Length % 2 == 0)
            {
                string strFirstH = x.ToString().Substring(0, x.ToString().Length / 2);
                IEnumerable<char> Rev = strFirstH.Reverse();
                var ReSubSring = string.Concat(Rev.TakeWhile(char.IsNumber));
                if (ReSubSring ==
                    x.ToString().Substring(x.ToString().Length / 2))
                {
                    return true;
                }
            }
            var strFirstHalf = str.Substring(0, lBy2 + 1);
            IEnumerable<char> Rv = strFirstHalf.Reverse();
            var RevSubSring = string.Concat(Rv.TakeWhile(char.IsNumber));
            if (str.Substring(lBy2) == RevSubSring)
            {
                return true;
            }

            return false;
        }
    }
}
