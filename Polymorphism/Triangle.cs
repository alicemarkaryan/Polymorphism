using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Triangle:Figure
    {
        public Triangle(int height, int side) : base(height, side)
        {
            
        }
        public override void S()
        {
            Console.WriteLine((Height * Side) / 2);
        }
        public override void toString()
        {
            Console.WriteLine("this is Triangle");
        }


    }
}
