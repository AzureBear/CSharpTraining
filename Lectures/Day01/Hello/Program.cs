using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMITest 클래스의 Main");

            //1.입력
            //2.유효성체크
            //3.처리
            //4.결과출력

            Console.Write("신장(cm) : "); //"175.5" => 175.5
            double height = Convert.ToDouble(Console.ReadLine()) * 0.01; //1.755

            Console.Write("몸무게(kg) : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = (weight / Math.Pow(height, 2));

            //저체중 20 미만
            //정상  20 - 24
            //과체중 25 - 29
            //비만  30 이상

            string result = "";
            if (bmi < 20)
                result = "저체중";
            else if (20 <= bmi && bmi < 25)
                result = "정상";
            else if (25 <= bmi && bmi < 30)
                result = "과체중";
            else
                result = "비만";

            //Console.WriteLine("당신의 BMI 지수는 " + bmi + " 입니다.");
            //Console.WriteLine("당신의 신장은 {1}이고, 체중은 {0}이므로 BMI 지수는 {2}입니다.",
            //                        weight, height, bmi);
            Console.WriteLine($"당신의 신장은 {height * 100}이고, 체중은 {weight}이므로 BMI 지수는 {bmi}이고, {result} 입니다.");

        }
    }
}
