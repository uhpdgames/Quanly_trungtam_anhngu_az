using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    public class Utils
    {
        public static bool CompareString(string s1, string s2)
        {
            s1 = s1.Trim();
            s2 = s2.Trim();
            for (int i = 1; i < s1.Length; i++)
            {
                if (s1[i] == s1[i - 1] && s1[i] == ' ')
                    s1 = s1.Remove(i--, 1);
            }
            for (int i = 1; i < s2.Length; i++)
            {
                if (s2[i] == s2[i - 1] && s2[i] == ' ')
                    s2 = s2.Remove(i--, 1);
            }

            s1 = s1.ToLower();
            s2 = s2.ToLower();
            if (s1 == s2)
                return true;
            return false;
        }
    }
}
