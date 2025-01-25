using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class VarTest
    {
        static void Main(string[] args)
        {
            var i = 10;
            var str = "aaaaa";
            var ch1 = MyChannel.JTbc;

            int kk = i + 10;
            //i = "bbb";
            //str.

            object obj = 10;
            object obj2 = "aaaaa";
            object obj3 = MyChannel.KBS;

            int k = (int)obj + 10;
            obj = "bbb";
            //obj2.
        }
    }
}
