using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class IF1_1
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("홀짝 게임을 시작합니다......");

            for (int i = 0; i < 5; i++)
            {
                int num = rnd.Next(1, 100);
                //Console.WriteLine(num);

                Console.Write("홀/짝 : ");
                string reply = Console.ReadLine();
                
                if (num % 2 == 0 && reply == "짝")
                {
                    Console.WriteLine("승");
                }
                else if (num % 2 == 1 && reply == "홀")
                {
                    Console.WriteLine("승");
                }
                else
                {
                    Console.WriteLine("패");
                }
            }


            Console.WriteLine("홀짝 게임을 종료합니다......");
        }
    }
}
