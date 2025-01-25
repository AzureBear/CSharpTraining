using System;
using System.Threading;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurkConsole
{
    class AzurkConsole
    {
        static void Main(string[] args)
        {
            Protector.Login();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Display();
        }

    }

    abstract class Menu
    {
        protected string[] Items { get; set; }
        public abstract void Display();

        protected virtual void Selection()
        {

        }
    }

    class MainMenu : Menu
    {
        public MainMenu()
        {
            Items = new string[] { "프로젝트", "샘플코드" };
        }

        public override void Display()
        {
            Effects.WriteLine(TxtBox.Main_Sel); // 다음항목을 선택하세요
            for (int i = 0; i < Items.Length; i++)
            {
                Effects.WriteLine($"{i + 1}. {Items[i]}");
            }
        }

        protected override void Selection()
        {
            int choice;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("sel: ");

            }
        }
    }

}
