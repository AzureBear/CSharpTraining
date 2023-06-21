using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ConditionEx1
    {
        static void Main(string[] args)
        {
            //계속하시겠습니까?
            Console.Write("계속하시겠습니까? (Y/N)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                case "y":
                    Console.WriteLine("계속");
                    Console.WriteLine("계속");
                    break;
                case "N":
                case "n":
                    Console.WriteLine("종료");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }

            if (input == "Y" || input == "y")
            {
                Console.WriteLine("계속");
            }
            else if (input == "N" || input == "n")
            {
                Console.WriteLine("종료");
            }
            else
            {
                Console.WriteLine("잘못입력하셨습니다.");
            }

            //사용자에게 점수를 입력받아서 학점을 출력하시오.
            Console.Write("점수 : ");
            int jumsu = int.Parse(Console.ReadLine());

            string result = string.Empty;

            switch (jumsu / 10) 
            {
                case 10:
                case 9:
                    result = "A"; break;
                case 8:
                    result = "B"; break;
                case 7:
                    result = "C"; break;
                case 6:
                    result = "D"; break;
                default:
                    result = "F"; break;
            }


            if (jumsu >= 90)
                result = "A";
            else if (jumsu >= 80)
                result = "B";
            else if (jumsu >= 70)
                result = "C";
            else if (jumsu >= 60)
                result = "D";
            else 
                result = "F";


            if (jumsu < 60)
                result = "F";
            else if (jumsu >= 60 && jumsu < 70)
                result = "D";
            else if (jumsu >= 70 && jumsu < 80)
                result = "C";
            else if (jumsu >= 80 && jumsu < 90)
                result = "B";
            else
                result = "A";

            Console.WriteLine(result);
        }
    }
}
