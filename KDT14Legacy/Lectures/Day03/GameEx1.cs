using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class GameEx1
    {
        static void Main(string[] args)
        {
            //컴퓨터가 난수를 뽑고, 사용자가 홀짝을 입력해서 맞추면 승, 패
            //게임을 계속할지 여부를 물어보고,
            //프로그램이 종료할때 지금까지의 전적을 몇승 몇패 승률 몇%로 출력하시오.

            Random rnd = new Random();
            int game = 0, win = 0;

            while(true)
            {
                int com = rnd.Next(1, 101);
                Console.WriteLine(com);
                game++;

                Console.Write("홀/짝 : ");
                string input = Console.ReadLine();

                //삼항연산자 (조건) ? 참 : 거짓
                string com_result = (com % 2 == 0) ? "짝" : "홀";

                string result = "패";
                if (com_result.Equals(input))
                {
                    result = "승";
                    win++;
                }

                Console.WriteLine(result);

                Console.Write("계속하시겠습니까? (Y/N)");
                if (Console.ReadLine().ToUpper() == "N")  
                {
                    break;
                }
            }
            Console.WriteLine($"{game}전 {win}승으로 승률{ (double)win / game * 100}% 입니다.");
        }
    }
}
