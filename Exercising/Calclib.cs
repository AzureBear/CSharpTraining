using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Calclib
    {
        public char[] CharCalc1(string[] uiis) // 
        {
            foreach (string s in uiis)
            {
                if (s.Length > 5)
                {
                    char[] c = new char[s.Length];

                    for (int i = 0; i > s.Length; i++)
                    {
                        c[i] = s[s.Length - 1 - i];
                    }

                    return c;
                }
                return null;
            }
            return null;
        }
    }
}
