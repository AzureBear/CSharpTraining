using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class AvgEx1
    {
        static void Main(string[] args)
        {
            //국어, 영어, 수학 점수의 총점과 평균을 구하시오.
            int kor = 78;
            int eng = 90;
            int math = 89;

            int tot = kor + eng + math;
            Console.WriteLine($"총점은 {tot}점이고, 평균은 {tot/3.0:f2}점 입니다.");
        }
    }
}
