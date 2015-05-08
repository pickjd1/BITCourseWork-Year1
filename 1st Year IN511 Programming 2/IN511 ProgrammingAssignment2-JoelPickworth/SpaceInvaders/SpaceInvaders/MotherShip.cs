using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceInvaders.cs;
using System.Drawing;

namespace SpaceInvaders
{
    public class MotherShip : Ship
    {
        //constructor
        public MotherShip(Point position, bool alive, String filename, Graphics graphics)
            : base(position, alive, filename, graphics)
        {

        }

        public void Move(int newX)
        {
            Position = new Point(newX, Position.Y);
        }
    }
}
