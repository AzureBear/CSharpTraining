using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ConditionEx2
    {
        static void Main(string[] args)
        {
            //사용자에게 점수를 입력받아서 학점과 합격여부를 출력(80점 이상이면 합격)
            Console.Write("점수 : ");
            int jumsu = int.Parse(Console.ReadLine());

            string result, pass;
            result = pass = string.Empty;

            if (jumsu >= 80)
            {
                pass = "합격";
                if ( jumsu >=90)
                    result = "A";
                else
                    result = "B";
            } 
            else
            {

            }



            if (jumsu >= 90)
            {
                result = "A"; 
                pass = "합격";
            }
            else if (jumsu >= 80)
                result = "B";
            else if (jumsu >= 70)
                result = "C";
            else if (jumsu >= 60)
                result = "D";
            else
                result = "F";
        }
    }
}
