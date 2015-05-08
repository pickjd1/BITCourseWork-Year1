using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpaceInvaders
{
    public abstract class Ship
    {
        //fields
        private Point position;
        private bool alive;
        private Bitmap image;
        private Graphics graphics;
        private Point bounds;


        

        
        //properties  
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
                
        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }
      
        public Graphics Graphics
        {
            get { return graphics; }
            set { graphics = value; }
        }
        
        public Point Bounds
        {
            get { return bounds; }
            set { bounds = value; }
        }

        //constuctor
        public Ship(Point position, bool alive,string filename, Graphics graphics, Point bounds)
        {
            this.position = position;
            this.alive =alive;
            image = new Bitmap(filename);
            this.graphics = graphics;
            this.bounds = bounds;
        }

        public void Draw()
        {
            if (alive == true)
            {
                graphics.DrawImage(image, position);
            }
        }

    }
}
