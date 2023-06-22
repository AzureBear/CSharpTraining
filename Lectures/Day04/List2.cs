using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class List2
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("aaa");
            list.Add("bbb");
            list.Insert(1, "ccc");
            list.Add("aaa");

            list.Remove("aaa");
            list.RemoveAt(1);

            Console.WriteLine(string.Join(",", list));

            list.Sort();
            list.Reverse();

            Console.WriteLine(string.Join(",", list));


            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("01", "aaa");
            dict.Add("02", "bbb");
            dict.Add("03", "bbb"); //딕셔너리는 value는 중복 가능 
            //dict.Add("02", "ccc"); //딕셔너리는 key는 중복 불가 (오류발생)

            dict["04"] = "ddd"; //추가 또는 수정
            dict["02"] = "www";

            //foreach(KeyValuePair<string, string> item in dict)
            foreach (var item in dict)
            {
                Console.WriteLine($"key: {item.Key}, value:{item.Value}");
            }

            Console.WriteLine(dict["04"]);
        }
    }
}