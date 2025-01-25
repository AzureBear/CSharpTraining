using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class WhileEx1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("몇단을 출력을 할까요? : ");
                int dan = int.Parse(Console.ReadLine());

                for (int k = 1; k < 10; k++)
                {
                    Console.WriteLine($"{dan} * {k} = {dan * k}");
                }

                Console.Write("계속하시겠습니까? (Y/N)");
                string result = Console.ReadLine();
                if (result.ToUpper() == "N")  //result.ToLower() == "y"
                {
                   break;
                }
            }
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
