using System;

namespace GPT_Samples
{
    class UpDownGame_GPT
    {
        static void Main(string[] args)
        {
            Random com = new Random();
            int comc = com.Next(1, 51);

            Console.WriteLine("Start the Up-Down Game!");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Guess a number: ");
                int usr = int.Parse(Console.ReadLine());

                if (usr > comc)
                    Console.WriteLine("You guessed too high!");
                else if (usr < comc)
                    Console.WriteLine("You guessed too low!");
                else
                {
                    Console.WriteLine("You guessed correctly! Congrats!");
                    break;
                }
            }
        }
    }
}
