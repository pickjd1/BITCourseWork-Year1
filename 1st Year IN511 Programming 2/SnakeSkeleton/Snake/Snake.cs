using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Snake : Creature
    {
        private const int SNAKESTART = 15;
        private const int LENGTH = 8;
        private const int NCELLS = 30;

        private Bitmap head;
        private Point[] position; 
        private int length;
        private Direction direction;

        public Snake(String fileName, String fileName2, Grid grid)
            : base(fileName, grid)
        {
            head = new Bitmap(fileName2);
            direction = Direction.Right;
            length = LENGTH;

            position = new Point[100];
            for (int i = 0; i < length; i++)
            {
                // set position of each element of array
               position[i].X = SNAKESTART-i;
               position[i].Y = SNAKESTART;
            }
        }  

        public Bitmap Head
        {
            get { return head; }
            set { head = value; }
        }

        public Point[] Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Direction Direction
        {
            get { return direction; }
            set 
            {
                if (((direction == Direction.Left) && (value != Direction.Right)) || 
                   ((direction == Direction.Right) && (value != Direction.Left)) ||
                   ((direction == Direction.Up) && (value != Direction.Down)) ||
                   ((direction == Direction.Down) && (value != Direction.Up)))
                {
                    direction = value;
                }
            }
        }
  
        public void Draw()
        {
            GetGridCellForPosition(position[0]).Value = head;

            for (int i = 1; i < length; i++)
            {
                GetGridCellForPosition(position[i]).Value = Body;
            }
        }

        public void Move()
        {
            //move body parts from tail downwards
            //then move head
            for (int i = (length-1); i > 0; i--)
            {
               //position[i].X = position[i - 1].X;
               //position[i].Y = position[i - 1].Y;
                position[i] = position[i - 1];

            }

            switch (direction)
            {
                case Direction.Left:
                    {
                        position[0].X = position[0].X - 1;
                        break;
                    }
                case Direction.Right:
                    {
                        position[0].X = position[0].X + 1;
                        break;
                    }
                case Direction.Up:
                    {
                        position[0].Y = position[0].Y - 1;
                        break;
                    }
                case Direction.Down:
                    {
                        position[0].Y = position[0].Y + 1;
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
        }

        public void Grow()
        {
            // increase length by 1
            // populate new body part
            length++;
            position[length - 1] = position[length - 2];
        }

        public bool HitSelf()
        {
           // check whether head has hit any body part
           // return true or false
            bool hit = false;
            for (int i = 1; i < length; i++)
            {
                if (position[0] == position[1])
                {
                    hit = true;
                }
            }
            return hit;

        }

        public bool HitWall()
        {
            // check whether head has hit edge of form
            // return true or false
            bool hit = false;
            if (((position[0].X < 0) || (position[0].X > (NCELLS - 1)) ||
                (position[0].Y < 0) || (position[0].Y > (NCELLS - 1))))
            {
                hit = true;
            }
            return hit;
        }

        public bool EatenFrog(Point frogPosition)
        {
           // check whether head is at same position as frog's position
           // return true or false
            bool eaten = false;

            if (position[0] == frogPosition)
            {
                eaten = true;
            }
            return eaten;
        }
    }
}
