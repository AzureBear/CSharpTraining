using System;
using System.Configuration;
using System.Threading;

namespace Advanced
{
    class Protector
    {
        private const string pw = "wasd";
        static public void Login()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an access code: ");
                string input = Console.ReadLine();

                if (input == pw)
                {
                    Console.WriteLine("Access granted. Starting the program...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid code. Try again.\n");
                }
            }

            Console.WriteLine("Access denied. Too many incorrect attempts. Exiting the program...");
        }
    }
}
