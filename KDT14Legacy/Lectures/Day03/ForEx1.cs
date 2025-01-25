using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ForEx1
    {
        static void Main(string[] args)
        {
            //for(초기값 ; 조건문; 증가값)
            //while (조건문)

            //1~10까지의 짝수의 합을 구하시오.
            int s_tot = 0;
            for(int i=2; i<11; i+=2)
            {                
                s_tot += i;
            }
            Console.WriteLine(s_tot);

            //1부터의 합이 100보다 커지는 순간의 수를 구하시오.
            int hap = 0, num = 1;
            while(hap < 100)
            {
                hap += num;
                num++;
            }
            Console.WriteLine($"1부터 {num}까지의 합은 {hap}입니다.");

            //1 ~10까지의 합을 while문으로 출력
            int tot = 0, su = 1;

            while (su < 11)
            {
                tot += su; //복합대입연산자 +=, -=, ^=, /=
                su++;
            }
            Console.WriteLine(tot);

            //break 분기문
            //가장 가까운 반복문 하나만 나간다.
            for (int c = 0; c < 10; c++)
            {
                Console.Write("몇단을 출력을 할까요? : ");
                int dan = int.Parse(Console.ReadLine());

                for (int k = 1; k < 10; k++)
                {
                    Console.WriteLine($"{dan} * {k} = {dan * k}");
                }

                Console.Write("계속하시겠습니까? (Y/N)");
                string result = Console.ReadLine();
                if (result.ToUpper() == "N")  //result.ToLower() == "y"
                {
                    break;
                }
            }


            int sum = 0;
            for (int i=1; i<=10; i++)
            {               
                sum = sum + i;
            }

            Console.WriteLine(sum);
        }
    }
}
