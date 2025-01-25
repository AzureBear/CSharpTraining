using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Method1
    {
        static void Main(string[] args)
        {
            int tot = MyTot(1, 100, 5); //메서드를 호출할때 전달해주는 값 : 인자(argument)
            Console.WriteLine(tot);

            tot = MyTot(10, 20, 2); 
            Console.WriteLine(tot);

            Sum(10, 20);
            Sum(10, 20, k:30);

            int[] arr = { 2, 4, 5, 8, 9 };
            Sum(arr);
            Sum(new int[] { 2, 4, 5, 8, 9 });

            Sum(1, 2, 3);
            Sum(1, 2, 3, 4, 5, 6);
            Sum(1, 2, 3, 4, 5, 6, 7, 9);

            //Sum(3.14, 6.89);
        }

        //메서드 중복정의 overloading 
        //동일한 이름으로 메서드를 여러개 정의할 수 있다.
        //메서드 시그니처 정보가 유일하면 가능 (메서드명 + 매개변수 갯수 + 매개변수 타입 + 매개변수 순서)
        //반환타입, 매개변수명을 시그니처 정보에서 제외

        //두 수의 합을 구하는 메서드
        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //파라미터를 정의할때 기본값을 준다.
        //전달하지 않으면 기본값이 적용되고, 전달하면 전달한 값이 우선
        static int Sum(int x, int y, int z=0, int k=0)
        {
            return x + y + z;
        }

        //가변 파라미터  params
        static int Sum(params int[] args)
        {
            int tot = 0;
            foreach (int item in args)
            {
                tot += item;
            }
            return tot;
        }

        //static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        // 1부터 100까지의 짝수의 합을 구하시오.
        static int MyTot(int start, int end, int step) //매개변수(parameter)가 없다.
        {
            if (start >= end)
            {
                Console.WriteLine("초기값은 최대값보다 작아야 합니다.");
                return -1;
            }

            int tot = 0;
            
            for (int i = start; i <= end; i++)
            {
                if (i % step == 0)
                {
                    tot += i;
                }
            }

            return tot;
        }
    }
}
