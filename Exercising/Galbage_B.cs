using System;

namespace Exercising
{
    class 업다운게임
    {
        static void Main(string[] args)
        {
            Console.WriteLine("업 다운 게임에 오신 것을 환영합니다.");

            Random rnd = new Random();
            int com = rnd.Next(1, 51);

            Console.Write("1부터 50까지의 숫자를 입력하세요:");

            for (int i = 0; i < 10; i++)
            {
                int usr = int.Parse(Console.ReadLine());

                if (usr < com)
                    Console.WriteLine("업!");
                else if (usr > com)
                    Console.WriteLine("다운!");
                else if (usr == com)
                    Console.WriteLine("축하합니다! 숫자를 정확히 맞추셨습니다.");
            }



        }
    }
}

/*
1. 변수 com 에다가 1~50까지 할당
2. 사람의 입력을 변수 usr에다가 저장
3. 반복문으로 총 5번의 기회를 줍니다.
4. 조건문으로 변수 com보다 작은지 큰지 그리고 맞추는지 계산합니다.
5. 5번의 기회가 소진되었을 경우 "당신은 패배했습니다."
6. 맞출 경우 "축하합니다"로 WriteLine 출력
*/