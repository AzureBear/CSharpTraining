using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            //난수 6개를 뽑아서 배열에 저장하고, 출력하시오.
            Random rnd = new Random();            
            int[] lotto = new int[6];

            lotto[0] = rnd.Next(1, 7); //0번째는 무조건 저장
            int idx = 1; //몇번째 배열에 저장할 차례인지

            while (idx < lotto.Length)
            {
                int temp = rnd.Next(1, 7);
                bool bDuplicate = false;

                for(int i=0; i<idx; i++)
                {
                    if (temp == lotto[i]) //중복
                    {
                        bDuplicate = true;
                        break;
                    }
                }
                //중복이어서 break로 온 것과, for문을 끝까지 돌았는데 반복되지 않아서 온것
                if (!bDuplicate)
                {
                    lotto[idx] = temp;
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
