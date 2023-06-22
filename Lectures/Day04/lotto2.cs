using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class lotto2
    {
        static void Main(string[] args)
        {
            //난수 6개를 뽑아서 배열에 저장하고, 출력하시오.
            Random rnd = new Random();
            int[] lotto = new int[6];

            int idx = 0; 
            while (idx < lotto.Length)
            {
                int temp = rnd.Next(0, 6);

                if (lotto[temp] == 0) 
                {
                    lotto[temp] = temp;
                    idx++;
                }
            }

            Console.WriteLine("로또 번호 생성완료");

            foreach (var item in lotto)
            {
                Console.Write(item + " ");
            }

        }
    }
}
