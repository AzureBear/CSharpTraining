using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class SetLotto
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            HashSet<int> lotto = new HashSet<int>();

            while(lotto.Count < 7)
            {
                lotto.Add(rnd.Next(1, 46));
            }
        }
    }
}
