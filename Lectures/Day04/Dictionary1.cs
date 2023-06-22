using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();

            scores.Add("aaa", 89);
            scores.Add("bbb", 93);
            scores.Add("ccc", 78);

            Console.WriteLine(scores["ccc"]);

            scores["aaa"] = 75;

            int bScore = scores["bbb"];

            scores.Remove("ccc");

            if (scores.ContainsKey("ccc"))
            {
                Console.WriteLine(scores["ccc"]);
            }
            else
            {
                Console.WriteLine("해당학생이 없습니다.");
            }


            foreach (var item in scores)
            {
                Console.WriteLine(item.Key);
            }

            scores.Clear();

            Console.WriteLine(scores.Count);
        }
    }
}
