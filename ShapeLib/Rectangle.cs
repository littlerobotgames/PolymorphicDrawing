using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle : AbstractGraphic2D
    {
        public Rectangle(decimal startX, decimal startY, decimal width, decimal height)
        {
            StartX = startX;
            StartY = startY;
            Width = width;
            Height = height;
        }

        public decimal StartX {  get; set; }
        public decimal StartY { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public override decimal LowerBoundX => StartX;

        public override decimal UpperBoundX => StartX + Width;

        public override decimal LowerBoundY => StartY;

        public override decimal UpperBoundY => StartY + Height;

        public override bool ContainsPoint(decimal x, decimal y)
        {
            return x >= LowerBoundX && x <= UpperBoundX && y >= LowerBoundY && y <= UpperBoundY;
        }
    }
}
