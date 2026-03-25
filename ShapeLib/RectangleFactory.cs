using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class RectangleFactory : IGraphic2DFactory
    {
        public string Name => "Rectangle";

        public IGraphic2D Create()
        {
            Rectangle rectangle = new Rectangle(2, 2, 5, 2);
            rectangle.BackgroundColor = ConsoleColor.Blue;
            return rectangle;
        }
    }
}
