using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class CircleFactory : IGraphic2DFactory
    {
        public string Name => "Circle";
        public IGraphic2D Create()
        {
            Circle circle = new Circle(5, 5, 3);
            circle.BackgroundColor = ConsoleColor.White;
            circle.DisplayChar = 'O';
            return circle;
        }
    }
}
