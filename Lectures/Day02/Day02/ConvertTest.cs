using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class ConvertTest
    {
        static void Main(string[] args)
        {
            //값타입 => 값타입
            int k = 10;
            long lg = k; //암시적형변환
            //short s = Convert.ToInt16(k); //명시적형변환
            short s = (short)k;

            k = Int32.MaxValue;
            s = Convert.ToInt16(k);
            Console.WriteLine(s);

            //값타입(int) => 참조타입(string) : 박싱(Boxing)
            string strAge = Convert.ToString(25);    //(string)25;
            strAge = 25.ToString();

            //참조타입(string) => 값타입(int) : 언박싱(unBoxing)
            int age = int.Parse("25"); //Convert.ToInt32("25");
        }
    }
}
