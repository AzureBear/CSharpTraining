using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class Program
    {
        // 키 입력 이벤트를 정의하는 대리자
        public delegate void KeyPressedEventHandler(object sender, KeyPressedEventArgs e);

        // 키 입력 이벤트에 대한 이벤트 핸들러
        public static event KeyPressedEventHandler KeyPressed;

        // 키 입력 이벤트에 대한 이벤트 아큐먼트 클래스
        public class KeyPressedEventArgs : EventArgs
        {
            public ConsoleKey Key { get; set; }
        }

        // 이벤트 핸들러를 등록하는 메서드
        public static void SubscribeKeyPressedEvent(KeyPressedEventHandler handler)
        {
            KeyPressed += handler;
        }

        // 이벤트 핸들러를 해제하는 메서드
        public static void UnsubscribeKeyPressedEvent(KeyPressedEventHandler handler)
        {
            KeyPressed -= handler;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("프로그램을 실행합니다.");

            // 키 입력 이벤트 핸들러 등록
            SubscribeKeyPressedEvent(OnKeyPressed);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // 키 입력 이벤트 발생
                KeyPressed?.Invoke(null, new KeyPressedEventArgs { Key = keyInfo.Key });

                if (keyInfo.Key == ConsoleKey.Delete)
                {
                    Console.WriteLine("\n프로그램을 종료합니다.");
                    break;
                }
            }

            // 키 입력 이벤트 핸들러 해제
            UnsubscribeKeyPressedEvent(OnKeyPressed);
        }

        // 키 입력 이벤트 핸들러 메서드
        private static void OnKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.Key == ConsoleKey.Delete)
            {
                Console.WriteLine("\n'데리게이션 이벤트 처리'를 실행합니다.");
                // 원하는 처리 로직을 구현
            }
        }
    }
}
