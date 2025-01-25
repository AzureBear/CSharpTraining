using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            //컴퓨터가 난수를 뽑고, 사용자가 홀짝을 입력해서 맞추면 승, 패
            //5번을 하여, 전적을 몇승 몇패 승률 몇%로 출력하시오.

            Random rnd = new Random();
            int game = 0, win = 0;

            for (int i = 0; i < 5; i++)
            {
                int com = rnd.Next(1, 101);
                Console.WriteLine(com);
                game++;

                #region if문 연습
                /* 
                string com_result = "홀";
                if (com % 2 == 0)
                {
                    com_result = "짝";
                }            

                if (com % 2 == 0) 
                {
                    com_result = "짝";
                }
                else
                {
                    com_result = "홀";
                }
                */
                #endregion

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
            }
            Console.WriteLine($"{game}전 {win}승으로 승률{ (double)win / game * 100}% 입니다.");
        }
    }
}
