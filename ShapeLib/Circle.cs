using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : AbstractGraphic2D
    {
        public decimal CenterX { get; set; }
        public decimal CenterY {  get; set; }
        public decimal Radius {  get; set; }
        public Circle(decimal x, decimal y, decimal radius)
        {
            CenterX = x;
            CenterY = y;
            Radius = radius;
        }

        public override decimal LowerBoundX => CenterX - Radius;

        public override decimal UpperBoundX => CenterX + Radius;

        public override decimal LowerBoundY => CenterY - Radius;

        public override decimal UpperBoundY => CenterY + Radius;

        public override bool ContainsPoint(decimal x, decimal y)
        {
            decimal diffX = x - CenterX;
            decimal diffY = y - CenterY;

            decimal disSquared = (diffX * diffX) + (diffY * diffY);

            decimal radSquared = Radius + Radius;

            return disSquared <= radSquared;
        }
    }
}
