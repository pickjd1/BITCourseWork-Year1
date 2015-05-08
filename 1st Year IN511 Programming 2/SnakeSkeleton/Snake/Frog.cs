using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Frog : Creature
    {
        private Point position;
        private bool alive;

        public Frog(String fileName, Grid grid)
            : base(fileName, grid)
        {
            // set appropriate initial values for alive and position
            alive = false;
            position = new Point(0, 0);
        }
        
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }

        public void Draw()
        {
            // as for snake
            GetGridCellForPosition(position).Value = Body;
        }
    }
}
