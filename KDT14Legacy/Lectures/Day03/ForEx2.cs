using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ForEx2
    {
        static void Main(string[] args)
        {
            int tot = 0;

            //1부터 100까지의 수중에서 5의 배수를 출력하시오.            
            for(int i=1; i<101; i++)
            {
                if (i % 5 == 0)
                    break;

                Console.Write(i + " ");
            }

            Console.Write("회원ID : ");
            string uid = Console.ReadLine();

            Console.Write("비밀번호 : ");
            string pwd = Console.ReadLine();

            SaveUser(uid, pwd);

            Console.WriteLine("\n==== 프로그램 종료 ====");

            //1부터 100까지의 수중에서 2의 배수이거나 3의 배수의 합을 구하시오.

            //1부터 100까지의 수중에서 3의 배수이거나 5의 배수를 출력하고, 합을 구하시오.

            //1부터 100까지의 수중에서 3의 배수이거나 5의 배수가 아닌 것을 출력하시오.

            //구구단을 가로로 출력하시오.
        }

        private static void SaveUser(string uid, string pwd)
        {
            if (uid.Length < 5)
            {
                Console.WriteLine("회원ID는 5글자 이상입니다.");
                return;
            }

            if (pwd.Length < 3)
            {
                Console.WriteLine("비밀번호는 3글자 이상입니다.");
                return;
            }

            //데이터베이스에 전달받은 uid, pwd를 전달
            //데이터베이스에 저장
            //회원가입 성공 멘트
        }

        static void AAA()
        {

        }
    }
}
