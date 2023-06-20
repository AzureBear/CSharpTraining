using System;

namespace Exercising
{
    class UpDownGame
    {
        static void Main(string[] args)
        {
            Random com = new Random();
            int comc = com.Next(1, 51);

            Console.WriteLine("업다운 게임을 시작하세요!");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("당신이 추측하는 숫자는: ");
                int usr = int.Parse(Console.ReadLine());

                if (usr > comc)
                    Console.WriteLine("너무 높아요!");
                else if (usr < comc)
                    Console.WriteLine("너무 낮아요!");
                else
                {
                    Console.WriteLine("맙소사! 당신은 맞추셨어요! 천재입니다.");
                    break;
                }
            }
        }
    }
}