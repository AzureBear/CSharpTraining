using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public enum MyChannel { SBS = 6, KBS = 9, MBC = 11, TvN, EBS = 15, JTbc }

    class EnumTest
    {    

        static void Main(string[] args)
        {
            MyChannel ch1 = MyChannel.TvN;

            Console.WriteLine(ch1); //항목이 출력
            Console.WriteLine((int)ch1); //열거형의 항목은 int로 형변환
        }
    }

    class MyEnumTest
    {
        static void Main(string[] args)
        {
            MyChannel c3 = MyChannel.SBS;
        }
    }
}
