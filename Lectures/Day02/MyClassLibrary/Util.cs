using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Util
    {
        public static string CalcBMI(double height, double weight)
        {
            double temp = Math.Pow(height, 2);
            double bmi = (weight / temp);

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

            return result;
        }
    }
}
