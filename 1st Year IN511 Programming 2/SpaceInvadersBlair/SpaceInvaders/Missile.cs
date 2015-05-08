using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public class Missile : Ship
    {
        private const int SPEED = 25;

        public Missile(Point position, bool alive, String filename, Graphics graphics, Point bounds)
            : base(position, alive, filename, graphics, bounds)
        {
            
        }

        public void Move()
        {
            Position = new Point(Position.X, (Position.Y - SPEED));
        }
    }
}
