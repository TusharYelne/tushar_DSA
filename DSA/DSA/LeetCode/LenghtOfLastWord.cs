using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    public class LenghtOfLastWord
    {
        public static int Solution(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }

            if (s.Length == 0)
            {
                return 0;
            }
            char space = ' ';
            //string ans = string.Empty;

            //for (int i = s.Length - 1; i >= 0; i--)
            //{
                //{
                //    if (s[i] == space)
                //    {
                //        continue;
                //    }
                //    else
                //    {
                //        if (i == 0)
                //        {
                //            if (s[i + 1] == space && ans.Length > 0)
                //            {
                //                break;
                //            }
                //            ans = ans + s[i].ToString();
                //            break;
                //        }
                //        if (ans.Length > 0 && s[i - 1] == space)
                //        {
                //            ans = ans + s[i].ToString();
                //            break;
                //        }
                //        ans = ans + s[i].ToString();
                //    }
                //}
                //return ans.Length;

                    int ans = 0;

                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        if (s[i] != space)
                        {
                            ans++;
                        }
                        else if (ans != 0)
                        {
                            return ans;
                        }
                    }

                    return ans;
            }
    }
}
