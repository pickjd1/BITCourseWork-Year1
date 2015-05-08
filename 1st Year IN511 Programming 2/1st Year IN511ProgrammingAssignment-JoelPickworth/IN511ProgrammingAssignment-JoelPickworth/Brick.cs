using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IN511ProgrammingAssignment_JoelPickworth
{
    public class Brick
    {
        private bool visible;
       
        private Color color;
        private Point size;

        public Point Size
        {
            get { return size; }
            set { size = value; }
        }
        private Brush brush;
        private Graphics graphics;
        private Point position;

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public Brush Brush
        {
            get { return brush; }
            set { brush = value; }
        }
        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }



        public Brick(Point position, Point size, Graphics graphics, Color color)
        {
            this.position = position;
            this.size = size;

            this.graphics = graphics;

            brush = new SolidBrush(color);
            visible = true;
        }

        public void Draw()
        {
            if (visible)
            {
                graphics.FillRectangle(brush, position.X, position.Y, size.X, size.Y);
                graphics.DrawRectangle(Pens.Blue, new Rectangle(position.X, position.Y, size.X, size.Y));
            }
            
        }
    }
}
