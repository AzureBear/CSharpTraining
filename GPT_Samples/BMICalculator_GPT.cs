using System;

namespace Exercise
{
    class BMICalculator_GPT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your height (in inches): ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert your weight (in pounds): ");
            float weight = float.Parse(Console.ReadLine());

            string bmiCategory = CalculateBMI(height, weight);

            Console.WriteLine("Your BMI category is: " + bmiCategory);
        }

        static string CalculateBMI(float height, float weight)
        {
            float bmiValue = (weight / (height * height)) * 703;

            if (bmiValue < 18.5)
                return "Underweight";
            else if (bmiValue < 25)
                return "Normal weight";
            else if (bmiValue < 30)
                return "Overweight";
            else
                return "Obese";
        }
    }
}