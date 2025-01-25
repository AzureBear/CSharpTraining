using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByOut2
    {
        static void Main(string[] args)
        {
            bool bFlag = false;
            int radius = 0;

            while (!bFlag)
            {
                Console.Write("반지름:");
                bFlag = int.TryParse(Console.ReadLine(), out radius);
                if (!bFlag)
                {
                    Console.WriteLine("반지름을 숫자로 입력하세요.");
                }
            }

            double square, area;
            CircleCalc(radius, out square, out area);

            Console.WriteLine($"반지름이 {radius}인 원의 넓이는 {square}이고, 둘레는 {area}입니다.");
        }

        //반지름을 전달받아서 원의 넓이와 원의 둘레를 구하는 메서드
        static void CircleCalc(int radius, out double square, out double area)
        {
            square = 3.14 * radius * radius;
            area = 2 * 3.14 * radius;
        }
    }
}
