using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public class Bomb : Ship
    {
        private const int SPEED = 20;
    
        public Bomb(Point position, bool alive, String filename, Graphics graphics, Point bounds)
            : base(position, alive, filename, graphics, bounds)
        {
            
        }

        public void BombMove()
        {
            Position = new Point(Position.X, (Position.Y + SPEED));
        }
       
    }
}
