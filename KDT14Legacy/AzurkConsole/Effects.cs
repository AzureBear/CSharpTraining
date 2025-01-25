using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurkConsole
{
    class Effects
    {
        private const int DelaySec = 100;

        public static void WriteLine(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(DelaySec);
            }
            Console.WriteLine();
        }
    }
}
