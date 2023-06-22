using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Write("숫자입력:");
            // int age = int.Parse(Console.ReadLine());

            int age;
            bool bFlag = int.TryParse(Console.ReadLine(), out age);
            if (bFlag)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요.");
            }
        }
    }
}
