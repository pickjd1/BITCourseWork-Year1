﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public class Bomb : Weapon
    {
        private const int SPEED = 20;

        //constructor
        public Bomb(Point position, bool alive, String filename, Graphics graphics)
            : base(position, alive, filename, graphics)
        {

        }

        public void BombMove()
        {
            Position = new Point(Position.X, (Position.Y + SPEED));
        }
    }
}