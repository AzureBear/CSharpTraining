using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class TestClass01
    {
        static void Main(string[] args)
        {

            int num;
            bool suc = false;



            Console.Write("더할 숫자: ");
            while (int.TryParse(Console.ReadLine(),out num))
            {
                Console.Write("더할 숫자: ");
                if (int.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("바른 값을 입력하세요.");
            }


            while (!suc)
            {
                Console.Write("더할 숫자: ");
                string input = Console.ReadLine();
                suc = int.TryParse(input, out num);

                if (!suc)
                {
                    Console.WriteLine("바른 값을 입력하세요.");
                }
            }




            Console.Write("한계 값: ");
            int lim = int.Parse(Console.ReadLine());

            int rst = 0;

            for (int i = 1; i <= lim; i++)
            {
                if (i % num == 0)
                {
                    rst += i;
                }
            }

            Console.WriteLine(rst);
        }
    }
}
