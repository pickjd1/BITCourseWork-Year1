using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceInvaders.cs;
using System.Drawing;
using System.Windows.Forms;
namespace SpaceInvaders
{
    public class EnemyShip : Ship
    {
        private const int VERTICALDROP = 30;
        private int speed;
        private const int CHANGEDIRECTION = -1;

        //constructor
        public EnemyShip(Point position, bool alive, String filename, Graphics graphics)
            : base(position, alive, filename, graphics)
        {
            speed = 20;
        }

        public void MoveX()
        {
            Position = new Point((Position.X + speed), Position.Y);
        }

        public void MoveY()
        {
            if ((Position.X > 700) || (Position.X < 5))
            {
                Position = new Point((Position.X), Position.Y + VERTICALDROP);
                speed *= CHANGEDIRECTION;
            }

        }

    }

}
