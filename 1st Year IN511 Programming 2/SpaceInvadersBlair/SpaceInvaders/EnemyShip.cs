using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public class EnemyShip : Ship
    {
        private const int CHANGEDIRECTION = -1;
        private const int VERTICALDROP = 20;
        private int speed;
       // private Point position;
        private bool frontPosition;
        //private Point formWidth;

        public EnemyShip(Point position, bool alive, String filename, Graphics graphics, Point bounds)
            : base(position, alive, filename, graphics, bounds)
        {
            frontPosition = true;
            speed = 5;
        }

        public void Move()
        {
            Position = new Point((Position.X + speed), Position.Y);
            if (((Position.X + 40) > Bounds.X) || (Position.X < 0))
            {
                speed *= CHANGEDIRECTION;
                Position = new Point((Position.X + speed), Position.Y + VERTICALDROP);
            }


            //position.X += speed;
            
        }

    }
}

