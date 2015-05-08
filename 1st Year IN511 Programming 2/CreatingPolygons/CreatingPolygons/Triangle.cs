using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CreatingPolygons
{
    public class Triangle : Polygon
    {
        public Triangle(int left, int top, int width, Color colour, Graphics graphics)
            : base(left, top, width, colour, graphics)
        {
        }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(Colour);

            Graphics.FillPolygon(brush, new Point[]
            {   new Point(Left, Top),
                new Point(Left + Width, Top + Width),
                new Point(Left - Width, Top + Width),
            });

            Graphics.DrawPolygon(Pens.Black, new Point[]
            {   new Point(Left, Top),
                new Point(Left + Width, Top + Width),
                new Point(Left - Width, Top + Width),
            });

        }

        public override double ComputeArea()
        {
            return (0.5 * (Width * 2) * Width);
        }
    }
}
