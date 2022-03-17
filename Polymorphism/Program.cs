using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Figure(5,5);
            f.S();
            f.toString();
            Quadrat q = new Quadrat(10, 20);
            q.S();
            q.toString();
            Triangle t = new Triangle(5,15);
            t.toString();
            t.S();


        }
    }
}
