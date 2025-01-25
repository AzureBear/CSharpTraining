using System;

namespace HelloProj
{
    class Program
    {
        public static ushort dogCount;
        public static string[] dogList;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(args.Length);

            DogWorld.Program.Dog();
            Console.WriteLine("\nPlease Press C");

            ConsoleKey key = Console.ReadKey(intercept: true).Key;
            if (key == ConsoleKey.C)
            {
                Console.WriteLine($"\ndogCount: {dogCount}");
                if (dogList != null && dogList.Length > 0)
                {
                    Console.WriteLine($"\nBaby Dog: {dogList[0]}");
                }
                else
                {
                    Console.WriteLine("\nDog list is empty!");
                }
            }
        }
    }
}

namespace DogWorld
{
    public class Program
    {
        public static void Dog()
        {
            Console.WriteLine("DogSound");
            HelloProj.Program.dogCount++;
            DogBaby();
        }

        public static void DogBaby()
        {
            string[] dogs = { "Chiwawa", "Doberman", "Shapherd", "Jindo", "Shiba", "GrayHound", "Puddle" };
            Random random = new Random();

            HelloProj.Program.dogList = new string[1];
            HelloProj.Program.dogList[0] = dogs[random.Next(dogs.Length)];
        }
    }
}

namespace CatKingdom
{
    public class CatGenerator
    {
        // 필드에 명시적으로 접근 제한자 설정
        private bool catSex = false; // false: Female, true: Male
        private double catAge = 0; // 나이를 저장
        private DateTime kingdomEstablished;

        // 생성자
        public CatGenerator()
        {
            // DateTime 초기화
            kingdomEstablished = new DateTime(2024, 1, 1);
        }

        // 속성(Property)으로 멤버에 접근
        public bool CatSex {
            get { return catSex; }
            set { catSex = value; }
        }

        public double CatAge {
            get { return catAge; }
            set {
                if (value >= 0) // 나이는 음수가 될 수 없음
                {
                    catAge = value;
                }
            }
        }

        public DateTime KingdomEstablished => kingdomEstablished; // 읽기 전용
    }
}


namespace HamsterCavern
{
    public class HamGen
    {
        char h1 = 'a', h2 = 'b', h3 = 'c';
    }
    public class Program
    {

    }
}