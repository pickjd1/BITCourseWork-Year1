using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CreatingPolygons
{
    public class Square : Polygon
    {
        public Square(int left, int top, int width, Color colour, Graphics graphics)
            : base(left, top, width, colour, graphics)
        {
        }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(Colour);
            Graphics.FillRectangle(brush, Left, Top, Width, Width);
            Graphics.DrawRectangle(Pens.Black, Left, Top, Width, Width);
        }

        public override double ComputeArea()
        {
            return (Width * Width);
        }
    }
}
