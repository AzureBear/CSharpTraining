using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class EqualTest
    {
        static void Main(string[] args)
        {
            MyTest t1 = new MyTest();
            t1.num = 30;

            MyTest t2 = new MyTest();
            t2.num = 30;

            if (t1.Equals(t2))
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다");

            int i = 30;
            int p = 30;

            // == , !=  => 변수의 값을 비교
            // 참조타입의 경우는 == 보다는 Equals() 메서드를 사용하는 것이 좋다.
            // 사용자정의 참조타입(클래스)의 경우는 Equals()를 재정의하고 사용하는 것이 좋다.
            if (i.Equals(p))
                Console.WriteLine("같다");
            else
                Console.WriteLine("다르다");


        }
    }

    class MyTest
    {
        public int num = 10;

        public override bool Equals(object obj)
        {
            return obj is MyTest test &&
                   num == test.num;
        }
    }
}
