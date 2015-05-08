using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CreatingPolygons
{
    public class Circle : Polygon
    {
        public Circle(int left, int top, int width, Color colour, Graphics graphics)
            : base(left, top, width, colour, graphics)
        {

        }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(Colour);
            Graphics.FillEllipse(brush, Left, Top, Width, Width);
            Graphics.DrawEllipse(Pens.Black, Left, Top, Width, Width);

        }

        public override double ComputeArea()
        {
            return (Math.PI * (Width/2) * (Width/2)); 
        }
    }
}
