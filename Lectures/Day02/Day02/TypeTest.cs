using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class TypeTest
    {
        static void Main(string[] args)
        {
            //char(2바이트) => 문자, 정수
            //char 변수에 초기값을 줄때는 문자만 가능
            //변수를 정수로 출력할수는 있다
            char ch1 = 'A';
            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);
            ch1 = '가';
            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);

            char ch2 = (char)65;
            Console.WriteLine(ch2);

            int su1 = 10; //10진수
            Console.WriteLine(su1);

            int su2 = 0x10; //16진수
            Console.WriteLine(su2);

            int su3 = 0b10; //2진수
            Console.WriteLine(su3);

            float f1 = (float)3.14;
            float f2 = 3.14f;
            int ii = (int)f2;

            double d1 = 3.14;
            int pi = (int)d1;
            Console.WriteLine(pi);
            
        }
    }
}
