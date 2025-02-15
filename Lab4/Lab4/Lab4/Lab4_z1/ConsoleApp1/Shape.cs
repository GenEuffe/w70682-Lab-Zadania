using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        double X { get; set; }
        double Y { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Rysujemy Figurę: ")
        }
    }
}
}
