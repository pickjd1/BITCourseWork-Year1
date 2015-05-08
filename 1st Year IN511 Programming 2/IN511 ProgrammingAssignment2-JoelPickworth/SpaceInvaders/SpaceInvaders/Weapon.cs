using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
  public abstract class Weapon
    {
        private Point position;
        private Bitmap image;
        private Boolean alive;
        private Graphics graphics;
        private Point bounds;

        public Point Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }
        public Boolean Alive
        {
            get { return alive; }
            set { alive = value; }
        }
        
      //constructor
        public Weapon(Point position, bool alive, string filename, Graphics graphics)
            {
                this.position = position;
                this.alive = true;
                image = new Bitmap(filename);
                this.graphics = graphics;
            }

        public void Draw()
            {
                graphics.DrawImage(image, position);
            }



    }
}
