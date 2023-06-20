using System;

namespace Homeworks
{
    /// <summary>
    /// 2023년 6월 20일 (화)
    /// KDT14 C# 프로그래밍 2강 숙제
    /// 업-다운 게임
    /// 만든사람: 이준호
    /// </summary>
    class HW02_UpDownGame
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int com = rnd.Next(1, 51);

            bool win = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자를 입력하십시오.");
                int usr = int.Parse(Console.ReadLine());

                if (usr < com)
                    Console.WriteLine("당신이 낮습니다.");
                else if (usr > com)
                    Console.WriteLine("당신이 높습니다.");
                else if (usr == com)
                {
                    Console.WriteLine("숫자를 맞추셨습니다!");
                    win = true;
                    break;
                }
            }

            if (win == false)
                Console.WriteLine("게임에서 졌습니다.");
            else
                Console.WriteLine("축하합니다. 당신의 승리입니다");
        }
    }
}
