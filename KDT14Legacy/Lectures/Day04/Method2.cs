using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Method2
    {
        static void Main(string[] args)
        {
            int sum, min, max;

            (sum, min, max) = MyCalc(new int[] { 80, 58, 78, 93 });

            MyCalc(null);
        }

        //전달받은 수들의 합을 구하시오.
        static (int, int, int) MyCalc(int[] args)
        {
            if (args == null || args.Length < 1)
                return (-1, -1, -1);

            int max = args[0];
            int min = args[0];
            int tot = 0;

            foreach (int item in args)
            {
                tot += item;

                if (max < item)
                    max = item;

                if (min > item)
                    min = item;
            }
            return (tot, min, max);
        }
    }
}
