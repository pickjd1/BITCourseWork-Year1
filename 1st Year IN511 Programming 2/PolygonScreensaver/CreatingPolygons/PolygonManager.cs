using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CreatingPolygons
{
    public class PolygonManager
    {
        private Polygon polygon;
        private Random random;
        private Graphics graphics;

        public PolygonManager(Random random, Graphics graphics)
        {
            this.random = random;
            this.graphics = graphics;
            polygon = null;
        }
    
        public String CreatePolygon()
        {
            polygon = null;
            switch (random.Next(3))
            {
                case 0:
                    polygon = new Circle(200, 100, 100, Color.Blue, graphics);
                    break;

                case 1:
                    polygon = new Square(200, 100, 150, Color.Red, graphics);
                    break;

                case 2:
                    polygon = new Triangle(250, 100, 100, Color.Yellow, graphics);
                    break;

                default:
                    polygon = null;
                    break;
            }

            polygon.Draw();

            return polygon.ComputeArea().ToString();

                

        }
    }
}
