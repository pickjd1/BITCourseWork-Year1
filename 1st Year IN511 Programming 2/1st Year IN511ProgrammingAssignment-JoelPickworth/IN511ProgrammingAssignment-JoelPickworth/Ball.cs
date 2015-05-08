using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IN511ProgrammingAssignment_JoelPickworth
{
    public class Ball
    {
        private const int CHANGEDIRECTION = -1;

        private Point position;
        private Point velocity;
        //private Color color;
        private int diameter;
        private Graphics graphics;
        private Brush brush;
        private Point bounds;

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
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
        public Point Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }

        public Ball(Point position, Point velocity, int diameter, Graphics graphics, Point bounds, Color color)
        {
            this.position = position;
            this.velocity = velocity;
            this.diameter = diameter;
            this.graphics = graphics;
            this.bounds = bounds;

            brush = new SolidBrush(color);
        }


        public Point Velocity
        {
            get { return velocity; }
            set
            {
                if (velocity.X > 0)
                {
                    velocity = new Point(value.X, velocity.Y);
                }
                else
                {
                    velocity = new Point((value.X * -1), velocity.Y);
                }

                if (velocity.Y > 0)
                {
                    velocity = new Point(velocity.X, value.Y);
                }
                else
                {
                    velocity = new Point(velocity.X, value.Y * -1);
                }
            }

        }


    
        public void Move()
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
        }

        public void Draw()
        {
            graphics.FillEllipse(brush, position.X, position.Y, diameter, diameter);

        }

        public void Bounce()
        {
            if (((position.X + diameter) > (bounds.X - 20)) || (position.X < 10))
            {
                velocity.X = velocity.X * CHANGEDIRECTION;
            }

            if (((position.Y + diameter) > (bounds.Y - 40)) || (position.Y < 10))
            {
                velocity.Y = velocity.Y * CHANGEDIRECTION;
            }
        }

        public void FallOffBottom(Timer timer1)
        {
            if ((position.Y + diameter) > (bounds.Y - 40))
            {
                timer1.Enabled = false;
                MessageBox.Show("GAMER OVER");
            }
        }

        public void HitTop()
        {
            if (position.Y < 25)
            {
                velocity.Y = velocity.Y * CHANGEDIRECTION;
            }
        }

        public void HitPaddle(Paddle paddle)
        {
            if (((Position.Y + diameter) > (paddle.Position.Y-9)) || ((Position.Y) > (paddle.Position.Y + paddle.Height)))
                {
                    if (((Position.X + diameter) > (paddle.Position.X)) && ((Position.X) < (paddle.Position.X + paddle.Width)))
                        {
                            velocity = new Point((Velocity.X), (Velocity.Y *CHANGEDIRECTION));
                        }
                }
        }
    }
}
