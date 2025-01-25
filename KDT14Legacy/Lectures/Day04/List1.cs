using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class List1
    {
        static void Main(string[] args)
        {
            //먹고 싶은 점심메뉴를 입력해주세요.
            string[] menus = new string[3];

            menus[0] = "김밥";
            menus[1] = "떡라면";
            menus[2] = "된장국";

            string[] new_menus = new string[5];
            Array.Copy(menus, new_menus, menus.Length);

            new_menus[3] = "쫄면";


            List<string> list = new List<string>();
            list.Add("김밥");
            list.Add("떡라면");
            list.Add("된장국");
            list.Add("쫄면");
            list.Add("김밥");

            for (int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            HashSet<string> set = new HashSet<string>();
            set.Add("김밥");
            set.Add("떡라면");
            set.Add("된장국");
            set.Add("쫄면");
            set.Add("김밥"); //set은 중복불가(무시)

            Console.WriteLine(set.Count);

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
