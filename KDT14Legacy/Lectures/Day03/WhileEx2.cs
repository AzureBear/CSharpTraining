using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class WhileEx2
    {
        static void Main(string[] args)
        {
            //for문, while문은 조건에 따라서 한번도 실행을 안할수도 있다.
            //do ~ while문은 무조건 최소 한번은 실행한다.
            do
            {
                Console.Write("몇단을 출력을 할까요? : ");
                int dan = int.Parse(Console.ReadLine());

                for (int k = 1; k < 10; k++)
                {
                    Console.WriteLine($"{dan} * {k} = {dan * k}");
                }

                Console.Write("계속하시겠습니까? (Y/N)");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
