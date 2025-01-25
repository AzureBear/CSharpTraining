using System;

namespace Day02
{
    class If1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("홀짝 게임을 시작합니다......");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자 : ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("짝");
                }
                else
                {
                    Console.WriteLine("홀");
                }
            }
                

            Console.WriteLine("홀짝 게임을 종료합니다......");
        }
    }
}
