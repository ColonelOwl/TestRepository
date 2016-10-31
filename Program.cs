using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish() { Name = "Karp", Price = 20d, Weight = 15
            };

            Console.WriteLine(fish);
        }
    }
}
