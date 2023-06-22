using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByReference
    {
        static void Main(string[] args)
        {
            bool bFlag = false;
            int age = 0;

            while (!bFlag)
            {
                Console.Write("숫자입력:");                        
                bFlag = int.TryParse(Console.ReadLine(), out age);
                if (!bFlag)
                {
                    Console.WriteLine("숫자를 입력하세요.");
                }
            }

            Console.WriteLine($"나이는 {age}입니다.");

            // int age = int.Parse(Console.ReadLine());    
            int x;
            x = 5;
            int y = 3;

            Console.WriteLine($"x={x}, y={y}"); //5, 3
            Swap(x, y);
            Console.WriteLine($"x={x}, y={y}"); //5, 3

            int a;
            int b;
           // Console.WriteLine($"a={a}, b={b}"); //5, 3
            Swap(out a, out b);
            Console.WriteLine($"a={a}, b={b}"); //3, 5 
        }

        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Swap(out int x, out int y)
        {
            x = 10;
            y = 20;

            int temp = x;
            x = y;
            y = temp;
        }
    }
}
