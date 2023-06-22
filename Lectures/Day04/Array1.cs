using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Array1
    {
        static void Main(string[] args)
        {
            //난수 6개를 뽑아서 배열에 저장하고, 출력하시오.
            Random rnd = new Random();            
            int[] lotto = new int[6];

            lotto[0] = rnd.Next(1, 46); //0번째는 무조건 저장
            int idx = 1; //몇번째 배열에 저장할 차례인지

            while (idx < lotto.Length)
            {
                int temp = rnd.Next(1, 46);

                if (Array.IndexOf(lotto, temp) == -1)
                {
                    lotto[idx] = temp;
                    idx++;
                }
            }

            Console.WriteLine("로또 번호 생성완료");

            Array.Sort(lotto);
            Array.Reverse(lotto);

            foreach (var item in lotto)
            {
                Console.Write(item + " ");
            }
        }
    }
}
