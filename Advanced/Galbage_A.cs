using System;

namespace Advanced
{
    class Galbage_A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("업 다운 게임에 오신 것을 환영합니다.");

            Random random = new Random();
            int com = random.Next(1, 51); // 1 이상 50 이하의 난수 생성

            bool playAgain = true;

            while (playAgain)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\n1부터 50까지의 숫자를 입력하세요:");
                    int usr = int.Parse(Console.ReadLine());

                    if (usr < com)
                        Console.WriteLine("UP");
                    else if (usr > com)
                        Console.WriteLine("DOWN");
                    else if (usr == com)
                    {
                        Console.WriteLine("축하합니다! 숫자를 맞추셨습니다.");
                        playAgain = false;
                        break;
                    }
                }

                if (playAgain)
                {
                    Console.WriteLine("\n재도전하시겠습니까? (Y/N)");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.N)
                        playAgain = false;

                    Console.WriteLine();
                }
            }

            Console.WriteLine("게임을 종료합니다. 감사합니다.");
        }
    }
}