using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Updown2
    {
        static void Main(string[] args)
        {          
            Random rnd = new Random();
            Console.WriteLine("UpDown 게임을 시작합니다....");

            int game = 0, win = 0;
            bool bContinue = true;            

            while (bContinue) // while 문으로 하면 무한정가능
            {
                int com = rnd.Next(1, 51); // 이건 1 ~ 50 까지
                bool result = false;
                game++;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("숫자 입력: (종료:Q) ");
                    string input = Console.ReadLine();
                    if (input.ToLower().Equals("q"))
                    {
                        bContinue = false;
                        break;
                    }

                    int user = int.Parse(input);

                    string reply = string.Empty; 
                    if (com > user)
                        reply = "up";
                    else if (com < user)
                        reply = "down";
                    else 
                    {
                        win++;
                        result = true;
                        break;
                    }
                    Console.WriteLine(reply);
                }

                // 정답을 맞춰서 내려온 경우, for문을 다 돌도록 못맞추고 내려온 경우
                if (bContinue)
                {
                    if (result)
                        Console.WriteLine("정답입니다.");
                    else
                        Console.WriteLine($"정답은 {com} 입니다.");
                }
            }

            Console.WriteLine($"{game}전 {win}승으로 승률{ (double)win / game * 100}% 입니다.");
        }
    }
}