using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Figure
    {
        public int Height { get; set; }
        public int Side { get; set; }

        public Figure(int height, int side)
        {
            this.Height = height; this.Side = side;
        }

        public virtual void S()
        {
            Console.WriteLine(Height*Side);
        }

        public virtual void toString()
        {
            Console.WriteLine("this is Figure");
        }
    }
}
