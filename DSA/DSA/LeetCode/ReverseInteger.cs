using System;

namespace DSA.LeetCode
{
    public class ReverseInteger
    {
        public static int ReverseNumber(int n)
        {
            bool isNegative = n < 0;
            if (isNegative)
            {
                n = n * -1;
            }
            string s = n.ToString();

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            var ss = new string(charArray);
            if (Int32.TryParse(ss, out var ans))
            {
                if (isNegative)
                {
                    ans = int.Parse("-" + ans);
                    if (CheckEdges(ans))
                    {
                        return ans;
                    }
                }
                if (CheckEdges(ans))
                {
                    return ans;
                }
            }
            return 0;
        }

        public static bool CheckEdges(int ans)
        {
            if (Int32.MinValue < ans)
            {
                return true;
            }

            return false;
        }
    }
    //Driver Code
    /*Console.WriteLine(ReverseInteger.ReverseNumber(-23));
    Console.ReadLine();*/
}
