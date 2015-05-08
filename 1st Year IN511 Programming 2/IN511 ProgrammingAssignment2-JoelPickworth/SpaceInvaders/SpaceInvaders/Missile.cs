using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public class Missile : Weapon
    {
        private const int SPEED = 50;

        //constructor
        public Missile(Point position, bool alive, String filename, Graphics graphics)
            : base(position, alive, filename, graphics)
        {
        }

        public void Move()
        {
              Position = new Point(Position.X, (Position.Y - SPEED));
        }       
        
    }
}
