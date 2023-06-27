using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercising
{
    class ExerciseB
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product(){Name = "감자",Price = 2400 },
                new Product(){Name = "부추",Price = 1000 },
                new Product(){Name = "귤", Price = 3000}
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
