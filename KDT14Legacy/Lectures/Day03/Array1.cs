using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Array1
    {
        static void Main(string[] args)
        {
            //좋아하는 맥주 5개를 입력하고 출력하시오.
            //string[] beers = new string[5] { "카스", "하이트", "켈리", "스타우트", "칭타오"};
            //string[] beers = new string[] { "카스", "하이트", "켈리", "스타우트", "칭타오" };
            string[] beers = { "카스", "하이트", "켈리", "스타우트", "칭타오" };

            for (int i = 0; i < beers.Length; i++)
            {
                if (i == beers.Length-1)
                    Console.Write(beers[i]);
                else
                    Console.Write(beers[i] + ", ");
            }            


            //=========================================
            int kor = 87;
            int math = 67;
            int eng = 59;

            int tot = kor + math + eng;

            int[] arr = new int[11];

            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            tot = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tot += arr[i];
            }
            Console.WriteLine(tot);
        }
    }
}
