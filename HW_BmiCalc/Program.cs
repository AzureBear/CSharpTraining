using System;
using System.Configuration;

namespace HW_01_BmiCalc
{
    /// <summary>
    /// 2023년 6월 19일 KDT14기 C#과정 1강 숙제로 BMI 측정 프로그램을 만들었습니다.
    /// 만든사람: 이준호
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //설정 파일에서 값을 불러옵니다.
            string s1 = ConfigurationManager.AppSettings["info1"];
            string s2 = ConfigurationManager.AppSettings["info2"];

            //인사말을 출력합니다.
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("Welcome to Junho's BMI Calculating C# Program.");
            Console.ReadLine();

        confirm:
            //사용자로부터 키 값을 입력받습니다.
            Console.WriteLine($"\nPlease, enter your {s1}");
            float height = Convert.ToSingle(Console.ReadLine()) * 0.01f;

            //사용자로부터 몸무게 값을 입력받습니다.
            Console.WriteLine($"\nPlease, enter your {s2}");
            float weight = Convert.ToSingle(Console.ReadLine());

        start:
            //사용자에게 이 값으로 BMI를 계산할 것인지 물어봅니다.
            Console.WriteLine("\nCalculate BMI in this values? (Y/N)");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            //키를 눌렀을 경우 분기를 만듭니다.
            if (keyInfo.Key == ConsoleKey.Y)
            {
                float bmiValue = weight / (height * height);
                Console.WriteLine("\nYour BMI is " + bmiValue + ".");
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                goto confirm;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please press 'Y' or 'N'.");
                goto start;
            }
        }
    }
}
