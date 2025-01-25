using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Class1
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            string[] words = userInput.Split(' ');

            foreach (string word in words)
            {
                char[] characters = word.ToCharArray();
                Array.Reverse(characters);
                string reversedWord = new string(characters);
                Console.Write(reversedWord + " ");
            }
        }
    }
}
