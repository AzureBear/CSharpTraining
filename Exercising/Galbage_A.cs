using System;

namespace Exercising
{
    class Galbage_A
    {
        static void Main(string[] args)
        {
            Random com = new Random();
            int comc = com.Next(1, 51);

            Console.WriteLine("start?");

            int usr = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                if (usr > comc)
                    Console.WriteLine("you are big");
                else if (usr < comc)
                    Console.WriteLine("you are small");
                else if (usr == comc)
                {
                    Console.WriteLine("you correct! asshole");
                    break;
                }
            }
        }
    }
}