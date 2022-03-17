using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Quadrat:Figure
    {
        public Quadrat(int height, int side):base(height,side)
        {
            
        }

        public override void S()
        {
            Console.WriteLine(Height * Side);
        }

        public override void toString()
        {
            Console.WriteLine("this is Quadrat");
        }
    }
}
