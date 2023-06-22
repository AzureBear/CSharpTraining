using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string pwd = "wasd";

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an access code: ");
                if (pwd == Console.ReadLine())
                {
                    Console.WriteLine("Access granted. Starting the program...");
                    MainSelections(); // 진짜 프로그램 실행
                    return; // 프로그램 종료
                }
                else
                {
                    Console.WriteLine("Invalid code. Try again.\n");
                }
            }

            Console.WriteLine("Access denied. Too many incorrect attempts. Exiting the program...");
        }

        static void MainSelections()
        {
            Console.WriteLine("Welcome to the Azurk Console Prototype.");
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1. Projects\n2. GPT Samples\n3. Quit Console");

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You selected 'Projects'.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You selected 'GPT Samples'.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Quitting the console.");
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose 1, 2, or 3.");
                    break;
            }

        }

        static void Quit()
        {
            return;
        }
    }
}
