using System;

namespace Exercising
{
    class UpDownGame
    {
        static void Main(string[] args)
        {
            Random com = new Random();
            int comc = com.Next(1, 51);

            Console.WriteLine("���ٿ� ������ �����ϼ���!");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("����� �����ϴ� ���ڴ�: ");
                int usr = int.Parse(Console.ReadLine());

                if (usr > comc)
                    Console.WriteLine("�ʹ� ���ƿ�!");
                else if (usr < comc)
                    Console.WriteLine("�ʹ� ���ƿ�!");
                else
                {
                    Console.WriteLine("���һ�! ����� ���߼̾��! õ���Դϴ�.");
                    break;
                }
            }
        }
    }
}