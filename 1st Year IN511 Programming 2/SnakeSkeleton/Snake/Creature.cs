using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public abstract class Creature
    {
        //fields
        private Bitmap body;
        private Grid grid;

        //constructor
        public Creature(String fileName, Grid grid)
        {
            body = new Bitmap(fileName);
            this.grid = grid;
        }
        
        //properties
        public Bitmap Body
        {
            get { return body; }
            set { body = value; }
        }
        
        public Grid Grid
        {
            get { return grid; }
            set { grid = value; }
        }

        public DataGridViewCell GetGridCellForPosition(Point p)
        {
            return grid.Rows[p.Y].Cells[p.X];
        }
    }
}
