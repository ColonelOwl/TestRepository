using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Fish
    {
        public double Price { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Name, Weight, Price);
        }
    }
}
