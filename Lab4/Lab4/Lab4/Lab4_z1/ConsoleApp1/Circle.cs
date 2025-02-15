using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        string name = "ko³o";

        public override void Draw()
        {
            base.Draw(); Console.WriteLine($"{name}")
        }
    }
}