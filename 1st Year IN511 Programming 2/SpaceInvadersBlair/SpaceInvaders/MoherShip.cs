using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public class MotherShip:Ship
    {
        public MotherShip(Point position, bool alive, String filename, Graphics graphics, Point bounds)
            : base(position, alive, filename, graphics, bounds)
        {

        }

        public void Move(int newX)
        {
            Position = new Point(newX, Position.Y);
        }
    }
}
