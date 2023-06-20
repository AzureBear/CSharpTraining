using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BmiCalc_Prototype
{
    class Func
    {
        public static string CalcBMI(double h, double w)
        {
            double bmi = w / Math.Pow(h, 2);
            string result = bmi.ToString("F2"); // 소수점 둘째자리까지 BMI 값을 포맷합니다
            return result;
        }
    }
}
