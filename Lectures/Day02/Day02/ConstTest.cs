using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class ConstTest
    {
        static void Main(string[] args)
        {
            const double PI = 3.141592;

            //사용자에게 원의 반지름을 입력받아서 원의 넓이와 둘레를 출력하시오.
            Console.Write("원의 반지름 : ");
            double radius = double.Parse(Console.ReadLine());

            double square = PI * radius * radius;
            double area = 2 * PI * radius;

            Console.WriteLine($"반지름이 {radius}인 원의 넓이는 {square:f2}이고, 둘레는 {area:f2} 입니다.");

            int r = 5;
            Console.WriteLine(r * PI * PI);

            int r2 = 7;
            Console.WriteLine(r2 * PI * PI);
            
            int r3 = 9;
            Console.WriteLine(r3 * PI * PI);

            int k = Int32.MaxValue;
        }
    }
}
