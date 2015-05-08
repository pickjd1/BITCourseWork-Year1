using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CreatingPolygons
{
    public abstract class Polygon
    {
        private int left;
        private int top;
        private int width;
        private Color colour;
        private Graphics graphics;

        public int Left
        {
            get { return left; }
            set { left = value; }
        }
        public int Top
        {
            get { return top; }
            set { top = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public Color Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }

        public abstract void Draw();

        public abstract double ComputeArea();
    
        public Polygon(int left, int top, int width, Color colour, Graphics graphics)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.colour = colour;
            this.graphics = graphics;
        }

    }

}
