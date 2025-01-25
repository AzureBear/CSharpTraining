using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurkConsole
{
    class Protector
    {
        private const string pw = "wasd";
        static public void Login() {

            for (int i = 0; i < 5; i++) {

                Effects.WriteLine(TxtBox.Login_EntrCode);
                Console.WriteLine("");
                string input = Console.ReadLine();

                if (input == pw) {
                    Console.Clear();
                    return;
                }
                else {
                    Console.Clear();
                    Effects.WriteLine(TxtBox.Login_Invalid);
                    Console.WriteLine();
                }
            }
            Console.Clear();
            Effects.WriteLine(TxtBox.Login_Failed);
            Console.WriteLine();
        }
    }
}
