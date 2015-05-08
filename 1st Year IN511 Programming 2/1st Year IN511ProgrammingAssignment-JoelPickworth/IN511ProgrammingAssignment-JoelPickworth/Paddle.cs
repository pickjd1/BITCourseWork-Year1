using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IN511ProgrammingAssignment_JoelPickworth
{
    public class Paddle
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }
        public Brush Brush
        {
            get { return brush; }
            set { brush = value; }
        }
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        private int height;

        private Graphics graphics;

        private Brush brush;
        private Point position;
        private Point bounds;

        public Point Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }



        public Paddle(Point position, int width, int height, Graphics graphics, Color color, Point bounds)
        {
            this.position = position;
            this.width = width;
            this.height = height;
            this.graphics = graphics;
            this.bounds = bounds;

            brush = new SolidBrush(color);
        }

        public void Draw()
        {
            graphics.FillRectangle(brush, position.X, position.Y, width, height);
            graphics.DrawRectangle(Pens.Blue, new Rectangle(position.X, position.Y, width, height));
        }

        public void Move(Point point)
        {
            position.X = point.X;
        }
    }
}
